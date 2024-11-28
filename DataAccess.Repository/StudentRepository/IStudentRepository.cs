namespace DataAccess.Repository.StudentRepository;
using StudentCrud.DataAccess.Entities;

public interface IStudentRepository
{
    long InsertStudent(Student student);
    void DeleteStudent(long studentId); 
    ICollection<Student> SelectAll();

}
