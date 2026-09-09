using PizzeriaOrder.Api.Models.Orders;

namespace PizzeriaOrder.Api.Services.Email;

public interface IEmailService
{
    Task SendOrderConfirmationAsync(
        Order order,
        CancellationToken cancellationToken = default);

    Task SendOrderStatusEmailAsync(
        Order order,
        CancellationToken cancellationToken = default);
}