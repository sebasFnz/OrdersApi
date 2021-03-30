using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersApi.Contract
{
    public interface IControlCategory
    {
        void AddCategory(Category category);

        Category SearchCategory(long id);

        List<Category> ListCategory();

        void DeleteCategory(long id);
    }
}
