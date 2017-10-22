using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class pnEventos
    {
        public static bool Inserir(Evento e)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                
                db.Eventoes.Add(e);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Alterar(Evento e)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Evento evento = new Evento();
                evento = db.Eventoes.Find(e.Id);

                evento.nome = e.nome;
                evento.data_inicio = e.data_inicio;
                evento.data_fim = e.data_fim;

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
