using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoolApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoolApi.Controllers {
    [ApiController]
    [Route ("api/[controller]")]
    public class StudentController : Controller {
        private StudentContext _studentContext;
        public StudentController (StudentContext context) {
            _studentContext = context;
        }

        [HttpGet]
        public IEnumerable<Student> Get () {
            // return _studentContext.students.ToList ();
            return _studentContext.students.FromSqlRaw("select * from students").ToList();
        }

        [HttpGet ("{id}")]
        public async Task<ActionResult<Student>> GetSpicStudent (int id) {
            var isStudentExist = await _studentContext.students.FindAsync (id);

            if (isStudentExist == null) {
                return NotFound ();
            }
            return isStudentExist;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent (Student student) {
            _studentContext.students.Add (student);
            await _studentContext.SaveChangesAsync ();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction (nameof (PostStudent), new { id = student.StudentId }, student);
        }

        [HttpDelete ("{id}")]
        public async Task<ActionResult<Student>> DeleteTodoItem (int id) {
            var todoItem = await _studentContext.students.FindAsync (id);
            if (todoItem == null) {
                return NotFound ();
            }

            _studentContext.students.Remove (todoItem);
            await _studentContext.SaveChangesAsync ();

            return todoItem;
        }

    }
}