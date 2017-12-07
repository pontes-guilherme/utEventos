using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public class pnCheckin
    {
        public static bool Inserir(int evento, string usuario)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Checkin i = new Checkin();

                /*Evento e = db.Eventoes.Find(evento);
                Usuario u = db.Usuarios.Find(usuario);
                i.Evento = e;
                i.Usuario = u;
                i.notificado = true;*/

                i.Id = getLasId();
                i.data_criacao = DateTime.Now;
                i.EventoId = evento;
                i.Usuario_email = usuario;
                
                db.Checkin.Add(i);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Checkin Pesquisar(int id)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Checkin i = new Checkin();

                i = db.Checkin.Find(id);
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Checkin Pesquisar(int evento, string usuario)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Checkin i = new Checkin();

                i = db.Checkin.DefaultIfEmpty(null).FirstOrDefault(x => (x.Usuario_email == usuario) && (x.EventoId == evento));
                return i;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Checkin i)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Checkin inscr = new Checkin();

                inscr = db.Checkin.Find(i.Id);
                db.Checkin.Remove(inscr);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Checkin> Listar()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Checkin.ToList());
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
                int id = db.Checkin.Max(p => p.Id);
                //Console.WriteLine(e.Id.ToString());
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
