using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Services.DTOs
{
    public class BookDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public double Reting { get; set; }
        public int NumberOfCopiesSold { get; set; }
        public DataSetDateTime PublishesDate { get; set; }
    }
}
