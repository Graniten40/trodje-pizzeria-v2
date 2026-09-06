using Microsoft.EntityFrameworkCore;
using PizzeriaOrder.Api.Models;
using PizzeriaOrder.Api.Models.Menu;

namespace PizzeriaOrder.Api.Data.Seed;

public static class PizzeriaSeedData
{
    public static void Apply(ModelBuilder modelBuilder)
    {
        SeedRestaurant(modelBuilder);
        SeedCategories(modelBuilder);
        SeedMenuItems(modelBuilder);
        SeedVariants(modelBuilder);
        SeedPizzaExtras(modelBuilder);
    }

    private static void SeedRestaurant(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Restaurant>().HasData(
            new Restaurant
            {
                Id = 1,
                Name = "Trödje Pizzeria",
                Address = "Tittmyrvägen 1",
                PostalCode = "805 96",
                City = "Gävle",
                Phone = "026-16 14 11",
                Email = null,
                IsActive = true,
                CreatedAtUtc = new DateTime(
                    2026, 9, 2, 0, 0, 0,
                    DateTimeKind.Utc)
            }
        );
    }

    private static void SeedCategories(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MenuCategory>().HasData(
            new MenuCategory
            {
                Id = 1,
                RestaurantId = 1,
                Name = "Skinkpizzor",
                SortOrder = 1,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 2,
                RestaurantId = 1,
                Name = "Havspizzor",
                SortOrder = 2,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 3,
                RestaurantId = 1,
                Name = "Köttfärspizzor",
                SortOrder = 3,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 4,
                RestaurantId = 1,
                Name = "Salami & Baconpizzor",
                SortOrder = 4,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 5,
                RestaurantId = 1,
                Name = "Ox-/Fläskfilépizzor",
                SortOrder = 5,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 6,
                RestaurantId = 1,
                Name = "Gorgonzolapizzor",
                SortOrder = 6,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 7,
                RestaurantId = 1,
                Name = "Mexikanska pizzor",
                SortOrder = 7,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 8,
                RestaurantId = 1,
                Name = "Kycklingpizzor",
                SortOrder = 8,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 9,
                RestaurantId = 1,
                Name = "Kebabpizzor",
                SortOrder = 9,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 10,
                RestaurantId = 1,
                Name = "Kebab / Kyckling / Falafel",
                SortOrder = 10,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 11,
                RestaurantId = 1,
                Name = "Kötträtter",
                SortOrder = 11,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 12,
                RestaurantId = 1,
                Name = "Grillrätter",
                SortOrder = 12,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 13,
                RestaurantId = 1,
                Name = "Fiskrätter",
                SortOrder = 13,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 14,
                RestaurantId = 1,
                Name = "Pastarätter",
                SortOrder = 14,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 15,
                RestaurantId = 1,
                Name = "Sallader",
                SortOrder = 15,
                IsActive = true
            },
            new MenuCategory
            {
                Id = 16,
                RestaurantId = 1,
                Name = "Barnrätter",
                SortOrder = 16,
                IsActive = true
            }
        );
    }

