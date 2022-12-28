using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class InvestigationOne
	{
		[Key]
		public int InvestigationOneID { get; set; }
		public string InvOneNameSurname { get; set; }
		public string InvOneCity { get; set; }
		public string InvOnePhone { get; set; }
		public string InvOneMaritalStatus { get; set; }
		public int InvOneChildrenNo { get; set; }
		public DateTime InvOneDate { get; set; }
		public string InvOneImageUrl { get; set; }
		public string InvOneOfficer { get; set; }
		public string InvOneClosed { get; set; }
		public int AccussedOneID { get; set; }
		public AccussedOne AccussedOne { get; set; }
		public List<QuestionOne> QuestionOnes { get; set; }
	}
}
