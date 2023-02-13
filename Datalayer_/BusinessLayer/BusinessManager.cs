using System;

namespace BusinessLayer
{
    public class BusinessManager
    {
        DataManager dataManger = new DataManager();
        public List<Products> GetProducts()
        {
            List<Products> products = new List<Products>();
            foreach (Datalayer_.Products product in dataManager.GetProducts())
                prodcuts.Add(new Prodcuts(product));
            return products;
        }
    }
}
