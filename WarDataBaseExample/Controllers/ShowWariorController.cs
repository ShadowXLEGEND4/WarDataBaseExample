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
        public void CreateWarior(Warior w)
        {
            using (WariorDBEntities db = new WariorDBEntities())
            {
                var lastWarior = db.Wariors.ToList().LastOrDefault();
                if (lastWarior == null)
                {
                    lastWarior = new Warior();
                    lastWarior.Id = 0;
                }

                w.Id = lastWarior.Id + 1;
                db.Wariors.Add(w);
                db.SaveChanges();
            }
        }

        public static void DeleteWarior(int id)
        {
            using (WariorDBEntities ex = new WariorDBEntities())
            {
                var wariorDelete = ex.Wariors.Where(w => w.Id == id).FirstOrDefault();
                if (wariorDelete != null)
                {
                    ex.Wariors.Remove(wariorDelete);
                    ex.SaveChanges();
                }
            }
        }

        public static void UpdateWarior(int id, Warior w)
        {
            using (WariorDBEntities ex = new WariorDBEntities())
            {
                var wariorUpdate = ex.Wariors.Where(p => p.Id == id).FirstOrDefault();
                if (wariorUpdate != null)
                {
                    wariorUpdate.Id = w.Id;
                    wariorUpdate.Health = w.Health;
                    wariorUpdate.Kills = w.Kills;
                    ex.SaveChanges();
                }
            }
        }
    }
}
