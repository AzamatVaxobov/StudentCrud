using StudentCrud.Service.DTOs;

namespace StudentCrud.Service.StudentService;

public interface IStudentService
{
    long PostStudent(StudentCreateDto studentCreateDto);
    void DeleteStudent(long studentId); 
    ICollection<StudentDto> GetAllStudents();
}