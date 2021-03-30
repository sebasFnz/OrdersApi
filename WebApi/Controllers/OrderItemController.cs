using OrdersApi.Contract;
using OrdersApi.Control;
using OrdersApi.Model;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrderItemController : ApiController
    {
        IControlOrderItem control;    
        
        public OrderItemController()
        {
            control = new ControlOrderItem();
        }

        [ResponseType(typeof(ControlOrderItem))]
        public IHttpActionResult GetOrderItem()
        {
            return Ok(control.ListOrderItem());
        }

        [ResponseType(typeof(ControlOrderItem))]
        public IHttpActionResult GetOrderItem(long id)
        {
            return Ok(control.SearchOrderItem(id));
        }

        [ResponseType(typeof(ControlOrderItem))]
        public IHttpActionResult DeleteOrderItem(long id)
        {
            control.DeleteOrderItem(id);
            return Ok("Delete");
        }

        [ResponseType(typeof(ControlOrderItem))]
        public IHttpActionResult PostOrderItem(OrderItem orderItem)
        {
            if (ModelState.IsValid)
            {
                control.AddOrderItem(orderItem);
                return Ok("Add");
            }
            return BadRequest();
        }
    }
}
