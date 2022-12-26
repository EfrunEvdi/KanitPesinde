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
    public class Accussed2Manager : IAccussed2Service
    {
        IAccussed2Dal _accussed2Dal;

        public Accussed2Manager(IAccussed2Dal accussed2Dal)
        {
            _accussed2Dal = accussed2Dal;
        }
        public void TAdd(Accussed2 t)
        {
            _accussed2Dal.Insert(t);
        }

        public void TDelete(Accussed2 t)
        {
            _accussed2Dal.Delete(t);
        }

        public Accussed2 TGetByID(int id)
        {
            return _accussed2Dal.GetByID(id);
        }

        public List<Accussed2> TGetList()
        {
            return _accussed2Dal.GetList();
        }

        public void TUpdate(Accussed2 t)
        {
            _accussed2Dal.Update(t);
        }
    }
}
