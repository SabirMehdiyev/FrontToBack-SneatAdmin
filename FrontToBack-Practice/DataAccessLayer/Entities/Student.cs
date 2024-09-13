namespace FrontToBack_Practice.DataAccessLayer.Entities;

public class Student:BaseEntity
{
    public string Name { get; set; }
    public int Grade { get; set; }
    public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();  

}
