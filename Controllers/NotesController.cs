using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ToDoApp_Backend.Models;
using System.Web.Http.Cors;



namespace ToDoApp_Backend.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class NotesController : ApiController
    {
        // GET: api/Notes
        public IEnumerable<Note> Get()
        {
            using (TodoEntities2 entities = new TodoEntities2())
            {   
                return entities.Notes.ToList(); 
            }
        }

        // GET: api/Notes/5
        public Note Get(int id)
        {
            using (TodoEntities2 entities = new TodoEntities2())
            {
                return entities.Notes.FirstOrDefault(e => e.id == id);
            }
        }

        // POST: api/Notes
        public void Post(Note value)
        {
            using (TodoEntities2 entities = new TodoEntities2())
            {
                entities.Notes.Add(value);
                entities.SaveChanges();
            }
        }

        // PUT: api/Notes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Notes/5
        public void Delete(int id)
        {
        }
    }
}
