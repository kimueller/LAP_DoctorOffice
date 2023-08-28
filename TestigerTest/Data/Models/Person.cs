using System.ComponentModel.DataAnnotations;

namespace TestigerTest.Data.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
    
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual List<Treatment> Treatments { get; set; }
    }
}
