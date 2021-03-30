using OrdersApi.Contract;
using OrdersApi.Control;
using OrdersApi.Model;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoryController : ApiController
    {
        IControlCategory control;

        public CategoryController()
        {
            control = new ControlCategory();
        }

        [ResponseType(typeof(ControlCategory))]
        public IHttpActionResult GetCategory()
        {
            return Ok(control.ListCategory());
        }

        [ResponseType(typeof(ControlCategory))]
        public IHttpActionResult GetCategory(long id)
        {
            return Ok(control.SearchCategory(id));
        }

        [ResponseType(typeof(CategoryController))]
        public IHttpActionResult PostCategory(Category category)
        {
            if (ModelState.IsValid) { 
                control.AddCategory(category);
                return Ok("Add");
            }
            return BadRequest(ModelState);
        }

        [ResponseType(typeof(CategoryController))]
        public IHttpActionResult DeleteCategory(long id)
        {
            control.DeleteCategory(id);
            return Ok("Delete");
        }
    }
}
