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
    public class AccussedTwoManager : IAccussedTwoService
    {
        IAccussedTwoDal _accussedTwoDal;

        public AccussedTwoManager(IAccussedTwoDal accussedTwoDal)
        {
            _accussedTwoDal = accussedTwoDal;
        }
        public void TAdd(AccussedTwo t)
        {
            _accussedTwoDal.Insert(t);
        }

        public void TDelete(AccussedTwo t)
        {
            _accussedTwoDal.Delete(t);
        }

        public AccussedTwo TGetByID(int id)
        {
            return _accussedTwoDal.GetByID(id);
        }

        public List<AccussedTwo> TGetList()
        {
            return _accussedTwoDal.GetList();
        }

        public void TUpdate(AccussedTwo t)
        {
            _accussedTwoDal.Update(t);
        }
    }
}
