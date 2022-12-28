using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class QuestionOneManager : IQuestionOneService
	{
		IQuestionOneDal _questionOneDal;

		public QuestionOneManager(IQuestionOneDal questionOneDal)
		{
			_questionOneDal = questionOneDal;
		}

		public void TAdd(QuestionOne t)
		{
			_questionOneDal.Insert(t);
		}

		public void TDelete(QuestionOne t)
		{
			_questionOneDal.Delete(t);
		}

		public QuestionOne TGetByID(int id)
		{
			return _questionOneDal.GetByID(id);	
		}

		public List<QuestionOne> TGetList(int id)
		{
			return _questionOneDal.GetList(x=>x.InvestigationOneID==id);
		}

		public List<QuestionOne> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(QuestionOne t)
		{
			_questionOneDal.Update(t);
		}
	}
}
