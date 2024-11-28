using Microsoft.AspNetCore.Mvc;
using StudentCrud.Service.DTOs;
using StudentCrud.Service.StudentService;

namespace StudentCrud.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpPost]
    public long AddStudent(StudentCreateDto studentCreateDto)
    {
        var studentId = _studentService.PostStudent(studentCreateDto);
        return studentId;
    }

    [HttpDelete]
    public void DeleteStudent(long studentId)
    {
        _studentService.DeleteStudent(studentId);
    }

    [HttpGet]
    public ICollection<StudentDto> GetAll()
    {
        var students = _studentService.GetAllStudents();
        return students;
    }
}