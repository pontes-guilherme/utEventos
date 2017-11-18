using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public class pnSugestoes
    {

        public static bool Inserir(Sugesto s)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                s.Id = getLasId();
                db.Sugestoes.Add(s);
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
                int id = db.Sugestoes.Max(p => p.Id);
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