    private static void SeedMenuItems(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MenuItem>().HasData(
            new MenuItem
            {
                Id = 1,
                MenuCategoryId = 1,
                Name = "Margherita",
                Description = "Ost",
                Price = 100m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 2,
                MenuCategoryId = 1,
                Name = "Vesuvio",
                Description = "Skinka",
                Price = 100m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 3,
                MenuCategoryId = 1,
                Name = "Hawaii",
                Description = "Skinka & ananas",
                Price = 110m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 4,
                MenuCategoryId = 1,
                Name = "Capricciosa",
                Description = "Skinka & färska champinjoner",
                Price = 110m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 5,
                MenuCategoryId = 1,
                Name = "Bussola",
                Description = "Skinka & räkor",
                Price = 110m,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 6,
                MenuCategoryId = 1,
                Name = "Calzone",
                Description = "Inbakad. Skinka",
                Price = 110m,
                SortOrder = 6,
                IsActive = true
            },
            new MenuItem
            {
                Id = 7,
                MenuCategoryId = 1,
                Name = "Florida",
                Description = "Skinka, ananas, banan & curry",
                Price = 120m,
                SortOrder = 7,
                IsActive = true
            },
            new MenuItem
            {
                Id = 8,
                MenuCategoryId = 1,
                Name = "Bella",
                Description = "Skinka, räkor & färska champinjoner",
                Price = 120m,
                SortOrder = 8,
                IsActive = true
            },
            new MenuItem
            {
                Id = 9,
                MenuCategoryId = 1,
                Name = "Quattro Stagioni",
                Description = "Skinka, räkor, musslor, oliver, färska champinjoner & kronärtskocka",
                Price = 125m,
                SortOrder = 9,
                IsActive = true
            },
            new MenuItem
            {
                Id = 10,
                MenuCategoryId = 1,
                Name = "Calzone Special",
                Description = "Inbakad. Skinka, räkor & färska champinjoner",
                Price = 120m,
                SortOrder = 10,
                IsActive = true
            },
            new MenuItem
            {
                Id = 11,
                MenuCategoryId = 1,
                Name = "Dubbel Calzone",
                Description = "Dubbel deg. Skinka, räkor & färska champinjoner",
                Price = 130m,
                SortOrder = 11,
                IsActive = true
            },
            new MenuItem
            {
                Id = 12,
                MenuCategoryId = 2,
                Name = "Opera",
                Description = "Skinka & tonfisk",
                Price = 110m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 13,
                MenuCategoryId = 2,
                Name = "Al Tonno",
                Description = "Tonfisk & lök",
                Price = 110m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 14,
                MenuCategoryId = 2,
                Name = "Tredag",
                Description = "Räkor, musslor & tonfisk",
                Price = 120m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 15,
                MenuCategoryId = 2,
                Name = "Sjölejon & Iggon Special",
                Description = "Crème fraiche, mozzarella, rödlök, kräftstjärtar & räkor",
                Price = 150m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 16,
                MenuCategoryId = 2,
                Name = "Havets Läckerheter",
                Description = "Scampi, räkor, kräftstjärtar & ruccola",
                Price = 160m,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 17,
                MenuCategoryId = 2,
                Name = "Vegetariska",
                Description = "Champinjoner, lök, tomat, ananas, feferoni, oliver, paprika & kronärtskocka",
                Price = 130m,
                SortOrder = 6,
                IsActive = true
            },
            new MenuItem
            {
                Id = 18,
                MenuCategoryId = 2,
                Name = "Mozzarella",
                Description = "Mozzarellaost, champinjoner, tomat & ruccolasallad",
                Price = 120m,
                SortOrder = 7,
                IsActive = true
            },
            new MenuItem
            {
                Id = 19,
                MenuCategoryId = 3,
                Name = "Orientale",
                Description = "Köttfärs & lök",
                Price = 110m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 20,
                MenuCategoryId = 3,
                Name = "Mafioso",
                Description = "Köttfärs, ägg & tabasco",
                Price = 110m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 21,
                MenuCategoryId = 3,
                Name = "Bari",
                Description = "Köttfärs, champinjoner & salladsost (feta)",
                Price = 120m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 22,
                MenuCategoryId = 3,
                Name = "Orientale Special",
                Description = "Köttfärs, tomat, paprika & lök",
                Price = 120m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 23,
                MenuCategoryId = 4,
                Name = "Disco",
                Description = "Skinka, räkor & köttfärs",
                Price = 125m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 24,
                MenuCategoryId = 4,
                Name = "Campagnola",
                Description = "Salami, lök & oliver",
                Price = 110m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 25,
                MenuCategoryId = 4,
                Name = "Toscana",
                Description = "Salami, bacon, lök & ägg",
                Price = 120m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 26,
                MenuCategoryId = 4,
                Name = "Verona",
                Description = "Bacon, vitlök, paprika & lök",
                Price = 120m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 27,
                MenuCategoryId = 4,
                Name = "Al Capone",
                Description = "Skinka & salami",
                Price = 110m,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 28,
                MenuCategoryId = 4,
                Name = "Björn Special",
                Description = "Skinka, pepperonikorv, gorgonzola & tabasco",
                Price = 120m,
                SortOrder = 6,
                IsActive = true
            },
            new MenuItem
            {
                Id = 29,
                MenuCategoryId = 5,
                Name = "Grekisk Pizza",
                Description = "Marinerad oxfilé, lök, färska champinjoner, färska tomater, salladsost (feta), oliver, feferoni & tzatziki",
                Price = 130m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 30,
                MenuCategoryId = 5,
                Name = "Trödje Special",
                Description = "Marinerad oxfilé, lök, färsk paprika, färska tomater, färsk persilja & bearnaisesås",
                Price = 130m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 31,
                MenuCategoryId = 5,
                Name = "Hilleviks Special",
                Description = "Marinerad oxfilé, lök, färsk paprika, champinjoner, färska tomater & bearnaisesås",
                Price = 130m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 32,
                MenuCategoryId = 5,
                Name = "Husets Special",
                Description = "Marinerad fläskfilé, skinka, färska champinjoner & bearnaisesås",
                Price = 130m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 33,
                MenuCategoryId = 5,
                Name = "Kockens Special",
                Description = "Marinerad fläskfilé, jalapeño, vitlök, färska champinjoner, färska tomater & bearnaisesås",
                Price = 130m,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 34,
                MenuCategoryId = 5,
                Name = "Oscar",
                Description = "Marinerad fläskfilé, färsk paprika, färska champinjoner & bearnaisesås",
                Price = 130m,
                SortOrder = 6,
                IsActive = true
            },
            new MenuItem
            {
                Id = 35,
                MenuCategoryId = 5,
                Name = "Texas",
                Description = "Marinerad fläskfilé, skinka, räkor, jalapeño, tomat & bearnaisesås",
                Price = 130m,
                SortOrder = 7,
                IsActive = true
            },
            new MenuItem
            {
                Id = 36,
                MenuCategoryId = 5,
                Name = "Björke Special",
                Description = "Oxfilé, sparris, räkor, färska tomater & bearnaisesås",
                Price = 130m,
                SortOrder = 8,
                IsActive = true
            },
            new MenuItem
            {
                Id = 37,
                MenuCategoryId = 5,
                Name = "Vulkan Pizza",
                Description = "Fläskfilé, salami, köttfärs, räkor, pommes, färska champinjoner, skinka, kebabkött & valfri sås",
                Price = 179m,
                SortOrder = 9,
                IsActive = true
            },
            new MenuItem
            {
                Id = 38,
                MenuCategoryId = 5,
                Name = "Esköns Special",
                Description = "Fläskfilé, paprika, lök, tomat & bearnaisesås",
                Price = 130m,
                SortOrder = 10,
                IsActive = true
            },
            new MenuItem
            {
                Id = 39,
                MenuCategoryId = 6,
                Name = "Gorgonzola",
                Description = "Oxfilé, lök & gorgonzola",
                Price = 125m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 40,
                MenuCategoryId = 6,
                Name = "Ceasar",
                Description = "Skinka, lök & gorgonzola",
                Price = 120m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 41,
                MenuCategoryId = 7,
                Name = "Azteka",
                Description = "Skinka, jalapeño, tacokryddmix, tacosås & vitlökssås",
                Price = 120m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 42,
                MenuCategoryId = 7,
                Name = "Mexikana",
                Description = "Mexikansk köttfärs, lök, vitlök, jalapeño & tacokryddmix",
                Price = 120m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 43,
                MenuCategoryId = 7,
                Name = "Acapulco",
                Description = "Marinerad oxfilé, lök, vitlök, jalapeño, färska champinjoner & tacokryddmix",
                Price = 125m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 44,
                MenuCategoryId = 8,
                Name = "Indiana",
                Description = "Kyckling, ananas, banan & curry",
                Price = 125m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 45,
                MenuCategoryId = 8,
                Name = "Kycklingpizza",
                Description = "Kyckling, jordnötter, banan & curry",
                Price = 125m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 46,
                MenuCategoryId = 8,
                Name = "Hamrånge Special",
                Description = "Kyckling, paprika, lök & currysås",
                Price = 125m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 47,
                MenuCategoryId = 9,
                Name = "Kebab Special",
                Description = "Kebabkött, isbergssallad, rödlök, färska tomater, gurka & feferoni",
                Price = 140m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 48,
                MenuCategoryId = 9,
                Name = "Vikingbåt",
                Description = "Halvinbakad. Kebabkött, lök, färska tomater, färsk paprika & bearnaisesås",
                Price = 130m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 49,
                MenuCategoryId = 9,
                Name = "Kebabpizza",
                Description = "Kebabkött, lök, feferoni & färska tomater",
                Price = 130m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 50,
                MenuCategoryId = 10,
                Name = "Kebabtallrik",
                Description = "Pommes eller ris, isbergssallad, tomat, gurka & feferoni",
                Price = null,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 51,
                MenuCategoryId = 10,
                Name = "Kebabrulle",
                Description = "Färskbakat bröd, isbergssallad, rödlök, tomat, gurka & feferoni",
                Price = null,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 52,
                MenuCategoryId = 10,
                Name = "Kebabskrovmål",
                Description = null,
                Price = null,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 53,
                MenuCategoryId = 10,
                Name = "Kebab med bröd",
                Description = "Färskbakat bröd, isbergssallad, rödlök, tomat, gurka & feferoni",
                Price = null,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 54,
                MenuCategoryId = 11,
                Name = "Oxfilé",
                Description = "Med bearnaisesås",
                Price = null,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 55,
                MenuCategoryId = 11,
                Name = "Fläskfilé",
                Description = "Med bearnaisesås",
                Price = null,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 56,
                MenuCategoryId = 11,
                Name = "Filé Black & White",
                Description = "Med rödvinssås & bearnaisesås",
                Price = null,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 57,
                MenuCategoryId = 11,
                Name = "Filé Oscar",
                Description = "Fläskfilé, sparris, räkor & bearnaisesås",
                Price = null,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 58,
                MenuCategoryId = 11,
                Name = "Plankstek",
                Description = "Med rödvinssås & bearnaisesås",
                Price = null,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 59,
                MenuCategoryId = 11,
                Name = "Husets Kycklingfilé",
                Description = "Med bearnaisesås",
                Price = null,
                SortOrder = 6,
                IsActive = true
            },
            new MenuItem
            {
                Id = 60,
                MenuCategoryId = 11,
                Name = "Kycklingspett",
                Description = "Med tzatziki & tomatsås",
                Price = null,
                SortOrder = 7,
                IsActive = true
            },
            new MenuItem
            {
                Id = 61,
                MenuCategoryId = 11,
                Name = "Schnitzel",
                Description = "Med bearnaisesås & persiljesmör",
                Price = null,
                SortOrder = 8,
                IsActive = true
            },
            new MenuItem
            {
                Id = 62,
                MenuCategoryId = 11,
                Name = "Lövbit",
                Description = "Med bearnaisesås & persiljesmör",
                Price = null,
                SortOrder = 9,
                IsActive = true
            },
            new MenuItem
            {
                Id = 63,
                MenuCategoryId = 11,
                Name = "Fläskspett",
                Description = "Med tomatsås & tzatziki",
                Price = null,
                SortOrder = 10,
                IsActive = true
            },
            new MenuItem
            {
                Id = 64,
                MenuCategoryId = 12,
                Name = "Big Star",
                Description = "90 g hamburgare med bröd",
                Price = 89m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 65,
                MenuCategoryId = 12,
                Name = "Big Meal",
                Description = "90 g hamburgare med bröd, pommes & dricka 33 cl",
                Price = 119m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 66,
                MenuCategoryId = 12,
                Name = "Superstar",
                Description = "150 g hamburgare med bröd",
                Price = 99m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 67,
                MenuCategoryId = 12,
                Name = "Super Meal",
                Description = "150 g hamburgare med bröd, pommes & dricka 33 cl",
                Price = 129m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 68,
                MenuCategoryId = 12,
                Name = "Chicky Bits Meal",
                Description = "Chicky bits, pommes, grönsaker, currydressing & dricka 33 cl",
                Price = 120m,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 69,
                MenuCategoryId = 13,
                Name = "Rödspätta",
                Description = "Med remouladsås & kokt potatis",
                Price = 129m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 70,
                MenuCategoryId = 14,
                Name = "Ox-/Fläskfilé Pasta",
                Description = "Ox-/fläskfilé, champinjoner, tomatsås & gräddsås",
                Price = 129m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 71,
                MenuCategoryId = 14,
                Name = "Kyckling Pasta",
                Description = "Kycklingfilé, paprika, lök & currysås",
                Price = 129m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 72,
                MenuCategoryId = 14,
                Name = "Vegetarisk Pasta",
                Description = "Stekta grönsaker & tomatgräddsås",
                Price = 129m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 73,
                MenuCategoryId = 14,
                Name = "Pasta Carbonara",
                Description = "Bacon, lök, äggula & gräddsås",
                Price = 129m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 74,
                MenuCategoryId = 14,
                Name = "Pasta Bolognese",
                Description = "Köttfärssås",
                Price = 119m,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 75,
                MenuCategoryId = 15,
                Name = "Avocadosallad",
                Description = "Avocado, räkor, kaviar & citron",
                Price = 120m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 76,
                MenuCategoryId = 15,
                Name = "Ost & Skinksallad",
                Description = "Ost, skinka & ägg",
                Price = 120m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 77,
                MenuCategoryId = 15,
                Name = "Räksallad",
                Description = "Räkor, ägg, dill & citron",
                Price = 120m,
                SortOrder = 3,
                IsActive = true
            },
            new MenuItem
            {
                Id = 78,
                MenuCategoryId = 15,
                Name = "Tonfisksallad",
                Description = "Tonfisk, rödlök, ägg & citron",
                Price = 120m,
                SortOrder = 4,
                IsActive = true
            },
            new MenuItem
            {
                Id = 79,
                MenuCategoryId = 15,
                Name = "Kycklingsallad",
                Description = "Kryddad salladskycklingfilé & ananas",
                Price = 120m,
                SortOrder = 5,
                IsActive = true
            },
            new MenuItem
            {
                Id = 80,
                MenuCategoryId = 15,
                Name = "Grekisk Sallad",
                Description = "Grekisk fårost, salladsost, oliver, feferoni, rödlök, paprika, persilja & citron",
                Price = 120m,
                SortOrder = 6,
                IsActive = true
            },
            new MenuItem
            {
                Id = 81,
                MenuCategoryId = 15,
                Name = "Blandsallad",
                Description = "Skinka, räkor, ost, tonfisk & ägg",
                Price = 120m,
                SortOrder = 7,
                IsActive = true
            },
            new MenuItem
            {
                Id = 82,
                MenuCategoryId = 15,
                Name = "Västkustsallad",
                Description = "Räkor, tonfisk, musslor, ägg, dill & citron",
                Price = 120m,
                SortOrder = 8,
                IsActive = true
            },
            new MenuItem
            {
                Id = 83,
                MenuCategoryId = 15,
                Name = "Kebabsallad",
                Description = "Kebabkött, rödlök, feferoni, persilja & citron",
                Price = 120m,
                SortOrder = 9,
                IsActive = true
            },
            new MenuItem
            {
                Id = 84,
                MenuCategoryId = 16,
                Name = "Barnbox",
                Description = "45 g hamburgare med bröd & dricka 33 cl",
                Price = 89m,
                SortOrder = 1,
                IsActive = true
            },
            new MenuItem
            {
                Id = 85,
                MenuCategoryId = 16,
                Name = "Chicky Bits Meal",
                Description = "Chicky bits, pommes & dricka 33 cl",
                Price = 89m,
                SortOrder = 2,
                IsActive = true
            },
            new MenuItem
            {
                Id = 86,
                MenuCategoryId = 16,
                Name = "Pannkaka",
                Description = "Med sylt & grädde, dricka 33 cl",
                Price = 89m,
                SortOrder = 3,
                IsActive = true
            }
        );
    }

