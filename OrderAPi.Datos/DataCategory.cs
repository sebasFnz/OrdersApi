using OrdersApi.Contract;
using OrdersApi.Model;
using System.Collections.Generic;
using System.Linq;

namespace OrderAPi.Datos
{

    public class DataCategory : IDataCategory
    {
        OrderDBEntities Db;

        public DataCategory()
        {
            Db = new OrderDBEntities();
        }
        public void AddCategory(Category category)
        {
            Db.Category.Add(category);
            Db.SaveChanges();
        }

        public Category SearchCategory(long id)
        {
            return Db.Category.Find(id);
        }
        public void DeleteCategory(long id)
        {
            var category = SearchCategory(id);

            if(category != null)
            {
                Db.Category.Remove(category);
                Db.SaveChanges();
            }
        }

        public List<Category> ListCategory()
        {
            return Db.Category.ToList();
        }

       
    }
}
