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
    public class SceneTwoManager : ISceneTwoService
    {
        ISceneTwoDal _sceneTwoDal;
        public SceneTwoManager(ISceneTwoDal sceneTwoDal)
        {
            _sceneTwoDal = sceneTwoDal;
        }

        public void TAdd(SceneTwo t)
        {
            _sceneTwoDal.Insert(t);
        }

        public void TDelete(SceneTwo t)
        {
            _sceneTwoDal.Delete(t);
        }

        public SceneTwo TGetByID(int id)
        {
            return _sceneTwoDal.GetByID(id);
        }

        public List<SceneTwo> TGetList()
        {
            return _sceneTwoDal.GetList();
        }

        public void TUpdate(SceneTwo t)
        {
            _sceneTwoDal.Update(t);
        }
    }
}
