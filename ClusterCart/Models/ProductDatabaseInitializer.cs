using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ClusterCart.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> { 
                new Category 
                { 
                    CategoryID = 1, 
                    CategoryName = "Appliances" 
                }, 
                new Category 
                { 
                    CategoryID = 2, 
                    CategoryName = "Bags" 
                }, 
                new Category 
                { 
                    CategoryID = 3, 
                    CategoryName = "Cameras" 
                }, 

                new Category 
                { 
                    CategoryID = 4, 
                    CategoryName = "Clothing" 
                }, 

                new Category 
                { 
                    CategoryID = 5, 
                    CategoryName = "EyeWear" 
                }, 

                new Category 
                { 
                    CategoryID = 6, 
                    CategoryName = "HomeAndLiving" 
                }, 

                        new Category 
                { 
                    CategoryID = 7, 
                    CategoryName = "Jewellery" 
                }, 

                new Category 
                { 
                    CategoryID = 8, 
                    CategoryName = "Perfumes" 
                }, 

                new Category 
                { 
                    CategoryID = 9, 
                    CategoryName = "Phones" 
                }, 

                new Category 
                { 
                    CategoryID = 10, 
                    CategoryName = "TabletsAndAccessories" 
                }, 

                new Category 
                { 
                    CategoryID = 11, 
                    CategoryName = "Wallets&CardHolders" 
                }, 

                new Category 
                { 
                    CategoryID = 12, 
                    CategoryName = "Watches" 
                },
            };
            return categories;
        }
            public static List<Product> GetProducts() 
            {
                var products = new List<Product> { 
                new Product 
                { 
                ProductID = 1, 
                ProductName="Chopper",
                Brand="Anex",
                Description = "Anex Big Chopper With Vegetable Cutter AG-3048 - White", 
                ImagePath="anex-4513-4272753-1-zoom.jpg", 
                UnitPrice = 4389, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 2, 
                ProductName="Slice Toaster",
                Brand="Anex",
                Description = " Anex 2 Slice Toaster AG-3019 - White (Brand Warranty)", 
                ImagePath="anex-4606-8572753-1-zoom.jpg", 
                UnitPrice = 1964, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 3, 
                ProductName="Microwave Oven",
                Brand="Anex",
                Description = "Anex Oven Toaster AG-3066TT - Black (Brand Warranty)", 
                ImagePath="anex-4593-2572753-1-zoom.jpg", 
                UnitPrice = 5135, 
                CategoryID = 1 
                },


                new Product 
                { 
                ProductID = 4, 
                ProductName="Water Dispenser",
                Brand="Homage",
                Description = "HOMAGE Water Dispenser, (Without Ref. Cabnet) HWD-22 ", 
                ImagePath="homage-0817-9093753-1-zoom.jpg", 
                UnitPrice = 12800, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 5, 
                ProductName="Blender",
                Brand="Kenwood",
                Description = " Kenwood Blender BL-378 (Brand Warranty)", 
                ImagePath="kenwood-6515-1193753-1-zoom.jpg", 
                UnitPrice = 4358, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 6, 
                ProductName="Citrus Juicer",
                Brand="Kenwood",
                Description = "Kenwood Citrus Juicer JE-290 - White (Brand Warranty)", 
                ImagePath="kenwood-6527-3393753-1-zoom.jpg", 
                UnitPrice = 2510, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 7, 
                ProductName="Air Conditioner",
                Brand="Orient",
                Description = "Orient Split Air Conditioner - 1.5 Ton - OS-19 MD14M IN-HC", 
                ImagePath="orient-2849-912451-1-zoom.jpg", 
                UnitPrice = 93800, 
                CategoryID = 1 
                },


                new Product 
                { 
                ProductID = 8, 
                ProductName="Bread Maker",
                Brand="Sinbo",
                Description = "Sinbo Bread Maker Sbm-4713 (Brand Warranty)", 
                ImagePath="sinbo-8766-8534563-1-zoom.jpg", 
                UnitPrice = 14918, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 9, 
                ProductName="Vaccuum Cleaner",
                Brand="Sinbo",
                Description = "Sinbo Vacuum Cleaner Svc-3467", 
                ImagePath="sinbo-8650-3234563-1-zoom.jpg", 
                UnitPrice = 11349, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 10, 
                ProductName="Food Processor",
                Brand="WestPoint",
                Description = " Westpoint Food Processor WF-1851 (Brand Warranty)", 
                ImagePath="westpoint-5825-3402073-1-zoom.jpg", 
                UnitPrice = 6237, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 11, 
                ProductName="Sandwich Maker",
                Brand="WestPoint",
                Description = "Westpoint WF-671 - 2 Slice Sandwich Maker - White", 
                ImagePath="westpoint-0446-9491073-1-zoom.jpg", 
                UnitPrice = 1707, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 12, 
                ProductName="Iron",
                Brand="WestPoint",
                Description = "Westpoint Steam Iron WF-2019 (Brand Warranty)", 
                ImagePath="westpoint-5726-2202073-1-zoom.jpg", 
                UnitPrice = 1985, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 13, 
                ProductName="Food Factory",
                Brand=" Westpoint",
                Description = "Westpoint Jumbo Food Factory with Extra Grinder (9 in 1)", 
                ImagePath="westpoint-5818-1402073-1-zoom.jpg", 
                UnitPrice = 5250, 
                CategoryID = 1 
                },

                new Product 
                { 
                ProductID = 1, 
                ProductName="Bag",
                Brand=" Annabelle's",
                Description = "Annabelle's Multicolored Metal Formal Stone Clutch - Abss-05", 
                ImagePath="annabelles-3744-399041-1-zoom.jpg", 
                UnitPrice = 2550, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 2, 
                ProductName="Bag",
                Brand=" Bear Necessities",
                Description = " Bear Necessities Black Leather Tote Women's Hand Bag - Bnb06", 
                ImagePath="bear-necessities-1463-337281-1-zoom.jpg", 
                UnitPrice = 4990, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 3, 
                ProductName="Bag",
                Brand=" Claire's",
                Description = "Claire's Brown Leather Handbag – 004192 ", 
                ImagePath="claire-s-1472-0182791-1-zoom.jpg", 
                UnitPrice = 4350, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 4, 
                ProductName="Bag",
                Brand=" Claire's",
                Description = " Claire's Brown Leather Handbag – 026104 ", 
                ImagePath="claire-s-1538-1192791-1-zoom.jpg", 
                UnitPrice = 3350, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 5, 
                ProductName="Bag",
                Brand=" Ego",
                Description = " Ego Beige Leatherite Chevrons Wrap Bag",
                ImagePath="ego-5216-1679653-1-zoom.jpg", 
                UnitPrice = 4650, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 6, 
                ProductName="Bag",
                Brand=" Ego",
                Description = " Ego Brown Leatherite Chevrons Wrap Bag",
                ImagePath="ego-5203-0679653-1-zoom.jpg", 
                UnitPrice = 4650, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 7, 
                ProductName="Bag",
                Brand=" Ego",
                Description = " Ego Chocolate Brown Leatherite Donna Bag ", 
                ImagePath="ego-5186-8758123-1-zoom jpg", 
                UnitPrice = 3450, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 8, 
                ProductName="Bag",
                Brand=" Ego",
                Description = " Ego Tan Leatherite Donna Bag ", 
                ImagePath="ego-5197-0858123-1-zoom.jpg", 
                UnitPrice = 3450, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 9, 
                ProductName="Bag",
                Brand=" Head",
                Description = "Head Maria Sharapova Racquet Tennis Bag Combi ", 
                ImagePath="head-8573-88306-1-zoom.jpg", 
                UnitPrice = 5750, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 10, 
                ProductName="Bag",
                Brand=" Jump",
                Description = " Jump Black Jump Nice Shoulder Bag (6523)",
                ImagePath="jump-4522-52745-1-zoom.jpg", 
                UnitPrice = 4360, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 11, 
                ProductName="Bag",
                Brand="Jump",
                Description = " Jump Brown Jump Nice Shoulder Bag (6523) ", 
                ImagePath="jump-4515-72745-1-zoom.jpg", 
                UnitPrice = 4360, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 12, 
                ProductName="Bag",
                Brand=" Jump",
                Description = " Jump Brown Jump Upsalla 2 Doctor Bag  ", 
                ImagePath="jump-8055-97645-1-zoom.jpg", 
                UnitPrice = 7680, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 13, 
                ProductName="Bag",
                Brand=" Jump",
                Description = " Jump Dark Orange Jump Upsalla 2 Duffle Bag (4461A)",
                ImagePath="jump-4691-58645-1-zoom.jpg", 
                UnitPrice = 6690, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 14, 
                ProductName="Bag",
                Brand=" Nimra.K",
                Description = "Nimra.K Baby Pink And Grey Studded Envelope Clutch",
                ImagePath="nimra-k-5382-2151541-1-zoom.jpg", 
                UnitPrice = 2000, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 15, 
                ProductName="Bag",
                Brand=" Nimra.K",
                Description = " Nimra.K Copper & Gold Studded Patchwork Envelope Clutch",
                ImagePath="nimra-k-5498-1251541-1-zoom.jpg", 
                UnitPrice = 2000, 
                CategoryID = 2 
                },

                new Product 
                { 
                ProductID = 1, 
                ProductName="Camera",
                Brand="Cannon",
                Description = "CANON EOS 5D Mark III - 22.3 MP - 4.4x - DSLR Camera - Black + 24-105mm Lens",
                ImagePath="canon-3640-146851-1-zoom.jpg", 
                UnitPrice = 316000, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 2, 
                ProductName="Camera",
                Brand="Cannon",
                Description = "CANON EOS 1200D - 18MP - 1.5x - 10x - DSLR Camera - Black + 18-55mm lens + 16GB Card + Bag + Tripod",
                ImagePath="canon-4293-886851-1-zoom.jpg", 
                UnitPrice = 40000, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 3, 
                ProductName="Camera",
                Brand="Cannon",
                Description = " CANON IXUS 160 - 20MP - 8x Optical Zoom - Digital Camera",
                ImagePath="canon-4105-066851-1-zoom.jpg", 
                UnitPrice = 9000, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 4, 
                ProductName="Camera",
                Brand="Cannon",
                Description = " CANON Powershot SX400 IS - 16 MP - 30x optical zoom - Black",
                ImagePath="canon-6161-946851-1-zoom.jpg", 
                UnitPrice = 15800, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 5, 
                ProductName="Camera",
                Brand="Cannon",
                Description = " CANON PowerShot SX520 HS - 16 MP - 42x - Digital Camera",
                ImagePath="canon-9562-416851-1-zoom.jpg", 
                UnitPrice = 23150, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 6, 
                ProductName="Camera",
                Brand="Fuji",
                Description = "Fuji Film Finepix S2980 - Digital Camera - 14MP - 18X Optical ",
                ImagePath="fuji-film-8507-427561-1-zoom.jpg", 
                UnitPrice = 9300, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 7, 
                ProductName="Camera",
                Brand="Nikon",
                Description = " Nikon COOLPIX L820 - 16.0 MP - 30x - Digital Camera - Black",
                ImagePath="nikon-4757-419161-1-zoom.jpg", 
                UnitPrice = 17900, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 8, 
                ProductName="Camera",
                Brand="Nikon",
                Description = " Nikon Coolpix S2900 - 20 MP - 5x Optical Zoom - Compact Digital ",
                ImagePath="nikon-0856-7413001-1-zoom.jpg", 
                UnitPrice = 6890, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 9, 
                ProductName="Camera",
                Brand="Nikon",
                Description = " Nikon Coolpix S5200 Digital Camera (Plum)",
                ImagePath="nikon-8645-069161-1-zoom.jpg", 
                UnitPrice = 8750, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 10, 
                ProductName="Camera",
                Brand="Promate",
                Description = " PROMATE HANDYPAK2-S - Camera bag - Black and Red",
                ImagePath="promate-0897-7041763-1-zoom.jpg", 
                UnitPrice = 1410, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 11, 
                ProductName="Camera",
                Brand="Promate",
                Description = " PROMATE Zap - Bluetooth Camera Controller - Black",
                ImagePath=" promate-7716-7231763-1-zoom.jpg", 
                UnitPrice = 1590, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 12, 
                ProductName="Camera",
                Brand="Sigma",
                Description = " SIGMA 18-300mm F3.5-6.3 DC Macro OS HSM ( C ) Lens for Canon EF Cameras - Black 1 Year Brand Warranty",
                ImagePath="sigma-4876-8945063-1-zoom.jpg", 
                UnitPrice = 69999, 
                CategoryID = 3 
                },

                new Product 
                { 
                ProductID = 1, 
                ProductName="Clothing-Men",
                Brand="Arj",
                Description = " Arj Dark Brown Cotton Embroidered Kurta K-31",
                ImagePath="arj-5693-0072281-1-zoom.jpg", 
                UnitPrice = 2150, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 2, 
                ProductName="Clothing-Men",
                Brand="Arj",
                Description = " Arj White & Grey Stripes Kurta Detailed With Contrast K-26",
                ImagePath="arj-9233-4962281-1-zoom.jpg", 
                UnitPrice = 2150, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 3, 
                ProductName="Clothing-Men",
                Brand=" Aybeez",
                Description = " Aybeez Black Lakira & Cotton Black Polo Stretchable T-Shirt ",
                ImagePath="aybeez-3200-276221-1-zoom.jpg", 
                UnitPrice = 1299, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 4, 
                ProductName="Clothing-Men",
                Brand="Aybeez",
                Description = " Aybeez Pack of 5 basic t-shirts high quality-ABZ-984",
                ImagePath="aybeez-7607-172801-1-zoom.jpg", 
                UnitPrice = 2150, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 5, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Coral Chiffon Fancy Embroidered",
                ImagePath="blossom-5316-334478-1-zoom.jpg", 
                UnitPrice = 3800, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 6, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Dark Green Chiffon Embroidered",
                ImagePath="blossom-5299-524478-1-zoom.jpg", 
                UnitPrice = 3600, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 7, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Green Chiffon Fancy Embroidered",
                ImagePath="blossom-5336-434478-1-zoom.jpg", 
                UnitPrice = 3800, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 8, 
                ProductName="Clothing-Women",
                Brand=" Blossom",
                Description = " Blossom Green Lawn Embroidered Unstitched Shirt Piece - 9B",
                ImagePath="blossom-8598-673041-1-zoom.jpg", 
                UnitPrice = 2400, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 9, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Maroon Lawn Embroidered Unstitched Shirt",
                ImagePath="blossom-6870-063041-1-zoom.jpg", 
                UnitPrice = 2400, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 10, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Pink Chiffon Fancy Embroidered",
                ImagePath="blossom-5369-534478-1-zoom.jpg", 
                UnitPrice = 3800, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 11, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Pink Embroidered Cotton Kurta With Buttons",
                ImagePath="blossom-8745-152901-1-zoom.jpg", 
                UnitPrice = 1650, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 12, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Pink Lawn Crushed Dupatta - Sa8-8",
                ImagePath="blossom-6755-373041-1-zoom.jpg", 
                UnitPrice = 2400, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 13, 
                ProductName="Clothing-Women",
                Brand="Blossom",
                Description = " Blossom Yellow And Pink Embroidered Unstitched Shirt ",
                ImagePath="arj-5693-0072281-1-zoom.jpg", 
                UnitPrice = 2150, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 14, 
                ProductName="Clothing-Men",
                Brand="Karachi WearHouse",
                Description =" Karachi Wearhouse Green Cotton Men's Kurta Ma-G",
                ImagePath="karachi-wearhouse-9877-719161-1-zoom.jpg", 
                UnitPrice = 1950, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 15, 
                ProductName="Clothing-Men",
                Brand="Karachi Wearhouse",
                Description = " Karachi Wearhouse Red Men Jersey Shirt With Pocket",
                ImagePath="karachi-wearhouse-5112-311221-1-zoom.jpg", 
                UnitPrice = 549, 
                CategoryID = 4 
                },

                new Product 
                { 
                ProductID = 16, 
                ProductName="Clothing-Men",
                Brand="Todd Davis",
                Description = " Todd Davis Bundle Of Men's Pique Polo Shirts With Tipping SI-50",
                ImagePath="todd-davis-1155-771541-1-zoom.jpg", 
                UnitPrice = 1299, 
                CategoryID = 4 
                },


                new Product 
                { 
                ProductID = 1, 
                ProductName="Eye Wear ",
                Brand=" Carrera",
                Description = " Carrera Sunglasses CR89S-GVB - Black",
                ImagePath="carrera-4097-00988-1-zoom.jpg", 
                UnitPrice = 14200, 
                CategoryID = 5 
                },

                new Product 
                { 
                ProductID = 2, 
                ProductName="Eye Wear ",
                Brand=" Ray-Ban",
                Description = " Ray-Ban Acetate Black Frame Glasses With Grey Lens - RB218",
                ImagePath="ray-ban-6125-710161-1-zoom.jpg", 
                UnitPrice = 15000, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 3, 
                ProductName="Eye Wear ",
                Brand=" Ray-Ban",
                Description = " Ray-Ban Arista Gold Flip-out Aviators with Pink Lens ",
                ImagePath=" ray-ban-9129-5389-1-zoom.jpg", 
                UnitPrice = 14400, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 4, 
                ProductName="Eye Wear ",
                Brand=" Ray-Ban",
                Description = " Ray-Ban Aviator Acetate Light ray Titanium Gunmetal,Tortoise Frame Glasses With Brown Gradient Lens - RB4211-894,13-56",
                ImagePath="ray-ban-6250-701161-1-zoom.jpg", 
                UnitPrice = 21500, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 5, 
                ProductName="Eye Wear ",
                Brand=" Ray-Ban",
                Description = " Ray-Ban Aviator Metal Golden Frame Glasses With Blue Flash ",
                ImagePath="ray-ban-6139-720161-1-zoom.jpg", 
                UnitPrice = 17000, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 6, 
                ProductName="Eye Wear ",
                Brand=" Ray-Ban",
                Description = " Ray-Ban Aviator Metal Golden Frame Glasses With Silver,Pink Mirror Lens - RB3025-001,3E-55",
                ImagePath="ray-ban-6129-020161-1-zoom.jpg", 
                UnitPrice = 15500, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 7, 
                ProductName="Eye Wear ",
                Brand=" Ray-Ban",
                Description = " Ray-Ban Black Original Wayfarer Classic Sunglasses",
                ImagePath="ray-ban-2792-42707-1-zoom.jpg", 
                UnitPrice = 13950, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 8, 
                ProductName="Eye Wear ",
                Brand=" Ray-Ban",
                Description = " Ray-Ban Wayfarer Metal Red Frame Glasses With Brown ",
                ImagePath="ray-ban-6190-360161-1-zoom.jpg", 
                UnitPrice = 18500, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 9, 
                ProductName="Eye Wear ",
                Brand=" Rob Hayes",
                Description = " Rob Hayes Black Round Glasses with Orange Beaded Styling",
                ImagePath="rob-hayes-0865-05783-1-zoom.jpg", 
                UnitPrice = 1290, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 10, 
                ProductName="Eye Wear ",
                Brand=" Rob Hayes",
                Description = " Rob Hayes Burgundy Frames with Chain Temples",
                ImagePath="rob-hayes-1520-17467-1-zoom.jpg", 
                UnitPrice = 1299, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 11, 
                ProductName="Eye Wear ",
                Brand=" Rob Hayes",
                Description = " Rob Hayes Purple Cateye Frames with Silver Detail",
                ImagePath="rob-hayes-1538-57467-1-zoom.jpg", 
                UnitPrice = 1299, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 12, 
                ProductName="Eye Wear ",
                Brand=" Vogue",
                Description = " Vogue Brown oval shaped shaped spectacles with light brown design and simple pearl design",
                ImagePath="vogue-2115-21991-1-zoom.jpg", 
                UnitPrice = 14500, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 13, 
                ProductName="Eye Wear ",
                Brand=" Vogue",
                Description = " Vogue Compact half rimmed silver spectacles with silver finishing",
                ImagePath="vogue-7010-59891-1-zoom.jpg", 
                UnitPrice = 5400, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 14, 
                ProductName="Eye Wear ",
                Brand=" Vogue",
                Description = " Vogue Compact rectangle shaped black spectacles",
                ImagePath="vogue-8522-88891-1-zoom.jpg", 
                UnitPrice = 9900, 
                CategoryID = 5 
                },


                new Product 
                { 
                ProductID = 15, 
                ProductName="Eye Wear ",
                Brand=" Vogue",
                Description = " Vogue Small brown rimmed spectacles with light brown",
                ImagePath="vogue-8087-89891-1-zoom.jpg", 
                UnitPrice = 10500, 
                CategoryID = 5 
                },

                new Product 
                { 
                ProductID = 1, 
                ProductName="Home & Living ",
                Brand=" Chairman",
                Description = " Chairman Wall Clock Round 12\" - White - CH-B-10",
                ImagePath="carrera-4097-00988-1-zoom.jpg", 
                UnitPrice = 299, 
                CategoryID = 6
                }
                };
                return products;
            }
    }
}