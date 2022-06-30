using Apidb;
using Apidb.Entites;
using Apidblayer.Api;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apidblayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ApiContext _context;
        private readonly IMapper _mapper;
        public TeacherController(ApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeacher()
        {
            if (_context.Teachers == null)
            {
                return NotFound();
            }
            return await _context.Teachers.ToListAsync();
        }

        // GET api/<TeacherController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Teacher>> GetEmployee(int id)
        {
            if (_context.Teachers == null)
            {
                return NotFound();
            }
            var teacher = await _context.Teachers.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            return teacher;
        }

        // PUT api/<TeacherController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher(int id, Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return BadRequest();
            }

            _context.Entry(teacher).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        // POST api/<TeacherController>
        [HttpPost]
        public async Task<ActionResult<Teacher>> PostEmployee(TeacherAndClasseApi teacherAnd)
        {
            if (_context.Teachers == null)
            {
                return Problem("Entity set 'WebAPIDBContext.Employees'  is null.");
            }

            var obj = _mapper.Map<Teacher>(teacherAnd.Teacher);
            var orgList = _mapper.Map<List<Classes>>(teacherAnd.classe);

            obj.classes = orgList;

            _context.Teachers.Add(obj);
            await _context.SaveChangesAsync();

            return Ok(teacherAnd.Teacher);
        }

        // DELETE api/<TeacherController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            if (_context.Teachers == null)
            {
                return NotFound();
            }
            var employee = await _context.Teachers.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }

            _context.Teachers.Remove(employee);
            await _context.SaveChangesAsync();

            return NoContent();

        }
        private bool TeacherExists(int id)
        {
            return (_context.Teachers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}