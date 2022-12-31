using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfAccussedOneDal : GenericRepository<AccussedOne>, IAccussedOneDal
    {
        public List<AccussedOne> GetListWithInvOne()
        {
            using (var c=new Context())
            {
                return c.AccussedOnes.Include(x=>x.InvestigationOne).ToList();  
            }
        }
    }
}
