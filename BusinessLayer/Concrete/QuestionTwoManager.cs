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
	public class QuestionTwoManager : IQuestionTwoService
	{
		IQuestionTwoDal _questionTwoDal;

		public QuestionTwoManager(IQuestionTwoDal questionTwoDal)
		{
			_questionTwoDal = questionTwoDal;
		}

		public void TAdd(QuestionTwo t)
		{
			_questionTwoDal.Insert(t);
		}

		public void TDelete(QuestionTwo t)
		{
			_questionTwoDal.Delete(t);
		}

		public QuestionTwo TGetByID(int id)
		{
			return _questionTwoDal.GetByID(id);	
		}

		public List<QuestionTwo> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(QuestionTwo t)
		{
			_questionTwoDal.Update(t);
		}
	}
}
