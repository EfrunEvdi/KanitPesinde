using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Accussed1
    {
        [Key]
        public int Accussed1ID { get; set; }
        public string Accussed1NameSurname { get; set; }
        public string Accussed1Close { get; set; }
        public string Accussed1ImageUrl { get; set; }


    }
}
