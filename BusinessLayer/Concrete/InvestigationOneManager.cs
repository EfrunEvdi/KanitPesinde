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
    public class InvestigationOneManager : IInvestigationOneService
    {
        IInvestigationOneDal _investigationOneDal;
        public InvestigationOneManager(IInvestigationOneDal investigationOneDal)
        {
            _investigationOneDal = investigationOneDal;
        }

        public void TAdd(InvestigationOne t)
        {
            _investigationOneDal.Insert(t);
        }

        public void TDelete(InvestigationOne t)
        {
            _investigationOneDal.Delete(t);

        }

        public InvestigationOne TGetByID(int id)
        {
            return _investigationOneDal.GetByID(id);
        }
        public List<InvestigationOne> GetInvestigationOneByID(int id)
        {
            return _investigationOneDal.GetList(x=>x.InvestigationOneID== id);  

        }
        public List<InvestigationOne> TGetList()
        {
            return _investigationOneDal.GetList();

        }

        public void TUpdate(InvestigationOne t)
        {
            _investigationOneDal.Update(t);

        }
    }
}
