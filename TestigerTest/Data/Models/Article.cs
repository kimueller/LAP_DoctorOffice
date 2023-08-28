using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestigerTest.Data.Models
{
    public class Article
    {
        [Key]
        public int ArticleID { get; set; }

        public string ArticleName { get; set; }

        [Column(TypeName = "decimal(7, 2)")]
        public decimal Price { get; set; }

        public virtual List<TreatmentArticle> TreatmentArticles { get; set; }
    }
}
