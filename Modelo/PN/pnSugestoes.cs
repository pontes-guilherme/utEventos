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

        public static bool Inserir(Sugesto s, dbEventosEntities db)
        {
            try
            {
                if(db == null)
                {
                    db = new dbEventosEntities();
                }

                s.data_criacao = (DateTime.Now).Date;
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

        public static bool Excluir(Sugesto c)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Sugesto cat = new Sugesto();

                cat = db.Sugestoes.Find(c.Id);
                db.Sugestoes.Remove(cat);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Sugesto Pesquisar(int id)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Sugesto cat = new Sugesto();
                //u.email = email;

                cat = db.Sugestoes.Find(id);
                return cat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Sugesto> Listar()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Sugestoes.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
