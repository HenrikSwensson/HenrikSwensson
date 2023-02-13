using System;

namespace Datalayer_
{
    public class DataManager

    {
        public List<Products> GetProduct()
        {
            using (var db = new NorthWind())
            {
                return db.Products.ToList();
            }
        }
    }
}
