namespace nikulinakt41_20.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public string Teacher {  get; set; }
        public int AcademicPerfomanceId { get; set; }
        public AcademicPerfomance AcademicPerfomance { get; set; }

    }
}
