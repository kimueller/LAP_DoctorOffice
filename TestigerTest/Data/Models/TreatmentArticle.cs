using System.ComponentModel.DataAnnotations;

namespace TestigerTest.Data.Models
{
    public class TreatmentArticle
    {
        [Key]
        public int TreatmentArticleID { get; set; }

        public int TreatmentID { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "No article selected!")]

        public int ArticleID { get; set; }

        [Range(1, 100, ErrorMessage ="Amount has to be in range 1-100")]
        public int Amount { get; set; }

        public Treatment Treatment { get; set; }

        public Article Article { get; set; }
    }
}