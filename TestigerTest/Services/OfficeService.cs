using Microsoft.EntityFrameworkCore;
using TestigerTest.Data;
using TestigerTest.Data.Models;

namespace TestigerTest.Services
{
    public class OfficeService : IOfficeService
    {
        private readonly ApplicationDbContext dbc;

        public OfficeService(ApplicationDbContext dbc)
        {
            this.dbc = dbc;
        }

        public List<Article> GetNotGivenArticles(Treatment treatment)
        {
            var article = dbc.TreatmentArticles.Include(a => a.Article).Where(a => a.Treatment.TreatmentID == treatment.TreatmentID).Select(a=> a.ArticleID).ToList();

            var notGivenArticles = dbc.Articles.Where(a => !article.Contains(a.ArticleID)).ToList();

            return notGivenArticles;
        }       
        public List<TreatmentArticle> GetGivenArticles(Treatment treatment)
        {
            var article = dbc.TreatmentArticles.Include(a => a.Article).Where(a => a.Treatment.TreatmentID == treatment.TreatmentID).ToList();

            return article;
        }

        public Treatment GetTreatmentByID(int treatmentID)
        {
            var treatment = dbc.Treatments
                            .Include(t => t.Doctor)
                            .Include(t => t.Patient)
                            .Where(t => t.TreatmentID == treatmentID)
                            .First();
            return treatment;
        }

        public List<Treatment> GetTreatments()
        {
            var treatments = dbc.Treatments
                            .Include(t => t.Doctor)
                            .Include(t=> t.Patient)
                            .ToList();
            return treatments;
        }

        public void AddArticle(TreatmentArticle article)
        {
            dbc.Add(article);
            dbc.SaveChanges();
        }

        public void DeleteArticle(TreatmentArticle article)
        {
            dbc.Remove(article);
            dbc.SaveChanges();
        }
    }
}
