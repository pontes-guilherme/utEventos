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

    }
}
