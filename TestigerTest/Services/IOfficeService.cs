using TestigerTest.Data.Models;

namespace TestigerTest.Services
{
    public interface IOfficeService
    {
        public List<Treatment> GetTreatments();

        public Treatment GetTreatmentByID(int treatmentID);

        public List<Article> GetNotGivenArticles(Treatment treatment);
        public List<TreatmentArticle> GetGivenArticles(Treatment treatment);

        public void AddArticle(TreatmentArticle article);
        public void DeleteArticle(TreatmentArticle article);
    }
}