    private static void SeedVariants(ModelBuilder modelBuilder)
    {
        var variants = new List<MenuItemVariant>
        {
            // Kebab / kyckling / falafel
            new() { Id = 1, MenuItemId = 50, Name = "Kebab", Price = 120m, SortOrder = 1, IsActive = true },
            new() { Id = 2, MenuItemId = 50, Name = "Kyckling", Price = 125m, SortOrder = 2, IsActive = true },
            new() { Id = 3, MenuItemId = 50, Name = "Falafel", Price = 110m, SortOrder = 3, IsActive = true },

            new() { Id = 4, MenuItemId = 51, Name = "Kebab", Price = 130m, SortOrder = 1, IsActive = true },
            new() { Id = 5, MenuItemId = 51, Name = "Kyckling", Price = 135m, SortOrder = 2, IsActive = true },
            new() { Id = 6, MenuItemId = 51, Name = "Falafel", Price = 120m, SortOrder = 3, IsActive = true },

            new() { Id = 7, MenuItemId = 52, Name = "Kebab", Price = 120m, SortOrder = 1, IsActive = true },
            new() { Id = 8, MenuItemId = 52, Name = "Kyckling", Price = 125m, SortOrder = 2, IsActive = true },
            new() { Id = 9, MenuItemId = 52, Name = "Falafel", Price = 120m, SortOrder = 3, IsActive = true },

            new() { Id = 10, MenuItemId = 53, Name = "Kebab", Price = 110m, SortOrder = 1, IsActive = true },
            new() { Id = 11, MenuItemId = 53, Name = "Kyckling", Price = 115m, SortOrder = 2, IsActive = true },
            new() { Id = 12, MenuItemId = 53, Name = "Falafel", Price = 100m, SortOrder = 3, IsActive = true }
        };

        // Kötträtter: välj kokt potatis, klyftpotatis, pommes eller ris.
        var meatPrices = new Dictionary<int, decimal>
        {
            [54] = 229m,
            [55] = 199m,
            [56] = 229m,
            [57] = 229m,
            [58] = 249m,
            [59] = 139m,
            [60] = 179m,
            [61] = 129m,
            [62] = 129m,
            [63] = 209m
        };

        var sides = new[]
        {
            "Kokt potatis",
            "Klyftpotatis",
            "Pommes",
            "Ris"
        };

        var variantId = 13;

        foreach (var pair in meatPrices.OrderBy(x => x.Key))
        {
            for (var i = 0; i < sides.Length; i++)
            {
                variants.Add(new MenuItemVariant
                {
                    Id = variantId++,
                    MenuItemId = pair.Key,
                    Name = sides[i],
                    Price = pair.Value,
                    SortOrder = i + 1,
                    IsActive = true
                });
            }
        }

        modelBuilder.Entity<MenuItemVariant>().HasData(variants);
    }

