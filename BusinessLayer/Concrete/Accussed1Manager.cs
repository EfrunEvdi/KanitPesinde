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
   
    public class Accussed1Manager:IAccussed1Service
    {
        IAccussed1Dal _accussed1Dal;

        public Accussed1Manager(IAccussed1Dal accussed1Dal)
        {
            _accussed1Dal = accussed1Dal;
        }

        public void TAdd(Accussed1 t)
        {
            _accussed1Dal.Insert(t);
        }

        public void TDelete(Accussed1 t)
        {
            _accussed1Dal.Delete(t);
        }

        public Accussed1 TGetByID(int id)
        {
            return _accussed1Dal.GetByID(id);
        }

        public List<Accussed1> TGetList()
        {
            return _accussed1Dal.GetList();
        }

        public void TUpdate(Accussed1 t)
        {
            _accussed1Dal.Update(t);
        }
    }
}
