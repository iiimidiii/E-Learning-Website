namespace Eleaning_Web.DTO
{
    public class ResultDTO
    {
        public string? LRId { get; set; }
        public float ScoreAvg { get; set; }
        public float AttendancePoint { get; set; }
        public float ScoreOralTest { get; set; }
        public float Score { get; set; }
        public float Score15Minunes { get; set; }
        public float ScoreCoefficient2 { get; set; }
        public float ScoreCoefficient3 { get; set; }
        public float SumScoreAvg { get; set; }
        public bool ResultOfEvaluation { get; set; }
        public DateTime DateUpdate { get; set; }
        public int IdSubject { get; set; }  
        public int IdUser { get; set; }
    }
}
