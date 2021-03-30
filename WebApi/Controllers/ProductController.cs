using OrdersApi.Contract;
using OrdersApi.Control;
using OrdersApi.Model;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ProductController : ApiController
    {
        IControlProduct control;

        public ProductController()
        {
            control = new ControlProduct();
        }

        [ResponseType(typeof(ControlProduct))]
        public IHttpActionResult GetProduct()
        {
            return Ok(control.ListProduct());
        }

        [ResponseType(typeof(ControlProduct))]
        public IHttpActionResult GetProduct(long id)
        {
            return Ok(control.SearchProduct(id));
        }

        [Route("{category}")]
        [ResponseType(typeof(ControlProduct))]
        public IHttpActionResult GetProductByCategory(long category)
        {
            return Ok(control.SearchProduct(category));
        }


        [ResponseType(typeof(ControlProduct))]
        public IHttpActionResult DeleteProduct(long id)
        {
            control.DeleteProduct(id);
            return Ok("Delete");
        }

        [ResponseType(typeof(ControlProduct))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (ModelState.IsValid) { 
                control.AddProduct(product);
                return Ok("Add");
            }
            return BadRequest();
        }

    }
}
