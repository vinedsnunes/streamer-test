using System.ComponentModel.DataAnnotations;

namespace SS_API.Model
{
    public class CourseModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}