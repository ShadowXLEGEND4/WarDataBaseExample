using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarDataBaseExample.Models;

namespace WarDataBaseExample.Controllers
{
    public class ShowWariorController
    {
        public List<Warior> GetAll()
        {
            using (WariorDBEntities ex = new WariorDBEntities())
            {
                return ex.Wariors.ToList();
            }
        }
    }
}
