using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer.Concrete
{
    public class DetectiveStoryManager : IDetectiveStoryService
    {
        IDetectiveStoryDal _detectiveStoryDal;
        public DetectiveStoryManager(IDetectiveStoryDal detectiveStoryDal)
        {
            _detectiveStoryDal = detectiveStoryDal;
        }

        public void TAdd(DetectiveStory t)
        {
            _detectiveStoryDal.Insert(t);
        }

        public void TDelete(DetectiveStory t)
        {
            _detectiveStoryDal.Delete(t);
        }

        public DetectiveStory TGetByID(int id)
        {
            return _detectiveStoryDal.GetByID(id);
        }

        public List<DetectiveStory> TGetList()
        {
            return _detectiveStoryDal.GetList();
        }

        public void TUpdate(DetectiveStory t)
        {
            _detectiveStoryDal.Update(t);
        }
    }
}
