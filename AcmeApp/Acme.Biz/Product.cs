﻿using static Acme.Common.LoggingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    /// <summary>
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        public Product()
        {
            Console.WriteLine("Product Instance Created");
        }

        public Product(int productId,
                       string productName,
                       string description) : this()
        {
            this.ProductId = productId;
            this.ProductName = productName;
            this.Description = description;

            Console.WriteLine("Product instance has a name: " +
                                ProductName);
        }

        private string productName;

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private int productId;

        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

        private Vendor productVendor;

        public Vendor ProductVendor
        {
            get
            {
                if (productVendor == null) //lazy loading
                    productVendor = new Vendor();

                return productVendor;
            }
            set { productVendor = value; }
        }


        public string SayHello()
        {
            var result = LogAction("Saying Hello"); //using static

            return "Hello " + ProductName +
                    " (" + ProductId + "): " +
                    Description;
        }

    }
}
