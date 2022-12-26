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
    public class FindKillerManager : IFindKillerService
    {
        IFindKillerDal _findKillerDal;
        public FindKillerManager(IFindKillerDal findKillerDal)
        {
            _findKillerDal = findKillerDal;
        }

        public void TAdd(FindKiller t)
        {
            _findKillerDal.Insert(t);
        }

        public void TDelete(FindKiller t)
        {
            _findKillerDal.Delete(t);
        }

        public FindKiller TGetByID(int id)
        {
            return _findKillerDal.GetByID(id);
        }

        public List<FindKiller> TGetList()
        {
            return _findKillerDal.GetList();
        }

        public void TUpdate(FindKiller t)
        {
            _findKillerDal.Update(t);
        }
    }
}
