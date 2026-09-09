using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using PizzeriaOrder.Api.Models.Orders;

namespace PizzeriaOrder.Api.Services.Email;

public class BrevoEmailService : IEmailService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IConfiguration _configuration;
    private readonly ILogger<BrevoEmailService> _logger;

    public BrevoEmailService(
        IHttpClientFactory httpClientFactory,
        IConfiguration configuration,
        ILogger<BrevoEmailService> logger)
    {
        _httpClientFactory = httpClientFactory;
        _configuration = configuration;
        _logger = logger;
    }

    public async Task SendOrderConfirmationAsync(
        Order order,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(order.Email))
        {
            return;
        }

        var subject =
            $"Orderbekräftelse #{order.Id} - Trödje Pizzeria";

        var htmlContent =
            BuildOrderConfirmationHtml(order);

        await SendEmailAsync(
            order.Email,
            order.CustomerName,
            subject,
            htmlContent,
            order.Id,
            cancellationToken);
    }

    public async Task SendOrderStatusEmailAsync(
        Order order,
        CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(order.Email))
        {
            return;
        }

        string subject;
        string heading;
        string message;

        switch (order.Status)
        {
            case "Confirmed":
                subject =
                    $"Order #{order.Id} är bekräftad - Trödje Pizzeria";

                heading =
                    "Din beställning är bekräftad!";

                message =
                    "Vi har bekräftat din beställning och kommer att börja tillaga den.";

                break;

            case "ReadyForPickup":
                subject =
                    $"Order #{order.Id} är klar för hämtning - Trödje Pizzeria";

                heading =
                    "Din beställning är klar!";

                message =
                    "Din beställning är färdig och kan hämtas hos Trödje Pizzeria.";

                break;

            default:
                return;
        }

        var htmlContent =
            BuildStatusEmailHtml(
                order,
                heading,
                message);

        await SendEmailAsync(
            order.Email,
            order.CustomerName,
            subject,
            htmlContent,
            order.Id,
            cancellationToken);
    }

    private async Task SendEmailAsync(
        string recipientEmail,
        string recipientName,
        string subject,
        string htmlContent,
        int orderId,
        CancellationToken cancellationToken)
    {
        var apiKey =
            _configuration["Brevo:ApiKey"];

        var senderEmail =
            _configuration["Brevo:SenderEmail"];

        var senderName =
            _configuration["Brevo:SenderName"]
            ?? "Trödje Pizzeria";

        if (string.IsNullOrWhiteSpace(apiKey))
        {
            throw new InvalidOperationException(
                "Brevo:ApiKey saknas.");
        }

        if (string.IsNullOrWhiteSpace(senderEmail))
        {
            throw new InvalidOperationException(
                "Brevo:SenderEmail saknas.");
        }

        var payload = new
        {
            sender = new
            {
                name = senderName,
                email = senderEmail
            },

            to = new[]
            {
                new
                {
                    email = recipientEmail,
                    name = recipientName
                }
            },

            subject,

            htmlContent
        };

        var json =
            JsonSerializer.Serialize(payload);

        using var request =
            new HttpRequestMessage(
                HttpMethod.Post,
                "https://api.brevo.com/v3/smtp/email");

        request.Headers.Add(
            "api-key",
            apiKey);

        request.Headers.Accept.Add(
            new MediaTypeWithQualityHeaderValue(
                "application/json"));

        request.Content =
            new StringContent(
                json,
                Encoding.UTF8,
                "application/json");

        var client =
            _httpClientFactory.CreateClient();

        using var response =
            await client.SendAsync(
                request,
                cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            var responseText =
                await response.Content.ReadAsStringAsync(
                    cancellationToken);

            _logger.LogError(
                "Brevo kunde inte skicka e-post för order {OrderId}. Status: {StatusCode}. Svar: {Response}",
                orderId,
                response.StatusCode,
                responseText);

            throw new InvalidOperationException(
                $"Brevo kunde inte skicka e-post. HTTP {(int)response.StatusCode}.");
        }

        _logger.LogInformation(
            "Brevo-mejl skickat för order {OrderId} till {Email}.",
            orderId,
            recipientEmail);
    }

    private static string BuildOrderConfirmationHtml(
        Order order)
    {
        var itemsHtml =
            new StringBuilder();

        foreach (var item in order.Items)
        {
            itemsHtml.Append($"""
                <div style="padding:14px 0;border-bottom:1px solid #eeeeee;">

                    <table
                        role="presentation"
                        width="100%"
                        cellspacing="0"
                        cellpadding="0"
                        border="0"
                    >
                        <tr>
                            <td
                                style="
                                    font-weight:bold;
                                    padding-right:20px;
                                "
                            >
                                {item.Quantity} × {Html(item.Name)}
                            </td>

                            <td
                                align="right"
                                style="
                                    font-weight:bold;
                                    white-space:nowrap;
                                "
                            >
                                {item.TotalPrice:0} kr
                            </td>
                        </tr>
                    </table>
            """);

            if (item.Variant is not null)
            {
                itemsHtml.Append($"""
                    <div
                        style="
                            margin-top:5px;
                            color:#666666;
                        "
                    >
                        {Html(item.Variant.Name)}
                    </div>
                """);
            }

            foreach (var extra in item.Extras)
            {
                var sign =
                    extra.PriceChange >= 0
                        ? "+"
                        : "";

                itemsHtml.Append($"""
                    <div
                        style="
                            margin-top:4px;
                            color:#666666;
                        "
                    >
                        + {Html(extra.Name)}
                        ({sign}{extra.PriceChange:0} kr)
                    </div>
                """);
            }

            if (!string.IsNullOrWhiteSpace(item.Comment))
            {
                itemsHtml.Append($"""
                    <div
                        style="
                            margin-top:6px;
                            color:#666666;
                            font-style:italic;
                        "
                    >
                        Kommentar: {Html(item.Comment)}
                    </div>
                """);
            }

            itemsHtml.Append("</div>");
        }

        var orderComment = "";

        if (!string.IsNullOrWhiteSpace(order.Comment))
        {
            orderComment = $"""
                <div
                    style="
                        margin-top:20px;
                        padding:14px;
                        background:#f7f7f7;
                        border-radius:8px;
                    "
                >
                    <strong>
                        Kommentar till beställningen
                    </strong>

                    <div style="margin-top:6px;">
                        {Html(order.Comment)}
                    </div>
                </div>
            """;
        }

        return $"""
            <!DOCTYPE html>
            <html lang="sv">
            <head>
                <meta charset="UTF-8">
            </head>

            <body
                style="
                    margin:0;
                    padding:0;
                    background:#f4f4f4;
                    font-family:Arial,sans-serif;
                    color:#111111;
                "
            >
                <div
                    style="
                        max-width:620px;
                        margin:0 auto;
                        padding:30px 15px;
                    "
                >
                    <div
                        style="
                            background:#ffffff;
                            border-radius:12px;
                            overflow:hidden;
                        "
                    >
                        <div
                            style="
                                background:#d71920;
                                padding:25px;
                                text-align:center;
                                color:#ffffff;
                            "
                        >
                            <h1
                                style="
                                    margin:0;
                                    font-size:28px;
                                "
                            >
                                TRÖDJE PIZZERIA
                            </h1>
                        </div>

                        <div style="padding:30px;">

                            <h2 style="margin-top:0;">
                                Tack för din beställning!
                            </h2>

                            <p>
                                Hej {Html(order.CustomerName)},
                            </p>

                            <p>
                                Vi har tagit emot din beställning.
                            </p>

                            <div
                                style="
                                    margin:25px 0;
                                    padding:18px;
                                    background:#f7f7f7;
                                    border-radius:8px;
                                "
                            >
                                <strong>
                                    Ordernummer
                                </strong>

                                <div
                                    style="
                                        margin-top:4px;
                                        font-size:26px;
                                        color:#d71920;
                                        font-weight:bold;
                                    "
                                >
                                    #{order.Id}
                                </div>
                            </div>

                            <h3>
                                Din beställning
                            </h3>

                            {itemsHtml}

                            <table
                                role="presentation"
                                width="100%"
                                cellspacing="0"
                                cellpadding="0"
                                border="0"
                                style="
                                    margin-top:25px;
                                    border-top:2px solid #111111;
                                    font-size:20px;
                                "
                            >
                                <tr>
                                    <td
                                        style="
                                            font-weight:bold;
                                            padding-top:18px;
                                        "
                                    >
                                        Totalt
                                    </td>

                                    <td
                                        align="right"
                                        style="
                                            font-weight:bold;
                                            color:#d71920;
                                            white-space:nowrap;
                                            padding-top:18px;
                                        "
                                    >
                                        {order.TotalPrice:0} kr
                                    </td>
                                </tr>
                            </table>

                            {orderComment}

                            <div
                                style="
                                    margin-top:30px;
                                    padding-top:20px;
                                    border-top:1px solid #eeeeee;
                                    color:#555555;
                                "
                            >
                                <strong>
                                    Trödje Pizzeria
                                </strong>

                                <div style="margin-top:5px;">
                                    Tittmyrvägen 1, 805 96 Gävle
                                </div>

                                <div>
                                    026-16 14 11
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </body>
            </html>
            """;
    }

    private static string BuildStatusEmailHtml(
        Order order,
        string heading,
        string message)
    {
        return $"""
            <!DOCTYPE html>
            <html lang="sv">
            <head>
                <meta charset="UTF-8">
            </head>

            <body
                style="
                    margin:0;
                    padding:0;
                    background:#f4f4f4;
                    font-family:Arial,sans-serif;
                    color:#111111;
                "
            >
                <div
                    style="
                        max-width:620px;
                        margin:0 auto;
                        padding:30px 15px;
                    "
                >
                    <div
                        style="
                            background:#ffffff;
                            border-radius:12px;
                            overflow:hidden;
                        "
                    >
                        <div
                            style="
                                background:#d71920;
                                padding:25px;
                                text-align:center;
                                color:#ffffff;
                            "
                        >
                            <h1
                                style="
                                    margin:0;
                                    font-size:28px;
                                "
                            >
                                TRÖDJE PIZZERIA
                            </h1>
                        </div>

                        <div style="padding:30px;">

                            <h2 style="margin-top:0;">
                                {Html(heading)}
                            </h2>

                            <p>
                                Hej {Html(order.CustomerName)},
                            </p>

                            <p>
                                {Html(message)}
                            </p>

                            <div
                                style="
                                    margin:25px 0;
                                    padding:18px;
                                    background:#f7f7f7;
                                    border-radius:8px;
                                "
                            >
                                <strong>
                                    Ordernummer
                                </strong>

                                <div
                                    style="
                                        margin-top:4px;
                                        font-size:26px;
                                        color:#d71920;
                                        font-weight:bold;
                                    "
                                >
                                    #{order.Id}
                                </div>
                            </div>

                            <table
                                role="presentation"
                                width="100%"
                                cellspacing="0"
                                cellpadding="0"
                                border="0"
                            >
                                <tr>
                                    <td
                                        style="
                                            font-weight:bold;
                                        "
                                    >
                                        Totalt
                                    </td>

                                    <td
                                        align="right"
                                        style="
                                            font-weight:bold;
                                            color:#d71920;
                                            white-space:nowrap;
                                        "
                                    >
                                        {order.TotalPrice:0} kr
                                    </td>
                                </tr>
                            </table>

                            <div
                                style="
                                    margin-top:30px;
                                    padding-top:20px;
                                    border-top:1px solid #eeeeee;
                                    color:#555555;
                                "
                            >
                                <strong>
                                    Trödje Pizzeria
                                </strong>

                                <div style="margin-top:5px;">
                                    Tittmyrvägen 1, 805 96 Gävle
                                </div>

                                <div>
                                    026-16 14 11
                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </body>
            </html>
            """;
    }

    private static string Html(
        string? value)
    {
        if (string.IsNullOrEmpty(value))
        {
            return string.Empty;
        }

        return System.Net.WebUtility.HtmlEncode(value);
    }
}