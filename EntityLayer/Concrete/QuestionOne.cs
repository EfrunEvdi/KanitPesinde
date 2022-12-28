using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class QuestionOne
	{
		[Key]
		public int QuestionOneID { get; set; }	
		public string QuestionOneQuestion { get; set; }	
		public string QuestionOneAnswer { get; set; }
		public int InvestigationOneID { get; set; }
		public InvestigationOne InvestigationOne { get; set; }
		
	}
}
