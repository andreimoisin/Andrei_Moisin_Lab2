using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Moisin_Andrei_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<Book>? Books { get; set; }

        [Display(Name = "Author's Name")]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }
    }
}
