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
    public class InvestigationTwoManager : IInvestigationTwoService
    {
        IInvestigationTwoDal _investigationTwoDal;
        public InvestigationTwoManager(IInvestigationTwoDal investigationTwoDal)
        {
            _investigationTwoDal = investigationTwoDal;
        }

        public void TAdd(InvestigationTwo t)
        {
            _investigationTwoDal.Insert(t);
        }

        public void TDelete(InvestigationTwo t)
        {
            _investigationTwoDal.Delete(t);

        }

        public InvestigationTwo TGetByID(int id)
        {
            return _investigationTwoDal.GetByID(id);
        }

        public List<InvestigationTwo> TGetList()
        {
            return _investigationTwoDal.GetList();

        }

        public void TUpdate(InvestigationTwo t)
        {
            _investigationTwoDal.Update(t);

        }
    }
}
