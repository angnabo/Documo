using System;

namespace Documo.TestData
{
    public static class ReceiptTestData
    {
        public static object GetData()
        {
            return new
            {
                Account = new
                {
                    FullName = "Samantha Smith",
                },
                Address = new
                {
                    Address1 = "456 Flat",
                    Address2 = "123 Street",
                    Address3 = "Leeds",
                    Postcode = "LS1 2AB"
                },
                Logo = "https://www.imgur.com/5FckMAD.png",
                CreatedDate = new DateTime(2019, 08, 12).ToString("dd/MM/yyy"),
                DeliveryDate = new DateTime(2020, 05, 12).ToString("dd/MM/yyy"),
                InvoiceNumber = 56998735,
                Items = new[]
                {
                    new
                    {
                        Name = "Black Ceramic Vase",
                        Code = "00862426",
                        Price = 49.89m,
                        Count = 1,
                        Size = "L",
                        Image = "https://images.unsplash.com/photo-1529088065352-38829cd9968b?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80"
                    },
                    new
                    {
                        Name = "Vanilla Scented Candle",
                        Code = "00856241",
                        Price = 9.89m,
                        Count = 1,
                        Size = "N/A",
                        Image = "https://images.unsplash.com/photo-1572726729207-a78d6feb18d7?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80"
                    },
                    new
                    {
                        Name = "Wicker Basket",
                        Code = "00423586",
                        Price = 65.99m,
                        Count = 1,
                        Size = "M",
                        Image = "https://images.unsplash.com/photo-1578908922388-fe8709d835d2?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=634&q=80"
                    },
                },
                Charges = new[]
                {
                    new
                    {
                        Description = "Order",
                        Cost = new
                        {
                            Net = 103.76m,
                            Vat = 22.01m
                        }
                    },
                    new
                    {
                        Description = "Delivery",
                        Cost = new
                        {
                            Net = 5.99m,
                            Vat = 0m
                        }
                    }
                },
                TotalCharges = 131.76m,
                Payment = new
                {
                    FullName = "Samantha Smith",
                    CardLastDigits = "1234",
                    CardIssuer = "Mastercard"
                }
            };
        }
    }
}