namespace FrontToBack_Practice.DataAccessLayer.Entities;

public class TeacherStudent:BaseEntity
{
    public int TeacherId { get; set; }
    public int StudentId { get; set; }
    public Student? Student { get; set; }
    public Teacher? Teacher { get; set; }
}