    private static void SeedPizzaExtras(ModelBuilder modelBuilder)
    {
        var extras = new List<MenuItemExtra>();
        var extraId = 1;

        // Menyn anger att alla pizzor kan få dessa tillval.
        for (var menuItemId = 1; menuItemId <= 49; menuItemId++)
        {
            extras.Add(new MenuItemExtra
            {
                Id = extraId++,
                MenuItemId = menuItemId,
                Name = "Kebab",
                PriceChange = 25m,
                SortOrder = 1,
                IsActive = true
            });

            extras.Add(new MenuItemExtra
            {
                Id = extraId++,
                MenuItemId = menuItemId,
                Name = "Barnstorlek",
                PriceChange = -10m,
                SortOrder = 2,
                IsActive = true
            });

            extras.Add(new MenuItemExtra
            {
                Id = extraId++,
                MenuItemId = menuItemId,
                Name = "Glutenfri",
                PriceChange = 35m,
                SortOrder = 3,
                IsActive = true
            });

            extras.Add(new MenuItemExtra
            {
                Id = extraId++,
                MenuItemId = menuItemId,
                Name = "Extra pålägg",
                PriceChange = 15m,
                SortOrder = 4,
                IsActive = true
            });

            extras.Add(new MenuItemExtra
            {
                Id = extraId++,
                MenuItemId = menuItemId,
                Name = "Pizzasallad",
                PriceChange = 15m,
                SortOrder = 5,
                IsActive = true
            });

            extras.Add(new MenuItemExtra
            {
                Id = extraId++,
                MenuItemId = menuItemId,
                Name = "Dressing",
                PriceChange = 15m,
                SortOrder = 6,
                IsActive = true
            });
        }

        modelBuilder.Entity<MenuItemExtra>().HasData(extras);
    }
}