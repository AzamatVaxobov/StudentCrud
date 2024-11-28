using DataAccess.Repository.StudentRepository;
using StudentCrud.DataAccess.Entities;
using StudentCrud.Service.DTOs;

namespace StudentCrud.Service.StudentService;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public void DeleteStudent(long studentId)
    {
        _studentRepository.DeleteStudent(studentId);
    }

    public ICollection<StudentDto> GetAllStudents()
    {
        var students = _studentRepository.SelectAll();
        var studentDtos = students.Select(st => ConvertToStudentDto(st)).ToList();  
        return studentDtos;
        
    }

    public long PostStudent(StudentCreateDto studentCreateDto)
    {

        var student = new Student()
        {
            FirstName = studentCreateDto.FirstName,
            LastName = studentCreateDto.LastName,
            Email = studentCreateDto.Email,
            EmailPassword = studentCreateDto.EmailPassword,
        };

        var studentId = _studentRepository.InsertStudent(student);
        return studentId;
    }

    private StudentDto ConvertToStudentDto(Student student)
    {
        var studentDto = new StudentDto()
        {
            Id = student.Id,
            FirstName = student.FirstName,
            LastName = student.LastName,
            Email = student.Email
        };

        return studentDto;
    }
}
