using ManagemenyShopify.WEB.Models;
using ShopifySharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManagemenyShopify.WEB.Models
{
    public class OrderTestModel
    {
        public Order OrderModel()
        {
            LineItem lineitem = new LineItem()
            {
                AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                FulfillableQuantity = 45454,
                FulfillmentLineItemId = 454545,
                FulfillmentService = "FulfillmentService_TEST",
                //FulfillmentStatus = "FulfillmentStatus_TEST",
                GiftCard = true,
                Grams = 565656,
                Id = 8787887,
                Name = "Name_TEST",
                Price = 565656,
                ProductExists = true,
                ProductId = 667677,
                Quantity = 6767,
                RequiresShipping = true,
                SKU = "SKU_TEST",
                Taxable = true,
                TipPaymentGateway = "TipPaymentGateway_TEST",
                TipPaymentGatewaySpecified = true,
                TipPaymentMethod = "TipPaymentMethod_TEST",
                Title = "Title_TEST",
                TotalDiscount = 676767,
                VariantId = 78787,
                VariantInventoryManagement = "VariantInventoryManagement_TEST",
                VariantTitle = "VariantTitle_TEST",
                Vendor = "Vendor_TEST",

                TaxLines = new List<TaxLine>() {
                        new TaxLine()
                        {
                            Price = 454545,
                            Rate = 545445,
                            Title = "Title_TEST",
                            PriceSet = new PriceSet(){
                                ShopMoney = new Price()
                                {
                                    Amount = 67677,
                                    CurrencyCode = "CurrencyCode_TEST"
                                },
                                PresentmentMoney = new Price()
                                {
                                    Amount = 67677,
                                    CurrencyCode = "CurrencyCode_TEST"
                                }
                            }
                        }
                    },

                OriginLocation = new LineItemOriginLocation()
                {
                    Address1 = "Address1_TEST",
                    Address2 = "Address2_TEST",
                    AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                    City = "City_TEST",
                    CountryCode = "CountryCode_TEST",
                    Name = "Name_TEST",
                    ProvinceCode = "ProvinceCode_TEST",
                    Zip = "Zip_TEST"
                },

                Properties = new List<LineItemProperty>()
                    {
                        new LineItemProperty(){
                            Name = "Name_TEST",
                            Value = "Value_TEST"
                        }
                    },


                PriceSet = new PriceSet()
                {
                    PresentmentMoney = new Price()
                    {
                        Amount = 67677,
                        CurrencyCode = "CurrencyCode_TEST"
                    },
                    ShopMoney = new Price()
                    {
                        Amount = 67677,
                        CurrencyCode = "CurrencyCode_TEST"
                    }
                },
                TotalDiscountSet = new PriceSet()
                {
                    PresentmentMoney = new Price()
                    {
                        Amount = 67677,
                        CurrencyCode = "CurrencyCode_TEST"
                    },
                    ShopMoney = new Price()
                    {
                        Amount = 67677,
                        CurrencyCode = "CurrencyCode_TEST"
                    }
                },
                DiscountAllocations = new List<DiscountAllocation>()
                    {
                        new DiscountAllocation()
                        {
                            Amount = "Amount_TEST",
                            DiscountApplicationIndex = 565656,
                            AmountSet = new PriceSet()
                            {
                                PresentmentMoney = new Price()
                                {
                                    Amount = 67677,
                                    CurrencyCode = "CurrencyCode_TEST"
                                },
                                ShopMoney = new Price()
                                {
                                    Amount = 67677,
                                    CurrencyCode = "CurrencyCode_TEST"
                                },
                            }
                        }
                    },
                Duties = new List<LineItemDuty>()
                    {
                        new LineItemDuty(){
                            AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                            CountryCodeOfOrigin = "CountryCodeOfOrigin_TEST",
                            HarmonizedSystemCode = "HarmonizedSystemCode_TEST",
                            PresentmentMoney = new Price()
                            {
                                Amount = 67677,
                                CurrencyCode = "CurrencyCode_TEST"
                            },
                            ShopMoney = new Price()
                            {
                                Amount = 67677,
                                CurrencyCode = "CurrencyCode_TEST"
                            },
                            TaxLines = new List<TaxLine>(){
                                new TaxLine(){
                                    Price = 5454545,
                                    Rate = 33434,
                                    Title = "Title_TEST",
                                    PriceSet = new PriceSet()
                                    {
                                        PresentmentMoney = new Price()
                                        {
                                            Amount = 67677,
                                            CurrencyCode = "CurrencyCode_TEST"
                                        },
                                        ShopMoney = new Price()
                                        {
                                            Amount = 67677,
                                            CurrencyCode = "CurrencyCode_TEST"
                                        },
                                    }
                                }
                            }
                        }
                    },

            };



            var Fulfillment1 = new Fulfillment()
            {
                AdminGraphQLAPIId = "Test",
                CreatedAt = DateTime.Now,
                Email = "test@test.ru",
                Id = 55656,
                Name = "Name_TEST",
                NotifyCustomer = true,
                OrderId = 56565655,
                Receipt = new object(),
                Service = "Service_TEST",
                LocationId = 787878,
                Status = "Status_TEST",
                TrackingCompany = "TrackingCompany_TEST",
                OriginAddress = new Address()
                {
                    Address1 = "Address1_TEST",
                    Address2 = "Address2_TEST",
                    AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                    City = "City_TEST",
                    Company = "Company_TEST",
                    Country = "Country_TEST",
                    CountryCode = "CountryCode_TEST",
                    CountryName = "CountryName_TEST",
                    Default = true,
                    FirstName = "FirstName_TEST",
                    Id = 4545454545,
                    LastName = "LastName_TEST",
                    Latitude = 56565656,
                    Longitude = 676767,
                    Name = "Name_TEST",
                    Phone = "Phone_TEST",
                    Province = "Province_TEST",
                    ProvinceCode = "ProvinceCode_TEST",
                    Zip = "Zip_TEST"
                },
                VariantInventoryManagement = "VariantInventoryManagement_TEST",
                UpdatedAt = DateTime.Now,
                TrackingUrls = new List<string>()
                    {
                        "TEST1",
                        "TEST2",
                        "TEST3"
                    },
                Destination = new Address()
                {
                    Address1 = "Address1_TEST",
                    Address2 = "Address2_TEST",
                    AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                    City = "City_TEST",
                    Company = "Company_TEST",
                    Country = "Country_TEST",
                    CountryCode = "CountryCode_TEST",
                    CountryName = "CountryName_TEST",
                    Default = true,
                    FirstName = "FirstName_TEST",
                    Id = 4545454545,
                    LastName = "LastName_TEST",
                    Latitude = 56565656,
                    Longitude = 676767,
                    Name = "Name_TEST",
                    Phone = "Phone_TEST",
                    Province = "Province_TEST",
                    ProvinceCode = "ProvinceCode_TEST",
                    Zip = "Zip_TEST"
                },
                ShipmentStatus = "ShipmentStatus_TEST",
                TrackingNumber = "TrackingNumber_TEST",
                TrackingNumbers = new List<string>(){
                        "TEST1",
                        "TEST2",
                        "TEST3",
                        "TEST4"
                    },
                TrackingUrl = "TEST",
                LineItems = new List<LineItem>()
                    {
                        lineitem
                    }
            };

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            var order = new Order()
            {
                AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                BuyerAcceptsMarketing = true,
                CancelledAt = DateTime.Now,
                ClosedAt = DateTime.Now,
                CurrentSubtotalPrice = 12121221,
                CreatedAt = DateTime.UtcNow,
                UserId = 1212122121212,
                AppId = 56565656,
                BrowserIp = "192.168.0.0",
                CartToken = "CartToken_TEST",
                CancelReason = "CancelReason_TEST",
                CheckoutId = 5656565656,
                CheckoutToken = "CheckoutToken_TEST",
                Confirmed = true,
                Currency = "USD",
                CurrentTotalDiscounts = 4545454545,
                CurrentTotalPrice = 456565666,
                CurrentTotalTax = 565656,
                CustomerLocale = "CustomerLocale_TEST",
                DeviceId = 767676767,
                EstimatedTaxes = true,
                BillingAddress = new ShopifyAddress()
                {
                    Address1 = "123 4th Street",
                    City = "Minneapolis",
                    Province = "Minnesota",
                    ProvinceCode = "MN",
                    Zip = "55401",
                    Phone = "555-555-5555",
                    FirstName = "John",
                    LastName = "Doe",
                    Company = "Tomorrow Corporation",
                    Country = "United States",
                    CountryCode = "US",
                    Default = true,
                },

                LineItems = new List<LineItem>()
                        {
                            new LineItem()
                            {
                                Name = "Test2 Line2 Item2",
                                Title = "Test2 Line2 Item2 Title2",
                                Price = 100,
                                AdminGraphQLAPIId = "",
                                FulfillableQuantity = 0,
                                Grams = 250,
                                ProductId = 4809489252600,
                                ProductExists = true,
                                Quantity = 1,
                                RequiresShipping = true,
                                Taxable = true,
                                SKU = "",
                                FulfillmentLineItemId = 3242342,
                                GiftCard = true,
                                TotalDiscount = 567567,
                                VariantId = 345345345435,
                                //FulfillmentService = "FulfillmentService_TEST",
                                FulfillmentStatus = "1",
                                TipPaymentGatewaySpecified = true,
                                Id = 3453444,
                                TipPaymentGateway = "TipPaymentGateway_TEST",
                                TipPaymentMethod = "TipPaymentMethod_TEST",
                                VariantInventoryManagement = "VariantInventoryManagement_TEST",
                                VariantTitle = "VariantTitle_TEST",
                                Vendor = "Vendor_TEST",
                                DiscountAllocations = new List<DiscountAllocation>()
                                {
                                    new DiscountAllocation()
                                    {
                                        Amount = "Amount_TEST",
                                        DiscountApplicationIndex = 345345345,
                                        AmountSet = new PriceSet()
                                        {
                                            PresentmentMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            },
                                            ShopMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            }
                                        }
                                    }
                                },
                                PriceSet = new PriceSet()
                                {
                                    PresentmentMoney = new Price(){
                                        Amount = 23232323,
                                        CurrencyCode = "CurrencyCode_TEST"
                                    },
                                    ShopMoney = new Price(){
                                        Amount = 23232323,
                                        CurrencyCode = "CurrencyCode_TEST"
                                    }
                                },
                                Properties = new List<LineItemProperty>()
                                {
                                    new LineItemProperty()
                                    {
                                        Name = "Name_TEST",
                                        Value = "Value_TEST",
                                    }
                                },
                                TaxLines = new List<TaxLine>()
                                {
                                    new TaxLine()
                                    {
                                        Price = 34534534,
                                        Rate = 56456,
                                        Title = "Title_TEST",
                                        PriceSet = new PriceSet()
                                        {
                                             PresentmentMoney = new Price()
                                             {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                             },
                                            ShopMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            }
                                        }
                                    }
                                },
                                OriginLocation = new LineItemOriginLocation()
                                {
                                    Address1 = "123 4th Street",
                                    City = "Minneapolis",
                                    ProvinceCode = "MN",
                                    Zip = "55401",
                                    CountryCode = "US",
                                    Address2 = "Address2_TEST",
                                    AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                                    Name = "Name_TEST"
                                },
                                TotalDiscountSet = new PriceSet()
                                {
                                    PresentmentMoney = new Price()
                                    {
                                        Amount = 6666666,
                                        CurrencyCode = "CurrencyCode_TEST"
                                    },
                                    ShopMoney = new Price()
                                    {
                                        Amount = 45454,
                                        CurrencyCode = "CurrencyCode_TEST"
                                    }
                                },
                                Duties = new List<LineItemDuty>()
                                {
                                    new LineItemDuty()
                                    {
                                        AdminGraphQLAPIId = "AdminGraphQLAPIId_TEST",
                                        CountryCodeOfOrigin = "CountryCodeOfOrigin_TEST",
                                        HarmonizedSystemCode = "HarmonizedSystemCode_TEST",
                                        PresentmentMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            },
                                        ShopMoney = new Price()
                                            {
                                                Amount = 23232323,
                                                CurrencyCode = "CurrencyCode_TEST"
                                            }
                                    }
                                }


                            }
                        },
                FinancialStatus = "paid",
                TotalPrice = 5,
                Email = Guid.NewGuid().ToString() + "@example.com",
                Note = "Test note about the customer.",
            };

            return order;
        }
    }
}
