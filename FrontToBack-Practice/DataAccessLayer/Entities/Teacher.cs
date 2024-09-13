namespace FrontToBack_Practice.DataAccessLayer.Entities;

public class Teacher:BaseEntity
{
    public string Name { get; set; }
    public int Age { get; set; }
    public ICollection<TeacherStudent> TeacherStudents { get; set; } = new List<TeacherStudent>();
    public override string ToString()
    {
        return $"TeacherId:{Id} - Teacher:{Name} - Age:{Age}";
    }
}
