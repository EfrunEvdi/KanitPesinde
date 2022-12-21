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
    public class SceneOneManager : ISceneOneService
    {
        ISceneOneDal _sceneOneDal;
        public SceneOneManager(ISceneOneDal sceneOneDal)
        {
            _sceneOneDal = sceneOneDal;
        }

        public void TAdd(SceneOne t)
        {
            _sceneOneDal.Insert(t);
        }

        public void TDelete(SceneOne t)
        {
            _sceneOneDal.Delete(t);
        }

        public SceneOne TGetByID(int id)
        {
            return _sceneOneDal.GetByID(id);
        }

        public List<SceneOne> TGetList()
        {
            return _sceneOneDal.GetList();
        }

        public void TUpdate(SceneOne t)
        {
            _sceneOneDal.Update(t);
        }
    }
}
