using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{

    public class AccussedOneManager : IAccussedOneService
    {
        IAccussedOneDal _accussedOneDal;

        public AccussedOneManager(IAccussedOneDal accussedOneDal)
        {
            _accussedOneDal = accussedOneDal;
        }

        public List<AccussedOne> GetAccussedOneListWithInvOne()
        {
            return _accussedOneDal.GetListWithInvOne(); 
        }

        public void TAdd(AccussedOne t)
        {
            _accussedOneDal.Insert(t);
        }

        public void TDelete(AccussedOne t)
        {
            _accussedOneDal.Delete(t);
        }

        public AccussedOne TGetByID(int id)
        {
            return _accussedOneDal.GetByID(id);
        }

        public List<AccussedOne> TGetList()
        {
            return _accussedOneDal.GetList();
        }

        public void TUpdate(AccussedOne t)
        {
            _accussedOneDal.Update(t);
        }
    }
}
