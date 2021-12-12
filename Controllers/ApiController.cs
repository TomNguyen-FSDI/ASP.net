
using Microsoft.AspNetCore.Mvc;
using Task_Manager.Models;
using System.Linq;
using System.Collections.Generic;

namespace taskManager.Controllers
{
    public class ApiController : Controller
    {
        private DataContext dbContext;
        public ApiController(DataContext db)
        {
            dbContext = db;
            //I'm the constructor        
        }

        [HttpGet]
        public IActionResult Test()
        {
            string name = "Tom";
            return Json(name);
            
        }

        [HttpGet]
        public IActionResult GetTask()
        {
            //read the databases
            var tasks = dbContext.Tasks.ToList();
            //List<PizzaWithPepperoni> pizza = new List<PizzaWithPepperoni>();
            return Json(tasks);
        }

        [HttpPost]
        public IActionResult PostTask([FromBody] Task theTask)
        {
            //send theTask to database
            dbContext.Tasks.Add(theTask);

            //open the connection

            //INSERT INTO TASKS (title, important, status, dueDate, location, color, description)
            //VALUE (' + theTask.title ' +", '" + theTask.important + "','" + theTask.status ....)

            //exec

            // validate results

            //close connection

            dbContext.SaveChanges();
            
            // assign an id
            // theTask.Id=1;

            //return the object
            return Json(theTask);
        }
        
        [HttpDelete]
        public IActionResult DelTask([FromBody] Task theTask){
            // Task newTask=dbContext.Tasks.Find(number);
            // dbContext.Tasks.Remove(newTask);
            // System.Console.WriteLine("number: "+number);
            // System.Console.WriteLine("newTask: "+newTask);
            dbContext.Tasks.Remove(theTask);
           dbContext.SaveChanges();
            return Ok();
        }
    }
}