using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PizzeriaOrder.Api.Migrations
{
    /// <inheritdoc />
    public partial class SeedFullTrodjeMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuItemExtras",
                columns: new[] { "Id", "IsActive", "MenuItemId", "Name", "PriceChange", "SortOrder" },
                values: new object[,]
                {
                    { 1, true, 1, "Kebab", 25m, 1 },
                    { 2, true, 1, "Barnstorlek", -10m, 2 },
                    { 3, true, 1, "Glutenfri", 35m, 3 },
                    { 4, true, 1, "Extra pålägg", 15m, 4 },
                    { 5, true, 1, "Pizzasallad", 15m, 5 },
                    { 6, true, 1, "Dressing", 15m, 6 },
                    { 7, true, 2, "Kebab", 25m, 1 },
                    { 8, true, 2, "Barnstorlek", -10m, 2 },
                    { 9, true, 2, "Glutenfri", 35m, 3 },
                    { 10, true, 2, "Extra pålägg", 15m, 4 },
                    { 11, true, 2, "Pizzasallad", 15m, 5 },
                    { 12, true, 2, "Dressing", 15m, 6 },
                    { 13, true, 3, "Kebab", 25m, 1 },
                    { 14, true, 3, "Barnstorlek", -10m, 2 },
                    { 15, true, 3, "Glutenfri", 35m, 3 },
                    { 16, true, 3, "Extra pålägg", 15m, 4 },
                    { 17, true, 3, "Pizzasallad", 15m, 5 },
                    { 18, true, 3, "Dressing", 15m, 6 },
                    { 19, true, 4, "Kebab", 25m, 1 },
                    { 20, true, 4, "Barnstorlek", -10m, 2 },
                    { 21, true, 4, "Glutenfri", 35m, 3 },
                    { 22, true, 4, "Extra pålägg", 15m, 4 },
                    { 23, true, 4, "Pizzasallad", 15m, 5 },
                    { 24, true, 4, "Dressing", 15m, 6 },
                    { 25, true, 5, "Kebab", 25m, 1 },
                    { 26, true, 5, "Barnstorlek", -10m, 2 },
                    { 27, true, 5, "Glutenfri", 35m, 3 },
                    { 28, true, 5, "Extra pålägg", 15m, 4 },
                    { 29, true, 5, "Pizzasallad", 15m, 5 },
                    { 30, true, 5, "Dressing", 15m, 6 },
                    { 31, true, 6, "Kebab", 25m, 1 },
                    { 32, true, 6, "Barnstorlek", -10m, 2 },
                    { 33, true, 6, "Glutenfri", 35m, 3 },
                    { 34, true, 6, "Extra pålägg", 15m, 4 },
                    { 35, true, 6, "Pizzasallad", 15m, 5 },
                    { 36, true, 6, "Dressing", 15m, 6 },
                    { 37, true, 7, "Kebab", 25m, 1 },
                    { 38, true, 7, "Barnstorlek", -10m, 2 },
                    { 39, true, 7, "Glutenfri", 35m, 3 },
                    { 40, true, 7, "Extra pålägg", 15m, 4 },
                    { 41, true, 7, "Pizzasallad", 15m, 5 },
                    { 42, true, 7, "Dressing", 15m, 6 },
                    { 43, true, 8, "Kebab", 25m, 1 },
                    { 44, true, 8, "Barnstorlek", -10m, 2 },
                    { 45, true, 8, "Glutenfri", 35m, 3 },
                    { 46, true, 8, "Extra pålägg", 15m, 4 },
                    { 47, true, 8, "Pizzasallad", 15m, 5 },
                    { 48, true, 8, "Dressing", 15m, 6 },
                    { 49, true, 9, "Kebab", 25m, 1 },
                    { 50, true, 9, "Barnstorlek", -10m, 2 },
                    { 51, true, 9, "Glutenfri", 35m, 3 },
                    { 52, true, 9, "Extra pålägg", 15m, 4 },
                    { 53, true, 9, "Pizzasallad", 15m, 5 },
                    { 54, true, 9, "Dressing", 15m, 6 },
                    { 55, true, 10, "Kebab", 25m, 1 },
                    { 56, true, 10, "Barnstorlek", -10m, 2 },
                    { 57, true, 10, "Glutenfri", 35m, 3 },
                    { 58, true, 10, "Extra pålägg", 15m, 4 },
                    { 59, true, 10, "Pizzasallad", 15m, 5 },
                    { 60, true, 10, "Dressing", 15m, 6 },
                    { 61, true, 11, "Kebab", 25m, 1 },
                    { 62, true, 11, "Barnstorlek", -10m, 2 },
                    { 63, true, 11, "Glutenfri", 35m, 3 },
                    { 64, true, 11, "Extra pålägg", 15m, 4 },
                    { 65, true, 11, "Pizzasallad", 15m, 5 },
                    { 66, true, 11, "Dressing", 15m, 6 },
                    { 67, true, 12, "Kebab", 25m, 1 },
                    { 68, true, 12, "Barnstorlek", -10m, 2 },
                    { 69, true, 12, "Glutenfri", 35m, 3 },
                    { 70, true, 12, "Extra pålägg", 15m, 4 },
                    { 71, true, 12, "Pizzasallad", 15m, 5 },
                    { 72, true, 12, "Dressing", 15m, 6 },
                    { 73, true, 13, "Kebab", 25m, 1 },
                    { 74, true, 13, "Barnstorlek", -10m, 2 },
                    { 75, true, 13, "Glutenfri", 35m, 3 },
                    { 76, true, 13, "Extra pålägg", 15m, 4 },
                    { 77, true, 13, "Pizzasallad", 15m, 5 },
                    { 78, true, 13, "Dressing", 15m, 6 },
                    { 79, true, 14, "Kebab", 25m, 1 },
                    { 80, true, 14, "Barnstorlek", -10m, 2 },
                    { 81, true, 14, "Glutenfri", 35m, 3 },
                    { 82, true, 14, "Extra pålägg", 15m, 4 },
                    { 83, true, 14, "Pizzasallad", 15m, 5 },
                    { 84, true, 14, "Dressing", 15m, 6 },
                    { 85, true, 15, "Kebab", 25m, 1 },
                    { 86, true, 15, "Barnstorlek", -10m, 2 },
                    { 87, true, 15, "Glutenfri", 35m, 3 },
                    { 88, true, 15, "Extra pålägg", 15m, 4 },
                    { 89, true, 15, "Pizzasallad", 15m, 5 },
                    { 90, true, 15, "Dressing", 15m, 6 },
                    { 91, true, 16, "Kebab", 25m, 1 },
                    { 92, true, 16, "Barnstorlek", -10m, 2 },
                    { 93, true, 16, "Glutenfri", 35m, 3 },
                    { 94, true, 16, "Extra pålägg", 15m, 4 },
                    { 95, true, 16, "Pizzasallad", 15m, 5 },
                    { 96, true, 16, "Dressing", 15m, 6 },
                    { 97, true, 17, "Kebab", 25m, 1 },
                    { 98, true, 17, "Barnstorlek", -10m, 2 },
                    { 99, true, 17, "Glutenfri", 35m, 3 },
                    { 100, true, 17, "Extra pålägg", 15m, 4 },
                    { 101, true, 17, "Pizzasallad", 15m, 5 },
                    { 102, true, 17, "Dressing", 15m, 6 },
                    { 103, true, 18, "Kebab", 25m, 1 },
                    { 104, true, 18, "Barnstorlek", -10m, 2 },
                    { 105, true, 18, "Glutenfri", 35m, 3 },
                    { 106, true, 18, "Extra pålägg", 15m, 4 },
                    { 107, true, 18, "Pizzasallad", 15m, 5 },
                    { 108, true, 18, "Dressing", 15m, 6 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "Id", "Description", "ImageUrl", "IsActive", "MenuCategoryId", "Name", "Price", "SortOrder" },
                values: new object[,]
                {
                    { 19, "Köttfärs & lök", null, true, 3, "Orientale", 110m, 1 },
                    { 20, "Köttfärs, ägg & tabasco", null, true, 3, "Mafioso", 110m, 2 },
                    { 21, "Köttfärs, champinjoner & salladsost (feta)", null, true, 3, "Bari", 120m, 3 },
                    { 22, "Köttfärs, tomat, paprika & lök", null, true, 3, "Orientale Special", 120m, 4 },
                    { 23, "Skinka, räkor & köttfärs", null, true, 4, "Disco", 125m, 1 },
                    { 24, "Salami, lök & oliver", null, true, 4, "Campagnola", 110m, 2 },
                    { 25, "Salami, bacon, lök & ägg", null, true, 4, "Toscana", 120m, 3 },
                    { 26, "Bacon, vitlök, paprika & lök", null, true, 4, "Verona", 120m, 4 },
                    { 27, "Skinka & salami", null, true, 4, "Al Capone", 110m, 5 },
                    { 28, "Skinka, pepperonikorv, gorgonzola & tabasco", null, true, 4, "Björn Special", 120m, 6 },
                    { 29, "Marinerad oxfilé, lök, färska champinjoner, färska tomater, salladsost (feta), oliver, feferoni & tzatziki", null, true, 5, "Grekisk Pizza", 130m, 1 },
                    { 30, "Marinerad oxfilé, lök, färsk paprika, färska tomater, färsk persilja & bearnaisesås", null, true, 5, "Trödje Special", 130m, 2 },
                    { 31, "Marinerad oxfilé, lök, färsk paprika, champinjoner, färska tomater & bearnaisesås", null, true, 5, "Hilleviks Special", 130m, 3 },
                    { 32, "Marinerad fläskfilé, skinka, färska champinjoner & bearnaisesås", null, true, 5, "Husets Special", 130m, 4 },
                    { 33, "Marinerad fläskfilé, jalapeño, vitlök, färska champinjoner, färska tomater & bearnaisesås", null, true, 5, "Kockens Special", 130m, 5 },
                    { 34, "Marinerad fläskfilé, färsk paprika, färska champinjoner & bearnaisesås", null, true, 5, "Oscar", 130m, 6 },
                    { 35, "Marinerad fläskfilé, skinka, räkor, jalapeño, tomat & bearnaisesås", null, true, 5, "Texas", 130m, 7 },
                    { 36, "Oxfilé, sparris, räkor, färska tomater & bearnaisesås", null, true, 5, "Björke Special", 130m, 8 },
                    { 37, "Fläskfilé, salami, köttfärs, räkor, pommes, färska champinjoner, skinka, kebabkött & valfri sås", null, true, 5, "Vulkan Pizza", 179m, 9 },
                    { 38, "Fläskfilé, paprika, lök, tomat & bearnaisesås", null, true, 5, "Esköns Special", 130m, 10 },
                    { 39, "Oxfilé, lök & gorgonzola", null, true, 6, "Gorgonzola", 125m, 1 },
                    { 40, "Skinka, lök & gorgonzola", null, true, 6, "Ceasar", 120m, 2 },
                    { 41, "Skinka, jalapeño, tacokryddmix, tacosås & vitlökssås", null, true, 7, "Azteka", 120m, 1 },
                    { 42, "Mexikansk köttfärs, lök, vitlök, jalapeño & tacokryddmix", null, true, 7, "Mexikana", 120m, 2 },
                    { 43, "Marinerad oxfilé, lök, vitlök, jalapeño, färska champinjoner & tacokryddmix", null, true, 7, "Acapulco", 125m, 3 },
                    { 44, "Kyckling, ananas, banan & curry", null, true, 8, "Indiana", 125m, 1 },
                    { 45, "Kyckling, jordnötter, banan & curry", null, true, 8, "Kycklingpizza", 125m, 2 },
                    { 46, "Kyckling, paprika, lök & currysås", null, true, 8, "Hamrånge Special", 125m, 3 },
                    { 47, "Kebabkött, isbergssallad, rödlök, färska tomater, gurka & feferoni", null, true, 9, "Kebab Special", 140m, 1 },
                    { 48, "Halvinbakad. Kebabkött, lök, färska tomater, färsk paprika & bearnaisesås", null, true, 9, "Vikingbåt", 130m, 2 },
                    { 49, "Kebabkött, lök, feferoni & färska tomater", null, true, 9, "Kebabpizza", 130m, 3 },
                    { 50, "Pommes eller ris, isbergssallad, tomat, gurka & feferoni", null, true, 10, "Kebabtallrik", null, 1 },
                    { 51, "Färskbakat bröd, isbergssallad, rödlök, tomat, gurka & feferoni", null, true, 10, "Kebabrulle", null, 2 },
                    { 52, null, null, true, 10, "Kebabskrovmål", null, 3 },
                    { 53, "Färskbakat bröd, isbergssallad, rödlök, tomat, gurka & feferoni", null, true, 10, "Kebab med bröd", null, 4 },
                    { 54, "Med bearnaisesås", null, true, 11, "Oxfilé", null, 1 },
                    { 55, "Med bearnaisesås", null, true, 11, "Fläskfilé", null, 2 },
                    { 56, "Med rödvinssås & bearnaisesås", null, true, 11, "Filé Black & White", null, 3 },
                    { 57, "Fläskfilé, sparris, räkor & bearnaisesås", null, true, 11, "Filé Oscar", null, 4 },
                    { 58, "Med rödvinssås & bearnaisesås", null, true, 11, "Plankstek", null, 5 },
                    { 59, "Med bearnaisesås", null, true, 11, "Husets Kycklingfilé", null, 6 },
                    { 60, "Med tzatziki & tomatsås", null, true, 11, "Kycklingspett", null, 7 },
                    { 61, "Med bearnaisesås & persiljesmör", null, true, 11, "Schnitzel", null, 8 },
                    { 62, "Med bearnaisesås & persiljesmör", null, true, 11, "Lövbit", null, 9 },
                    { 63, "Med tomatsås & tzatziki", null, true, 11, "Fläskspett", null, 10 },
                    { 64, "90 g hamburgare med bröd", null, true, 12, "Big Star", 89m, 1 },
                    { 65, "90 g hamburgare med bröd, pommes & dricka 33 cl", null, true, 12, "Big Meal", 119m, 2 },
                    { 66, "150 g hamburgare med bröd", null, true, 12, "Superstar", 99m, 3 },
                    { 67, "150 g hamburgare med bröd, pommes & dricka 33 cl", null, true, 12, "Super Meal", 129m, 4 },
                    { 68, "Chicky bits, pommes, grönsaker, currydressing & dricka 33 cl", null, true, 12, "Chicky Bits Meal", 120m, 5 },
                    { 69, "Med remouladsås & kokt potatis", null, true, 13, "Rödspätta", 129m, 1 },
                    { 70, "Ox-/fläskfilé, champinjoner, tomatsås & gräddsås", null, true, 14, "Ox-/Fläskfilé Pasta", 129m, 1 },
                    { 71, "Kycklingfilé, paprika, lök & currysås", null, true, 14, "Kyckling Pasta", 129m, 2 },
                    { 72, "Stekta grönsaker & tomatgräddsås", null, true, 14, "Vegetarisk Pasta", 129m, 3 },
                    { 73, "Bacon, lök, äggula & gräddsås", null, true, 14, "Pasta Carbonara", 129m, 4 },
                    { 74, "Köttfärssås", null, true, 14, "Pasta Bolognese", 119m, 5 },
                    { 75, "Avocado, räkor, kaviar & citron", null, true, 15, "Avocadosallad", 120m, 1 },
                    { 76, "Ost, skinka & ägg", null, true, 15, "Ost & Skinksallad", 120m, 2 },
                    { 77, "Räkor, ägg, dill & citron", null, true, 15, "Räksallad", 120m, 3 },
                    { 78, "Tonfisk, rödlök, ägg & citron", null, true, 15, "Tonfisksallad", 120m, 4 },
                    { 79, "Kryddad salladskycklingfilé & ananas", null, true, 15, "Kycklingsallad", 120m, 5 },
                    { 80, "Grekisk fårost, salladsost, oliver, feferoni, rödlök, paprika, persilja & citron", null, true, 15, "Grekisk Sallad", 120m, 6 },
                    { 81, "Skinka, räkor, ost, tonfisk & ägg", null, true, 15, "Blandsallad", 120m, 7 },
                    { 82, "Räkor, tonfisk, musslor, ägg, dill & citron", null, true, 15, "Västkustsallad", 120m, 8 },
                    { 83, "Kebabkött, rödlök, feferoni, persilja & citron", null, true, 15, "Kebabsallad", 120m, 9 },
                    { 84, "45 g hamburgare med bröd & dricka 33 cl", null, true, 16, "Barnbox", 89m, 1 },
                    { 85, "Chicky bits, pommes & dricka 33 cl", null, true, 16, "Chicky Bits Meal", 89m, 2 },
                    { 86, "Med sylt & grädde, dricka 33 cl", null, true, 16, "Pannkaka", 89m, 3 }
                });

            migrationBuilder.InsertData(
                table: "MenuItemExtras",
                columns: new[] { "Id", "IsActive", "MenuItemId", "Name", "PriceChange", "SortOrder" },
                values: new object[,]
                {
                    { 109, true, 19, "Kebab", 25m, 1 },
                    { 110, true, 19, "Barnstorlek", -10m, 2 },
                    { 111, true, 19, "Glutenfri", 35m, 3 },
                    { 112, true, 19, "Extra pålägg", 15m, 4 },
                    { 113, true, 19, "Pizzasallad", 15m, 5 },
                    { 114, true, 19, "Dressing", 15m, 6 },
                    { 115, true, 20, "Kebab", 25m, 1 },
                    { 116, true, 20, "Barnstorlek", -10m, 2 },
                    { 117, true, 20, "Glutenfri", 35m, 3 },
                    { 118, true, 20, "Extra pålägg", 15m, 4 },
                    { 119, true, 20, "Pizzasallad", 15m, 5 },
                    { 120, true, 20, "Dressing", 15m, 6 },
                    { 121, true, 21, "Kebab", 25m, 1 },
                    { 122, true, 21, "Barnstorlek", -10m, 2 },
                    { 123, true, 21, "Glutenfri", 35m, 3 },
                    { 124, true, 21, "Extra pålägg", 15m, 4 },
                    { 125, true, 21, "Pizzasallad", 15m, 5 },
                    { 126, true, 21, "Dressing", 15m, 6 },
                    { 127, true, 22, "Kebab", 25m, 1 },
                    { 128, true, 22, "Barnstorlek", -10m, 2 },
                    { 129, true, 22, "Glutenfri", 35m, 3 },
                    { 130, true, 22, "Extra pålägg", 15m, 4 },
                    { 131, true, 22, "Pizzasallad", 15m, 5 },
                    { 132, true, 22, "Dressing", 15m, 6 },
                    { 133, true, 23, "Kebab", 25m, 1 },
                    { 134, true, 23, "Barnstorlek", -10m, 2 },
                    { 135, true, 23, "Glutenfri", 35m, 3 },
                    { 136, true, 23, "Extra pålägg", 15m, 4 },
                    { 137, true, 23, "Pizzasallad", 15m, 5 },
                    { 138, true, 23, "Dressing", 15m, 6 },
                    { 139, true, 24, "Kebab", 25m, 1 },
                    { 140, true, 24, "Barnstorlek", -10m, 2 },
                    { 141, true, 24, "Glutenfri", 35m, 3 },
                    { 142, true, 24, "Extra pålägg", 15m, 4 },
                    { 143, true, 24, "Pizzasallad", 15m, 5 },
                    { 144, true, 24, "Dressing", 15m, 6 },
                    { 145, true, 25, "Kebab", 25m, 1 },
                    { 146, true, 25, "Barnstorlek", -10m, 2 },
                    { 147, true, 25, "Glutenfri", 35m, 3 },
                    { 148, true, 25, "Extra pålägg", 15m, 4 },
                    { 149, true, 25, "Pizzasallad", 15m, 5 },
                    { 150, true, 25, "Dressing", 15m, 6 },
                    { 151, true, 26, "Kebab", 25m, 1 },
                    { 152, true, 26, "Barnstorlek", -10m, 2 },
                    { 153, true, 26, "Glutenfri", 35m, 3 },
                    { 154, true, 26, "Extra pålägg", 15m, 4 },
                    { 155, true, 26, "Pizzasallad", 15m, 5 },
                    { 156, true, 26, "Dressing", 15m, 6 },
                    { 157, true, 27, "Kebab", 25m, 1 },
                    { 158, true, 27, "Barnstorlek", -10m, 2 },
                    { 159, true, 27, "Glutenfri", 35m, 3 },
                    { 160, true, 27, "Extra pålägg", 15m, 4 },
                    { 161, true, 27, "Pizzasallad", 15m, 5 },
                    { 162, true, 27, "Dressing", 15m, 6 },
                    { 163, true, 28, "Kebab", 25m, 1 },
                    { 164, true, 28, "Barnstorlek", -10m, 2 },
                    { 165, true, 28, "Glutenfri", 35m, 3 },
                    { 166, true, 28, "Extra pålägg", 15m, 4 },
                    { 167, true, 28, "Pizzasallad", 15m, 5 },
                    { 168, true, 28, "Dressing", 15m, 6 },
                    { 169, true, 29, "Kebab", 25m, 1 },
                    { 170, true, 29, "Barnstorlek", -10m, 2 },
                    { 171, true, 29, "Glutenfri", 35m, 3 },
                    { 172, true, 29, "Extra pålägg", 15m, 4 },
                    { 173, true, 29, "Pizzasallad", 15m, 5 },
                    { 174, true, 29, "Dressing", 15m, 6 },
                    { 175, true, 30, "Kebab", 25m, 1 },
                    { 176, true, 30, "Barnstorlek", -10m, 2 },
                    { 177, true, 30, "Glutenfri", 35m, 3 },
                    { 178, true, 30, "Extra pålägg", 15m, 4 },
                    { 179, true, 30, "Pizzasallad", 15m, 5 },
                    { 180, true, 30, "Dressing", 15m, 6 },
                    { 181, true, 31, "Kebab", 25m, 1 },
                    { 182, true, 31, "Barnstorlek", -10m, 2 },
                    { 183, true, 31, "Glutenfri", 35m, 3 },
                    { 184, true, 31, "Extra pålägg", 15m, 4 },
                    { 185, true, 31, "Pizzasallad", 15m, 5 },
                    { 186, true, 31, "Dressing", 15m, 6 },
                    { 187, true, 32, "Kebab", 25m, 1 },
                    { 188, true, 32, "Barnstorlek", -10m, 2 },
                    { 189, true, 32, "Glutenfri", 35m, 3 },
                    { 190, true, 32, "Extra pålägg", 15m, 4 },
                    { 191, true, 32, "Pizzasallad", 15m, 5 },
                    { 192, true, 32, "Dressing", 15m, 6 },
                    { 193, true, 33, "Kebab", 25m, 1 },
                    { 194, true, 33, "Barnstorlek", -10m, 2 },
                    { 195, true, 33, "Glutenfri", 35m, 3 },
                    { 196, true, 33, "Extra pålägg", 15m, 4 },
                    { 197, true, 33, "Pizzasallad", 15m, 5 },
                    { 198, true, 33, "Dressing", 15m, 6 },
                    { 199, true, 34, "Kebab", 25m, 1 },
                    { 200, true, 34, "Barnstorlek", -10m, 2 },
                    { 201, true, 34, "Glutenfri", 35m, 3 },
                    { 202, true, 34, "Extra pålägg", 15m, 4 },
                    { 203, true, 34, "Pizzasallad", 15m, 5 },
                    { 204, true, 34, "Dressing", 15m, 6 },
                    { 205, true, 35, "Kebab", 25m, 1 },
                    { 206, true, 35, "Barnstorlek", -10m, 2 },
                    { 207, true, 35, "Glutenfri", 35m, 3 },
                    { 208, true, 35, "Extra pålägg", 15m, 4 },
                    { 209, true, 35, "Pizzasallad", 15m, 5 },
                    { 210, true, 35, "Dressing", 15m, 6 },
                    { 211, true, 36, "Kebab", 25m, 1 },
                    { 212, true, 36, "Barnstorlek", -10m, 2 },
                    { 213, true, 36, "Glutenfri", 35m, 3 },
                    { 214, true, 36, "Extra pålägg", 15m, 4 },
                    { 215, true, 36, "Pizzasallad", 15m, 5 },
                    { 216, true, 36, "Dressing", 15m, 6 },
                    { 217, true, 37, "Kebab", 25m, 1 },
                    { 218, true, 37, "Barnstorlek", -10m, 2 },
                    { 219, true, 37, "Glutenfri", 35m, 3 },
                    { 220, true, 37, "Extra pålägg", 15m, 4 },
                    { 221, true, 37, "Pizzasallad", 15m, 5 },
                    { 222, true, 37, "Dressing", 15m, 6 },
                    { 223, true, 38, "Kebab", 25m, 1 },
                    { 224, true, 38, "Barnstorlek", -10m, 2 },
                    { 225, true, 38, "Glutenfri", 35m, 3 },
                    { 226, true, 38, "Extra pålägg", 15m, 4 },
                    { 227, true, 38, "Pizzasallad", 15m, 5 },
                    { 228, true, 38, "Dressing", 15m, 6 },
                    { 229, true, 39, "Kebab", 25m, 1 },
                    { 230, true, 39, "Barnstorlek", -10m, 2 },
                    { 231, true, 39, "Glutenfri", 35m, 3 },
                    { 232, true, 39, "Extra pålägg", 15m, 4 },
                    { 233, true, 39, "Pizzasallad", 15m, 5 },
                    { 234, true, 39, "Dressing", 15m, 6 },
                    { 235, true, 40, "Kebab", 25m, 1 },
                    { 236, true, 40, "Barnstorlek", -10m, 2 },
                    { 237, true, 40, "Glutenfri", 35m, 3 },
                    { 238, true, 40, "Extra pålägg", 15m, 4 },
                    { 239, true, 40, "Pizzasallad", 15m, 5 },
                    { 240, true, 40, "Dressing", 15m, 6 },
                    { 241, true, 41, "Kebab", 25m, 1 },
                    { 242, true, 41, "Barnstorlek", -10m, 2 },
                    { 243, true, 41, "Glutenfri", 35m, 3 },
                    { 244, true, 41, "Extra pålägg", 15m, 4 },
                    { 245, true, 41, "Pizzasallad", 15m, 5 },
                    { 246, true, 41, "Dressing", 15m, 6 },
                    { 247, true, 42, "Kebab", 25m, 1 },
                    { 248, true, 42, "Barnstorlek", -10m, 2 },
                    { 249, true, 42, "Glutenfri", 35m, 3 },
                    { 250, true, 42, "Extra pålägg", 15m, 4 },
                    { 251, true, 42, "Pizzasallad", 15m, 5 },
                    { 252, true, 42, "Dressing", 15m, 6 },
                    { 253, true, 43, "Kebab", 25m, 1 },
                    { 254, true, 43, "Barnstorlek", -10m, 2 },
                    { 255, true, 43, "Glutenfri", 35m, 3 },
                    { 256, true, 43, "Extra pålägg", 15m, 4 },
                    { 257, true, 43, "Pizzasallad", 15m, 5 },
                    { 258, true, 43, "Dressing", 15m, 6 },
                    { 259, true, 44, "Kebab", 25m, 1 },
                    { 260, true, 44, "Barnstorlek", -10m, 2 },
                    { 261, true, 44, "Glutenfri", 35m, 3 },
                    { 262, true, 44, "Extra pålägg", 15m, 4 },
                    { 263, true, 44, "Pizzasallad", 15m, 5 },
                    { 264, true, 44, "Dressing", 15m, 6 },
                    { 265, true, 45, "Kebab", 25m, 1 },
                    { 266, true, 45, "Barnstorlek", -10m, 2 },
                    { 267, true, 45, "Glutenfri", 35m, 3 },
                    { 268, true, 45, "Extra pålägg", 15m, 4 },
                    { 269, true, 45, "Pizzasallad", 15m, 5 },
                    { 270, true, 45, "Dressing", 15m, 6 },
                    { 271, true, 46, "Kebab", 25m, 1 },
                    { 272, true, 46, "Barnstorlek", -10m, 2 },
                    { 273, true, 46, "Glutenfri", 35m, 3 },
                    { 274, true, 46, "Extra pålägg", 15m, 4 },
                    { 275, true, 46, "Pizzasallad", 15m, 5 },
                    { 276, true, 46, "Dressing", 15m, 6 },
                    { 277, true, 47, "Kebab", 25m, 1 },
                    { 278, true, 47, "Barnstorlek", -10m, 2 },
                    { 279, true, 47, "Glutenfri", 35m, 3 },
                    { 280, true, 47, "Extra pålägg", 15m, 4 },
                    { 281, true, 47, "Pizzasallad", 15m, 5 },
                    { 282, true, 47, "Dressing", 15m, 6 },
                    { 283, true, 48, "Kebab", 25m, 1 },
                    { 284, true, 48, "Barnstorlek", -10m, 2 },
                    { 285, true, 48, "Glutenfri", 35m, 3 },
                    { 286, true, 48, "Extra pålägg", 15m, 4 },
                    { 287, true, 48, "Pizzasallad", 15m, 5 },
                    { 288, true, 48, "Dressing", 15m, 6 },
                    { 289, true, 49, "Kebab", 25m, 1 },
                    { 290, true, 49, "Barnstorlek", -10m, 2 },
                    { 291, true, 49, "Glutenfri", 35m, 3 },
                    { 292, true, 49, "Extra pålägg", 15m, 4 },
                    { 293, true, 49, "Pizzasallad", 15m, 5 },
                    { 294, true, 49, "Dressing", 15m, 6 }
                });

            migrationBuilder.InsertData(
                table: "MenuItemVariants",
                columns: new[] { "Id", "IsActive", "MenuItemId", "Name", "Price", "SortOrder" },
                values: new object[,]
                {
                    { 1, true, 50, "Kebab", 120m, 1 },
                    { 2, true, 50, "Kyckling", 125m, 2 },
                    { 3, true, 50, "Falafel", 110m, 3 },
                    { 4, true, 51, "Kebab", 130m, 1 },
                    { 5, true, 51, "Kyckling", 135m, 2 },
                    { 6, true, 51, "Falafel", 120m, 3 },
                    { 7, true, 52, "Kebab", 120m, 1 },
                    { 8, true, 52, "Kyckling", 125m, 2 },
                    { 9, true, 52, "Falafel", 120m, 3 },
                    { 10, true, 53, "Kebab", 110m, 1 },
                    { 11, true, 53, "Kyckling", 115m, 2 },
                    { 12, true, 53, "Falafel", 100m, 3 },
                    { 13, true, 54, "Kokt potatis", 229m, 1 },
                    { 14, true, 54, "Klyftpotatis", 229m, 2 },
                    { 15, true, 54, "Pommes", 229m, 3 },
                    { 16, true, 54, "Ris", 229m, 4 },
                    { 17, true, 55, "Kokt potatis", 199m, 1 },
                    { 18, true, 55, "Klyftpotatis", 199m, 2 },
                    { 19, true, 55, "Pommes", 199m, 3 },
                    { 20, true, 55, "Ris", 199m, 4 },
                    { 21, true, 56, "Kokt potatis", 229m, 1 },
                    { 22, true, 56, "Klyftpotatis", 229m, 2 },
                    { 23, true, 56, "Pommes", 229m, 3 },
                    { 24, true, 56, "Ris", 229m, 4 },
                    { 25, true, 57, "Kokt potatis", 229m, 1 },
                    { 26, true, 57, "Klyftpotatis", 229m, 2 },
                    { 27, true, 57, "Pommes", 229m, 3 },
                    { 28, true, 57, "Ris", 229m, 4 },
                    { 29, true, 58, "Kokt potatis", 249m, 1 },
                    { 30, true, 58, "Klyftpotatis", 249m, 2 },
                    { 31, true, 58, "Pommes", 249m, 3 },
                    { 32, true, 58, "Ris", 249m, 4 },
                    { 33, true, 59, "Kokt potatis", 139m, 1 },
                    { 34, true, 59, "Klyftpotatis", 139m, 2 },
                    { 35, true, 59, "Pommes", 139m, 3 },
                    { 36, true, 59, "Ris", 139m, 4 },
                    { 37, true, 60, "Kokt potatis", 179m, 1 },
                    { 38, true, 60, "Klyftpotatis", 179m, 2 },
                    { 39, true, 60, "Pommes", 179m, 3 },
                    { 40, true, 60, "Ris", 179m, 4 },
                    { 41, true, 61, "Kokt potatis", 129m, 1 },
                    { 42, true, 61, "Klyftpotatis", 129m, 2 },
                    { 43, true, 61, "Pommes", 129m, 3 },
                    { 44, true, 61, "Ris", 129m, 4 },
                    { 45, true, 62, "Kokt potatis", 129m, 1 },
                    { 46, true, 62, "Klyftpotatis", 129m, 2 },
                    { 47, true, 62, "Pommes", 129m, 3 },
                    { 48, true, 62, "Ris", 129m, 4 },
                    { 49, true, 63, "Kokt potatis", 209m, 1 },
                    { 50, true, 63, "Klyftpotatis", 209m, 2 },
                    { 51, true, 63, "Pommes", 209m, 3 },
                    { 52, true, 63, "Ris", 209m, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "MenuItemExtras",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MenuItemVariants",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "Id",
                keyValue: 63);
        }
    }
}
