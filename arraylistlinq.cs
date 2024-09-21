using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shubhalimam
{
    internal class arraylistlinq
    {
        class Class10
        {
            class ProductStore
            {
                public string productName { get; set; }
                public int productPrice { get; set; }
            }
            static void Main(string[] args)
            {
                ArrayList productList = new ArrayList();
                productList.Add(new ProductStore { productName = "Hard Disk", productPrice = 1280 });
                productList.Add(new ProductStore { productName = "Monitor", productPrice = 3000 });
                productList.Add(new ProductStore { productName = "SSD Disk", productPrice = 3500 });
                productList.Add(new ProductStore { productName = "RAM", productPrice = 2450 });
                productList.Add(new ProductStore { productName = "processor", productPrice = 7680 });
                productList.Add(new ProductStore { productName = "Bluetooth", productPrice = 540 });
                productList.Add(new ProductStore { productName = "keyboard", productPrice = 1130 });        
                //Method 1 : Query Expression
                var search = from ProductStore p in productList
                             where p.productName.Contains("Disk")
                             select p; foreach (var result in search)
                {
                    Console.WriteLine("Product Name: {0}, Price: {1}", result.productName, result.productPrice);
                }
            }
        }
    }
}

