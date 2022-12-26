using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Accussed2
    {

        [Key]
        public int Accussed2ID { get; set; }
        public string Accussed2NameSurname { get; set; }
        public string Accussed2Close { get; set; }
        public string Accussed2ImageUrl { get; set; }
    }
}
