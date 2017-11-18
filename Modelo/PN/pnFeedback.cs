using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public class pnFeedback
    {

        public static bool Inserir(Feedback f)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                f.Id = getLasId();
                db.Feedbacks.Add(f);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int getLasId()
        {

            dbEventosEntities db = new dbEventosEntities();
            try
            {
                int id = db.Feedbacks.Max(p => p.Id);
                if (id >= 0)
                {
                    return id + 1;
                }
            }
            catch (Exception)
            {
                return 0;
            }

            return 0;
        }
    }
}
