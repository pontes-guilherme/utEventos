using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Modelo.PN
{
    public static class pnDisciplinas
    {
      
        public static Disciplina Pesquisar(string nome)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Disciplina d = new DAO.Disciplina ();

                d = db.Disciplinas.Find(nome);
                return d;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Disciplina> Listar()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Disciplinas.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Inserir(Disciplina s, dbEventosEntities db)
        {
            try
            {
                if (db == null)
                {
                    db = new dbEventosEntities();
                }

                if (Pesquisar(s.nome) == null)
                {
                    Disciplina d = new Disciplina();
                    d.nome = s.nome;
                    db.Disciplinas.Add(d);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Disciplina c)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Disciplina cat = new Disciplina();

                cat = db.Disciplinas.Find(c.nome);
                //foreach(Evento e in cat.Eventos)
                //{
                //    e.Disciplina_nome = cat.nome;
                //    e.Disciplina = null;
                //}

                db.Disciplinas.Remove(cat);
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
