using OrdersApi.Contract;
using OrdersApi.Control;
using OrdersApi.Model;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;

namespace WebApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ClientsController : ApiController
    {
        //private OrderDBEntities db = new OrderDBEntities();
        IControlClient control;

        public ClientsController()
        {
            control = new ControlClient();
        }

        
        [ResponseType(typeof(ControlClient))]
        public IHttpActionResult GetClient()
        {
            return Ok(control.ListClient());
        }

        [ResponseType(typeof(ControlClient))]
        public IHttpActionResult GetClient(long id)
        {
            return Ok(control.SearchClient(id));
        }

        [ResponseType(typeof(ControlClient))]
        public IHttpActionResult PostClient(Client client)
        {
            if (ModelState.IsValid)
            {
                control.AddClient(client);
                return Ok("Add");
            }
            return BadRequest(ModelState);
        }

        [ResponseType(typeof(ControlClient))]
        public IHttpActionResult DeleteClient(long id)
        {
                control.DeleteClient(id);
                return Ok("Delete");
            
        }




        /*
        // GET: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult GetClient(long id)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            return Ok(client);
        }

        // PUT: api/Clients/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutClient(long id, Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != client.Id)
            {
                return BadRequest();
            }

            db.Entry(client).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ClientExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Clients
        [ResponseType(typeof(Client))]
        public IHttpActionResult PostClient(Client client)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Client.Add(client);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = client.Id }, client);
        }

        // DELETE: api/Clients/5
        [ResponseType(typeof(Client))]
        public IHttpActionResult DeleteClient(long id)
        {
            Client client = db.Client.Find(id);
            if (client == null)
            {
                return NotFound();
            }

            db.Client.Remove(client);
            db.SaveChanges();

            return Ok(client);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ClientExists(long id)
        {
            return db.Client.Count(e => e.Id == id) > 0;
        }

        */
    }
}