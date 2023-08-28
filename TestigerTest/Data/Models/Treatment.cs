using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestigerTest.Data.Models
{
    public class Treatment
    {
        [Key]
        public int TreatmentID { get; set; }

        public int PatientID { get; set; }

        [ForeignKey("Id")]
        public string DoctorID { get; set; }
        public DateTime Date { get; set; }

        public Person Patient { get; set; }

        public IdentityUser Doctor { get; set; }

        public virtual List<TreatmentArticle> TreatmentArticles { get; set; }

    }
}
