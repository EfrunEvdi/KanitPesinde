using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AccussedTwo
    {

        [Key]
        public int AccussedTwoID { get; set; }
        public string AccussedTwoNameSurname { get; set; }
        public string AccussedTwoClose { get; set; }
        public string AccussedTwoImageUrl { get; set; }
        public int InvestigationTwoID { get; set; }
        public InvestigationTwo InvestigationTwo { get; set; }
    }
}
