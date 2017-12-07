using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Modelo.PN
{
    public static class pnEventos
    {
        //public static String GetTimestamp(DateTime value)
        //{
        //    return value.ToString("yyyyMMddHHmmssffff");
        //}

        public static bool Inserir(Evento e, dbEventosEntities db)
        {
            try
            {
                if (db == null)
                {
                    db = new dbEventosEntities();
                }
                e.Id = getLasId();
                e.data_criacao = DateTime.Now;
                db.Eventoes.Add(e);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Alterar(Evento e, dbEventosEntities db)
        {
            try
            {
                if (db == null) { 
                    db = new dbEventosEntities();
                }
                Evento evento = new Evento();
                evento = db.Eventoes.Find(e.Id);

                evento.nome = e.nome;
                evento.data_inicio = e.data_inicio;
                evento.data_fim = e.data_fim;
                evento.importante = e.importante;
                evento.Categoria_nome = e.Categoria_nome;
                evento.escopo = e.escopo;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Evento> Listar(string email_usuario="", string tipo = "")
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                List<Evento> eventos = db.Eventoes.Where(x => x.escopo != "Pessoal").ToList();

                if (email_usuario != "")
                {
                    List<Evento> pessoais = db.Eventoes.Where(x => x.escopo == "Pessoal" && x.criador == email_usuario).ToList();
                    eventos.AddRange(pessoais);

                    if (tipo == "atuais")
                    {
                        eventos = eventos.Where(x => DateTime.Compare(x.data_fim, DateTime.Now) > 0).ToList();
                    }
                    else if (tipo == "passados")
                    {
                        eventos = eventos.Where(x => DateTime.Compare(x.data_fim, DateTime.Now) <= 0).ToList();
                    }
                }
                
                return (eventos);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Evento> ListarAnteriores()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Eventoes.Where(ev => ev.data_fim < (DateTime.Now)).ToList());
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
                int id = db.Eventoes.Max(p => p.Id);
                //Console.WriteLine(e.Id.ToString());
                if (id >= 0)
                {
                    return id + 1;
                }
            } catch (Exception)
            {
                return 0;
            }

            return 0;
        }

        public static Evento Pesquisar(int id)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Evento u = new Evento();

                u = db.Eventoes.Find(id);
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Evento u)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Evento e = new Evento();

                e = db.Eventoes.Find(u.Id);
                db.Eventoes.Remove(e);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
