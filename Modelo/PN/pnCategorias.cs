using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.DAO;

namespace Modelo.PN
{
    public static class pnCategorias
    {

        public static bool Inserir(Categoria c)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();

                db.Categorias.Add(c);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Alterar(Categoria c)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Categoria cat = new Categoria();
                cat = db.Categorias.Find(c.nome);

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Categoria Pesquisar(string nome)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Categoria cat = new Categoria();
                //u.email = email;

                cat = db.Categorias.Find(nome);
                return cat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Categoria c)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Categoria cat = new Categoria();

                cat = db.Categorias.Find(c.nome);
                db.Categorias.Remove(cat);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Categoria> Listar()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Categorias.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
