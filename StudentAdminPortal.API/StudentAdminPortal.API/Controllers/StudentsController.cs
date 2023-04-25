using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdminPortal.API.DataModels;
using StudentAdminPortal.API.Repositories;
using System.ComponentModel.DataAnnotations;

namespace StudentAdminPortal.API.Controllers
{
    [ApiController]
    public class StudentsController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;

        public StudentsController(IStudentRepository studentRepository, IMapper mapper) {
            this.studentRepository = studentRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var students = studentRepository.GetStudentsAsync();
            
            return Ok(mapper.Map<List<Student>>(students)); 
        }
    }
}
