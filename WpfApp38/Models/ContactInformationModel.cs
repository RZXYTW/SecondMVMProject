using ServiceStack.DataAnnotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp38.Models
{
    [Table("CITable")]
    public class ContactInformationModel
    {
        [Key]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Designnation { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}
