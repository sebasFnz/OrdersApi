using OrdersApi.Contract;
using OrdersApi.Control;
using OrdersApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class OrderController : ApiController
    {
        IControlOrder control;
        
        public OrderController()
        {
            control = new ControlOrder();
        }

        [ResponseType(typeof(ControlOrder))]
        public IHttpActionResult GetOrder()
        {
            return Ok(control.ListOrder());
        }

        [ResponseType(typeof(ControlOrder))]
        public IHttpActionResult GetOrder(long id)
        {
            return Ok(control.SearchOrder(id));
        }

        [ResponseType(typeof(ControlOrder))]
        public IHttpActionResult DeleteOrder(long id)
        {
            if (ModelState.IsValid)
            {
                control.DeleteOrder(id);
                return Ok("Delete");
            }
            return BadRequest();
        }

        [ResponseType(typeof(ControlOrder))]
        public IHttpActionResult PostOrder(Order order)
        {
            control.AddOrder(order);
            return Ok("Add");
        }
    }
}
