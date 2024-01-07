﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {// Nesne örneği ortaya çıkartır.
     // Hamburger nesne ise vejeteryan için hamburger
     // ve normal hamburger için üretilmesi sürecinde
     // atılacak adım ve ürünlerin belli bir sırayla oluşturulması
     // Soyutlama ile ifleri engellemek amacımız.
        static void Main(string[] args)
        {


            ProductDirector director = new ProductDirector();
            var builder = new NewCustomerProductBuilder();
            director.GenerateProduct(builder);

            var model = builder.GetModel();

            Console.WriteLine(model.CategoryName);
            Console.WriteLine(model.Id);
            Console.WriteLine(model.UnitPrice);

            Console.ReadLine();



        }
    }


    class ProductViewModel
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal DiscountedPrice { get; set; }
        public bool DiscountApplied { get; set; }
    }
    // public olmasına gerek yok hepsi aynı namespace altında
    abstract class ProductBuilder
    {
        public abstract void GetProductData();
        public abstract void ApplyDiscount();

        public abstract ProductViewModel GetModel();

    }

    class NewCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();

        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice * (decimal)0.90;
            model.DiscountApplied = true;
        }

        

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
     
        }


        public override ProductViewModel GetModel()
        {
            return model;
        }
    }

    class OldCustomerProductBuilder : ProductBuilder
    {
        ProductViewModel model = new ProductViewModel();
        public override void ApplyDiscount()
        {
            model.DiscountedPrice = model.UnitPrice;
            model.DiscountApplied = false;
        }

        public override void GetProductData()
        {
            model.Id = 1;
            model.CategoryName = "Beverages";
            model.ProductName = "Chai";
            model.UnitPrice = 20;
        }

        public override ProductViewModel GetModel()
        {
            return model;
        }
    }

    class ProductDirector
    {
        public void GenerateProduct(ProductBuilder productBuilder)
        {
            productBuilder.GetProductData();
            productBuilder.ApplyDiscount();
            //Arka arkaya işlem çalıştıracağımız zaman kullanılır
        }
    }


}
