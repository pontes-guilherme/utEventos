using Modelo.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Modelo.PN
{
    public static class pnUsuarios
    {
        public static bool Inserir(Usuario u)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();

                u.senha = CreateMD5(u.senha);
                
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
                if (u.senha != "")
                {
                    user.senha = CreateMD5(u.senha);
                }
                user.data_nascimento = u.data_nascimento;

                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //PROBLEMA
        public static Usuario Pesquisar(string email)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Usuario user = new Usuario();
                //u.email = email;

                user = db.Usuarios.Find(email);
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static bool Excluir(Usuario u)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Usuario user = new Usuario();

                user = db.Usuarios.Find(u.email);
                db.Usuarios.Remove(user);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Usuario> Listar()
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                return (db.Usuarios.ToList());
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static bool Autenticar(string email, string senha)
        {
            try
            {
                dbEventosEntities db = new dbEventosEntities();
                Usuario user = new Usuario();

                user = db.Usuarios.Find(email);
                
                if(user != null && user.senha == CreateMD5(senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        public static bool sendMail(Usuario u)
        {

           

            MailMessage mail = new MailMessage("suporte.uteventos@gmail.com", "guilherme.2015@alunos.utfpr.edu.br");
            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            client.Credentials = new System.Net.NetworkCredential("suporte.uteventos@gmail.com", "sodargetni");
            client.EnableSsl = true;
            mail.Subject = "Recuperação de senha";
            mail.IsBodyHtml = true;
            string r = "localhost:50699/Account/AlterarSenha?email=" + u.email.ToString() + "&codigo=" + CreateMD5(u.email.ToString() + u.senha.ToString());

            string link = "<a href='" + r + "'>clique aqui para recuperar</a>";

            mail.Body = "Link para recuperação: " + link;
           
            client.Send(mail);


            return true;
        }

    }
}
