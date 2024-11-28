using Microsoft.EntityFrameworkCore.ChangeTracking;
using StudentCrud.DataAccess;
using StudentCrud.DataAccess.Entities;

namespace DataAccess.Repository.StudentRepository;

public class StudentRepository : IStudentRepository
{
    private readonly MainContext _context;

    public StudentRepository(MainContext context)
    {
        _context = context;
    }

    public void DeleteStudent(long studentId)
    {
        var student = _context.Students.FirstOrDefault(st => st.Id == studentId);

        if(student == null)
        {
            throw new Exception($"Student with id {studentId} not found to delete");
        }

        _context.Students.Remove(student);
        _context.SaveChanges();
    }

    public long InsertStudent(Student student)
    {
        _context.Students.Add(student); 
        _context.SaveChanges();
        return student.Id;
    }

    public ICollection<Student> SelectAll()
    {
        return _context.Students.ToList();
    }
}
