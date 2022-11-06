using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moisin_Andrei_Lab2.Models.ViewModels
{
    public class PublisherIndexData
    {
        public IEnumerable<Publisher> Publishers { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
