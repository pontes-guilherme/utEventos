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

        public static bool Inserir(Feedback f, dbEventosEntities db)
        {
            try
            {
                if (db == null)
                {
                    db = new dbEventosEntities();
                }

                f.Id = getLasId();
                f.data_criacao = (DateTime.Now).Date; 
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

        public static Feedback Pesquisar(int id)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Feedback u = new Feedback();

                u = db.Feedbacks.Find(id);
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Feedback u)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Feedback user = new Feedback();

                user = db.Feedbacks.Find(u.Id);
                db.Feedbacks.Remove(user);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Feedback> Listar()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Feedbacks.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
