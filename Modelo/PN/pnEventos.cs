﻿using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modelo.PN
{
    public static class pnEventos
    {
        public static bool Inserir(Evento e)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                e.Id = getLasId();
                //e.data_criacao = GetTimestamp(DateTime.Now);
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
    }
}
