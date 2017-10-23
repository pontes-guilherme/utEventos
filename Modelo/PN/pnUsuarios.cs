using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.PN
{
    public static class pnUsuarios
    {
        public static bool Inserir(Usuario u)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();

                db.Usuarios.Add(u);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Alterar(Usuario u)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Usuario user = new Usuario();
                user = db.Usuarios.Find(u.email);

                user.nome = u.nome;
                user.senha = u.senha;
                user.data_nascimento = u.data_nascimento;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static Usuario Pesquisar(string email)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Usuario u = new Usuario();

                u = db.Usuarios.Find(email);
                return u;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
