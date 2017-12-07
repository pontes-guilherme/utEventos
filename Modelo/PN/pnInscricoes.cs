using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public class pnInscricoes
    {
        public static bool Inserir(int evento, string usuario)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Inscricao i = new Inscricao();

                /*Evento e = db.Eventoes.Find(evento);
                Usuario u = db.Usuarios.Find(usuario);
                i.Evento = e;
                i.Usuario = u;
                i.notificado = true;*/

                i.Id = getLasId();
                i.EventoId = evento;
                i.Usuario_email = usuario;
                
                db.Inscricoes.Add(i);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Inscricao Pesquisar(int id)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Inscricao i = new Inscricao();

                i = db.Inscricoes.Find(id);
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Inscricao Pesquisar(int evento, string usuario)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Inscricao i = new Inscricao();

                i = db.Inscricoes.DefaultIfEmpty(null).FirstOrDefault(x => (x.Usuario_email == usuario) && (x.EventoId == evento));
                return i;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Inscricao i)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Inscricao inscr = new Inscricao();

                inscr = db.Inscricoes.Find(i.Id);
                db.Inscricoes.Remove(inscr);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Inscricao> Listar()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Inscricoes.ToList());
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
                int id = db.Inscricoes.Max(p => p.Id);
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
