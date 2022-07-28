using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;

namespace TicaretApp.Data.Concrete.EntityFramework.Contexts
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new TicaretAppContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Brands.Count() == 0)
                {
                    context.Brands.AddRange(Brands);
                    context.SaveChanges();
                }
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                    context.SaveChanges();
                }
                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);
                    context.SaveChanges();
                }
                if (context.Images.Count() == 0)
                {
                    context.Images.AddRange(Images);
                    context.SaveChanges();
                }
                if (context.ProductDetails.Count() == 0)
                {
                    context.ProductDetails.AddRange(ProductDetails);
                    context.SaveChanges();
                }
                if (context.Comments.Count() == 0)
                {
                    context.Comments.AddRange(Comments);
                }
                

                context.SaveChanges();
            }
        }
        

        private static Brand[] Brands =
         {
            new Brand(){Name = "Dell"},
            new Brand(){Name = "Toshiba"},
            new Brand(){Name = "Asult"},
            new Brand(){Name = "Apple"}
        };

        private static Category[] Categories = {
            new Category(){Name="Laptops",IsFeatured=true,ImageUrl="shop01.png"},
            new Category(){Name="SmartPhones"},
            new Category(){Name="Cameras",IsFeatured=true,ImageUrl="shop02.png"},
            new Category(){Name="Accessories",IsFeatured=true,ImageUrl="shop03.png"},
            new Category(){Name="HeadPhones"}
        };

        private static Product[] Products = {
            new Product(){Name="Dell 3542",OldPrice=6700,ImageUrl="product01.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=30, ViewCount=25,CommentCount=1,OrderCount=123123,CreatedDate=new DateTime(2020/01/01),ModifiedDate=new DateTime(2020/01/01),BrandId=1},
            new Product(){Name="Bass 4700",OldPrice=3400,ImageUrl="product02.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=300,CommentCount=12,OrderCount=412,CreatedDate=new DateTime(2010/01/01),ModifiedDate=new DateTime(2010/01/01),BrandId=1},
            new Product(){Name="Asult 4550",OldPrice=12799,ImageUrl="product03.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=250,CommentCount=33,OrderCount=2,CreatedDate=new DateTime(2012/01/01),ModifiedDate=new DateTime(2012/01/01),BrandId=2},
            new Product(){Name="Tab 5",OldPrice=5600,ImageUrl="product04.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=34444,CommentCount=124,OrderCount=3,CreatedDate=new DateTime(2013/01/01),ModifiedDate=new DateTime(2013/01/01),BrandId=3},
            new Product(){Name="Sony MDRXR-546",OldPrice=4500,ImageUrl="product05.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=10, ViewCount=3674,CommentCount=631,OrderCount=4,BrandId=1},
            new Product(){Name="Lenovo T50",OldPrice=8900,ImageUrl="product06.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=1234,CommentCount=4214,OrderCount=5612,BrandId=1},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=454213,CommentCount=42154,OrderCount=1235213,BrandId=2},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=123,CommentCount=24,OrderCount=532,BrandId=1},
            new Product(){Name="Toshiba B4",OldPrice=25600,ImageUrl="product08.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=32132,CommentCount=54,OrderCount=1234,BrandId=3},
            new Product(){Name="Nikone K340",OldPrice=4700,ImageUrl="product09.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=40, ViewCount=5124,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Dell 3542",OldPrice=6700,ImageUrl="product01.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=532123,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Bass 4700",OldPrice=3400,ImageUrl="product02.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=2135213,CommentCount=23,OrderCount=124,BrandId=1},
            new Product(){Name="Asult 4550",OldPrice=12799,ImageUrl="product03.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=1235,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Tab 5",OldPrice=5600,ImageUrl="product04.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=10, ViewCount=5215,CommentCount=54,OrderCount=368,BrandId=4},
            new Product(){Name="Sony MDRXR-546",OldPrice=4500,ImageUrl="product05.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=12,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Lenovo T50",OldPrice=8900,ImageUrl="product06.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=2,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=15, ViewCount=3674,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=0,CommentCount=54,OrderCount=368,BrandId=4},
            new Product(){Name="Toshiba B4",OldPrice=25600,ImageUrl="product08.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=123,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Nikone K340",OldPrice=4700,ImageUrl="product09.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=5, ViewCount=3674,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Dell 3542",OldPrice=6700,ImageUrl="product01.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=563423,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Bass 4700",OldPrice=3400,ImageUrl="product02.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=789,CommentCount=23,OrderCount=124,BrandId=4},
            new Product(){Name="Asult 4550",OldPrice=12799,ImageUrl="product03.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=956,CommentCount=412,OrderCount=368,BrandId=1},
            new Product(){Name="Tab 5",OldPrice=5600,ImageUrl="product04.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=8569658,CommentCount=1,OrderCount=368,BrandId=2},
            new Product(){Name="Sony MDRXR-546",OldPrice=4500,ImageUrl="product05.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=865856,CommentCount=2,OrderCount=368,BrandId=3},
            new Product(){Name="Lenovo T50",OldPrice=8900,ImageUrl="product06.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=8, ViewCount=58658,CommentCount=54,OrderCount=368,BrandId=4},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=5685,CommentCount=4,OrderCount=368,BrandId=1},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=856,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Toshiba B4",OldPrice=25600,ImageUrl="product08.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=15, ViewCount=86,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Nikone K340",OldPrice=4700,ImageUrl="product09.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=86,CommentCount=54,OrderCount=368,BrandId=4},
            new Product(){Name="Dell 3542",OldPrice=6700,ImageUrl="product01.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=865568,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Bass 4700",OldPrice=3400,ImageUrl="product02.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=35654421,CommentCount=23,OrderCount=124,BrandId=2},
            new Product(){Name="Asult 4550",OldPrice=12799,ImageUrl="product03.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=68,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Tab 5",OldPrice=5600,ImageUrl="product04.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=345,CommentCount=54,OrderCount=368,BrandId=4},
            new Product(){Name="Sony MDRXR-546",OldPrice=4500,ImageUrl="product05.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=25, ViewCount=3674,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Lenovo T50",OldPrice=8900,ImageUrl="product06.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=976,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=4562,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=6547,CommentCount=54,OrderCount=368,BrandId=4},
            new Product(){Name="Toshiba B4",OldPrice=25600,ImageUrl="product08.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=8654,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Nikone K340",OldPrice=4700,ImageUrl="product09.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=25, ViewCount=3674,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Dell 3542",OldPrice=6700,ImageUrl="product01.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.",ViewCount=4588,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Bass 4700",OldPrice=3400,ImageUrl="product02.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=9564,CommentCount=23,OrderCount=124,BrandId=4},
            new Product(){Name="Asult 4550",OldPrice=12799,ImageUrl="product03.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=45885,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Tab 5",OldPrice=5600,ImageUrl="product04.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=456547,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Sony MDRXR-546",OldPrice=4500,ImageUrl="product05.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=70, ViewCount=3674,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Lenovo T50",OldPrice=8900,ImageUrl="product06.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=68,CommentCount=54,OrderCount=368,BrandId=4},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=885,CommentCount=54,OrderCount=368,BrandId=1},
            new Product(){Name="Iphone 7s",OldPrice=13900,ImageUrl="product07.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=65,CommentCount=54,OrderCount=368,BrandId=2},
            new Product(){Name="Toshiba B4",OldPrice=25600,ImageUrl="product08.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", ViewCount=36,CommentCount=54,OrderCount=368,BrandId=3},
            new Product(){Name="Nikone K340",OldPrice=4700,ImageUrl="product09.png",Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Discount=80, ViewCount=3674,CommentCount=54,OrderCount=368,BrandId=4}

        };

        private static ProductCategory[] ProductCategories ={
            new ProductCategory(){Category=Categories[0],Product=Products[0]},
            new ProductCategory(){Category=Categories[1],Product=Products[1]},
            new ProductCategory(){Category=Categories[2],Product=Products[2]},
            new ProductCategory(){Category=Categories[3],Product=Products[3]},
            new ProductCategory(){Category=Categories[4],Product=Products[4]},
            new ProductCategory(){Category=Categories[0],Product=Products[5]},
            new ProductCategory(){Category=Categories[1],Product=Products[6]},
            new ProductCategory(){Category=Categories[2],Product=Products[7]},
            new ProductCategory(){Category=Categories[3],Product=Products[8]},
            new ProductCategory(){Category=Categories[4],Product=Products[9]},
            new ProductCategory(){Category=Categories[0],Product=Products[10]},
            new ProductCategory(){Category=Categories[1],Product=Products[11]},
            new ProductCategory(){Category=Categories[2],Product=Products[12]},
            new ProductCategory(){Category=Categories[3],Product=Products[13]},
            new ProductCategory(){Category=Categories[4],Product=Products[14]},
            new ProductCategory(){Category=Categories[0],Product=Products[15]},
            new ProductCategory(){Category=Categories[1],Product=Products[16]},
            new ProductCategory(){Category=Categories[2],Product=Products[17]},
            new ProductCategory(){Category=Categories[3],Product=Products[18]},
            new ProductCategory(){Category=Categories[4],Product=Products[19]},
            new ProductCategory(){Category=Categories[0],Product=Products[20]},
            new ProductCategory(){Category=Categories[1],Product=Products[21]},
            new ProductCategory(){Category=Categories[2],Product=Products[22]},
            new ProductCategory(){Category=Categories[3],Product=Products[23]},
            new ProductCategory(){Category=Categories[4],Product=Products[24]},
            new ProductCategory(){Category=Categories[0],Product=Products[25]},
            new ProductCategory(){Category=Categories[1],Product=Products[26]},
            new ProductCategory(){Category=Categories[2],Product=Products[27]},
            new ProductCategory(){Category=Categories[3],Product=Products[28]},
            new ProductCategory(){Category=Categories[4],Product=Products[29]},
            new ProductCategory(){Category=Categories[0],Product=Products[30]},
            new ProductCategory(){Category=Categories[1],Product=Products[31]},
            new ProductCategory(){Category=Categories[2],Product=Products[32]},
            new ProductCategory(){Category=Categories[3],Product=Products[33]},
            new ProductCategory(){Category=Categories[4],Product=Products[34]},
            new ProductCategory(){Category=Categories[0],Product=Products[35]},
            new ProductCategory(){Category=Categories[1],Product=Products[36]},
            new ProductCategory(){Category=Categories[2],Product=Products[37]},
            new ProductCategory(){Category=Categories[3],Product=Products[38]},
            new ProductCategory(){Category=Categories[4],Product=Products[39]},
            new ProductCategory(){Category=Categories[0],Product=Products[40]},
            new ProductCategory(){Category=Categories[1],Product=Products[41]},
            new ProductCategory(){Category=Categories[2],Product=Products[42]},
            new ProductCategory(){Category=Categories[3],Product=Products[43]},
            new ProductCategory(){Category=Categories[4],Product=Products[44]},
            new ProductCategory(){Category=Categories[0],Product=Products[45]},
            new ProductCategory(){Category=Categories[1],Product=Products[46]},
            new ProductCategory(){Category=Categories[2],Product=Products[47]},
            new ProductCategory(){Category=Categories[3],Product=Products[48]},
            new ProductCategory(){Category=Categories[4],Product=Products[49]}
        };      

        private static Image[] Images =
        {
            new Image(){ ImageUrl="shop01.png", Product=Products[0]},
            new Image(){ ImageUrl="shop02.png", Product=Products[0]},
            new Image(){ ImageUrl="shop03.png", Product=Products[0]},

            new Image(){ ImageUrl="shop01.png", Product=Products[1]},
            new Image(){ ImageUrl="shop02.png", Product=Products[1]},
            new Image(){ ImageUrl="shop03.png", Product=Products[1]},

            new Image(){ ImageUrl="shop01.png", Product=Products[2]},
            new Image(){ ImageUrl="shop02.png", Product=Products[2]},
            new Image(){ ImageUrl="shop03.png", Product=Products[2]},

            new Image(){ ImageUrl="shop01.png", Product=Products[3]},
            new Image(){ ImageUrl="shop02.png", Product=Products[3]},
            new Image(){ ImageUrl="shop03.png", Product=Products[3]},

            new Image(){ ImageUrl="shop01.png", Product=Products[4]},
            new Image(){ ImageUrl="shop02.png", Product=Products[4]},
            new Image(){ ImageUrl="shop03.png", Product=Products[4]},

            new Image(){ ImageUrl="shop01.png", Product=Products[5]},
            new Image(){ ImageUrl="shop02.png", Product=Products[5]},
            new Image(){ ImageUrl="shop03.png", Product=Products[5]},

            new Image(){ ImageUrl="shop01.png", Product=Products[6]},
            new Image(){ ImageUrl="shop02.png", Product=Products[6]},
            new Image(){ ImageUrl="shop03.png", Product=Products[6]},

            new Image(){ ImageUrl="shop01.png", Product=Products[7]},
            new Image(){ ImageUrl="shop02.png", Product=Products[7]},
            new Image(){ ImageUrl="shop03.png", Product=Products[7]},

            new Image(){ ImageUrl="shop01.png", Product=Products[8]},
            new Image(){ ImageUrl="shop02.png", Product=Products[8]},
            new Image(){ ImageUrl="shop03.png", Product=Products[8]},

            new Image(){ ImageUrl="shop01.png", Product=Products[9]},
            new Image(){ ImageUrl="shop02.png", Product=Products[9]},
            new Image(){ ImageUrl="shop03.png", Product=Products[9]},

            new Image(){ ImageUrl="shop01.png", Product=Products[10]},
            new Image(){ ImageUrl="shop02.png", Product=Products[10]},
            new Image(){ ImageUrl="shop03.png", Product=Products[10]},

            new Image(){ ImageUrl="shop01.png", Product=Products[11]},
            new Image(){ ImageUrl="shop02.png", Product=Products[11]},
            new Image(){ ImageUrl="shop03.png", Product=Products[11]},

            new Image(){ ImageUrl="shop01.png", Product=Products[12]},
            new Image(){ ImageUrl="shop02.png", Product=Products[12]},
            new Image(){ ImageUrl="shop03.png", Product=Products[12]},

            new Image(){ ImageUrl="shop01.png", Product=Products[13]},
            new Image(){ ImageUrl="shop02.png", Product=Products[13]},
            new Image(){ ImageUrl="shop03.png", Product=Products[13]},

            new Image(){ ImageUrl="shop01.png", Product=Products[14]},
            new Image(){ ImageUrl="shop02.png", Product=Products[14]},
            new Image(){ ImageUrl="shop03.png", Product=Products[14]},

            new Image(){ ImageUrl="shop01.png", Product=Products[15]},
            new Image(){ ImageUrl="shop02.png", Product=Products[15]},
            new Image(){ ImageUrl="shop03.png", Product=Products[15]},

            new Image(){ ImageUrl="shop01.png", Product=Products[16]},
            new Image(){ ImageUrl="shop02.png", Product=Products[16]},
            new Image(){ ImageUrl="shop03.png", Product=Products[16]},

            new Image(){ ImageUrl="shop01.png", Product=Products[17]},
            new Image(){ ImageUrl="shop02.png", Product=Products[17]},
            new Image(){ ImageUrl="shop03.png", Product=Products[17]},

            new Image(){ ImageUrl="shop01.png", Product=Products[18]},
            new Image(){ ImageUrl="shop02.png", Product=Products[18]},
            new Image(){ ImageUrl="shop03.png", Product=Products[18]},

            new Image(){ ImageUrl="shop01.png", Product=Products[19]},
            new Image(){ ImageUrl="shop02.png", Product=Products[19]},
            new Image(){ ImageUrl="shop03.png", Product=Products[19]},

            new Image(){ ImageUrl="shop01.png", Product=Products[20]},
            new Image(){ ImageUrl="shop02.png", Product=Products[20]},
            new Image(){ ImageUrl="shop03.png", Product=Products[20]},

            new Image(){ ImageUrl="shop01.png", Product=Products[21]},
            new Image(){ ImageUrl="shop02.png", Product=Products[21]},
            new Image(){ ImageUrl="shop03.png", Product=Products[21]},

            new Image(){ ImageUrl="shop01.png", Product=Products[22]},
            new Image(){ ImageUrl="shop02.png", Product=Products[22]},
            new Image(){ ImageUrl="shop03.png", Product=Products[22]},

            new Image(){ ImageUrl="shop01.png", Product=Products[23]},
            new Image(){ ImageUrl="shop02.png", Product=Products[23]},
            new Image(){ ImageUrl="shop03.png", Product=Products[23]},

            new Image(){ ImageUrl="shop01.png", Product=Products[24]},
            new Image(){ ImageUrl="shop02.png", Product=Products[24]},
            new Image(){ ImageUrl="shop03.png", Product=Products[24]},

            new Image(){ ImageUrl="shop01.png", Product=Products[25]},
            new Image(){ ImageUrl="shop02.png", Product=Products[25]},
            new Image(){ ImageUrl="shop03.png", Product=Products[25]},

            new Image(){ ImageUrl="shop01.png", Product=Products[26]},
            new Image(){ ImageUrl="shop02.png", Product=Products[26]},
            new Image(){ ImageUrl="shop03.png", Product=Products[26]},

            new Image(){ ImageUrl="shop01.png", Product=Products[27]},
            new Image(){ ImageUrl="shop02.png", Product=Products[27]},
            new Image(){ ImageUrl="shop03.png", Product=Products[27]},

            new Image(){ ImageUrl="shop01.png", Product=Products[28]},
            new Image(){ ImageUrl="shop02.png", Product=Products[28]},
            new Image(){ ImageUrl="shop03.png", Product=Products[28]},

            new Image(){ ImageUrl="shop01.png", Product=Products[29]},
            new Image(){ ImageUrl="shop02.png", Product=Products[29]},
            new Image(){ ImageUrl="shop03.png", Product=Products[29]},

            new Image(){ ImageUrl="shop01.png", Product=Products[30]},
            new Image(){ ImageUrl="shop02.png", Product=Products[30]},
            new Image(){ ImageUrl="shop03.png", Product=Products[30]}
        };

        private static ProductDetail[] ProductDetails =
        {
            new ProductDetail(){Color="siyah", Size="s", Product=Products[0]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[0]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[0]},

            new ProductDetail(){Color="siyah", Size="s", Product=Products[1]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[1]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[1]},

            new ProductDetail(){Color="siyah", Size="s", Product=Products[2]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[2]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[2]},

            new ProductDetail(){Color="siyah", Size="s", Product=Products[3]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[3]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[3]},

            new ProductDetail(){Color="siyah", Size="s", Product=Products[4]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[4]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[4]},

            new ProductDetail(){Color="siyah", Size="s", Product=Products[5]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[5]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[5]},

            new ProductDetail(){Color="siyah", Size="s", Product=Products[6]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[6]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[6]},

            new ProductDetail(){Color="siyah", Size="s", Product=Products[7]},
            new ProductDetail(){Color="kırmızı", Size="m",Product=Products[7]},
            new ProductDetail(){Color="mavi", Size="L",Product=Products[7]}
        };

        public static Comment[] Comments =
        {
            new Comment(){Name="John",Email="adada",Review="fena bir şey",Rating=4,Product=Products[0]},
            new Comment(){Name="Michael",Email="adad",Review="fena bir şey",Rating=5,Product=Products[1]},
            new Comment(){Name="Ege",Email="dada",Review="fena bir şey",Rating=3,Product=Products[2]}
        };


    }
}
