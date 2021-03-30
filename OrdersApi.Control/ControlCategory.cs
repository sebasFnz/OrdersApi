using OrderAPi.Datos;
using OrdersApi.Contract;
using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Control
{
    public class ControlCategory : IControlCategory
    {
        IDataCategory data;

        public ControlCategory()
        {
            data = new DataCategory();
        }

        public void AddCategory(Category category)
        {
            data.AddCategory(category);
        }

        public void DeleteCategory(long id)
        {
            data.DeleteCategory(id);
        }

        public List<Category> ListCategory()
        {
            return data.ListCategory();
        }

        public Category SearchCategory(long id)
        {
            return data.SearchCategory(id);
        }
    }
}
