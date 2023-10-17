namespace nikulinakt41_20.Models
{
    public class AcademicPerfomance
    {
        public int PerfomanceId { get; set; }
        public int SudentId { get; set; }
        public int SubjectId { get; set; }
        public int Subject2 { get; set; }
        public int Subject3 { get; set; }

        public Student Student { get; set; }
        public Subject Subject { get; set; }


    }
}
