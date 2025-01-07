using System.Data;

namespace Exam.DataAccess.Entites
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public double Reting {  get; set; }
        public int NumberOfCopiesSold { get; set; }
        public int PublishesDate { get; set; }
    }
}
