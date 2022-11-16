using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Nendrean_Flavius_Lab02.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
