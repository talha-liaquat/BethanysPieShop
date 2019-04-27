using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BethanysPieShop.Models
{
    public class PieRepository : IPieRepository
    {
        private AppDBContext appDBContext;

        public PieRepository(AppDBContext appDBContext)
        {
            this.appDBContext = appDBContext;
        }

        public IEnumerable<Pie> GetAllPies()
        {
            return appDBContext.Pies;
        }

        public Pie GetPieById(int pieId)
        {
            return appDBContext.Pies.FirstOrDefault(p => p.Id == pieId);
        }
    }
}
