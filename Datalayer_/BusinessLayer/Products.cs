 using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer
{
    public class Products : Datalayer_.Products
    {
        public Products(Datalayer_.Products products)
        {
            ProductID = products.ProductID;
            ProduceName = products.ProductName;
            UntiPrice = products.UntiPrice;
            CategoryID = products.CategoryID;
            Discounted = products.Discounted;
            QuantityPerUnti = products.QuantityPerUnit;
            ReorderLevel = products.ReorderLevel;
            SupplierID = products.SupplierID;
            UnitsOnOrder = products.UnitsOnOrder;
            UnitsInStock = products.UnitsInStock;
        }
    }
}
