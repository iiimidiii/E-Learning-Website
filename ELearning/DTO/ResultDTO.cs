namespace Eleaning_Web.DTO
{
    public class ResultDTO
    {
        public string ResultId { get; set; } = null!;
        public double? Score { get; set; }
        public DateTime? ExamDate { get; set; }
        public string? ExamId { get; set; }
        public string? UserId { get; set; }

        
    }
}
