using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AccussedOne
    {
        [Key]
        public int AccussedOneID { get; set; }
        public string AccussedOneNameSurname { get; set; }
        public string AccussedOneClose { get; set; }
        public string AccussedOneImageUrl { get; set; }


    }
}
