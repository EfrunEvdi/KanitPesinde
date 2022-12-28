using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class QuestionTwo
	{
		[Key]
		public int QuestionTwoID { get; set; }
		public string QuestionTwoQuestion { get; set; }
		public string QuestionTwoAnswer { get; set; }
		public int InvestigationTwoID { get; set; }
		public InvestigationTwo InvestigationTwo { get; set; }
	}
}
