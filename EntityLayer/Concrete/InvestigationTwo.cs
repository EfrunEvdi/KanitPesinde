using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InvestigationTwo
    {
        [Key]
        public int InvestigationTwoID { get; set; }
        public string InvTwoNameSurname { get; set; }
        public string InvTwoCity { get; set; }
        public string InvTwoPhone { get; set; }
        public string InvTwoMaritalStatus { get; set; }
        public int InvTwoChildrenNo { get; set; }
        public DateTime InvTwoDate { get; set; }
        public string InvTwoImageUrl { get; set; }
        public string InvTwoOfficer { get; set; }
        public string InvTwoClosed { get; set; }
        public List<AccussedTwo> AccussedTwos { get; set; }
        public List<QuestionTwo> QuestionTwos { get; set; }
	}
}
