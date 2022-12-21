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
    public class IntroManager : IIntroService
    {
        IIntroDal _introDal;

        public IntroManager(IIntroDal introDal)
        {
            _introDal = introDal;
        }

        public void TAdd(Intro t)
        {
            _introDal.Insert(t);
        }

        public void TDelete(Intro t)
        {
            _introDal.Delete(t);
        }

        public Intro TGetByID(int id)
        {
            return _introDal.GetByID(id);
        }

        public List<Intro> TGetList()
        {
            return _introDal.GetList();
        }

        public void TUpdate(Intro t)
        {
            _introDal.Update(t);
        }
    }
}
