using ClassLibrary;
using DATA.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Repository
{
   public class UserRepository
    {/*
        protected ProjetContext bd = new ProjetContext();

        public void add(User type_)
        {
            bd.User.Add(type_);
            bd.SaveChanges();
        }
        public void update(User type_)
        {
            var query = bd.User.Find(type_.Userid);

            if (query != null)
            {
                query.emailUser = type_.emailUser;
                query.typeUser = type_.typeUser;
                query.motpasseUser = type_.motpasseUser;
                query.nomUser = type_.nomUser;
                bd.SaveChanges();
            }
        }
        public void delete(int id)
        {
                try
                {
                    var query = bd.User.Find(id);
                    bd.User.Remove(query);
                    bd.SaveChanges();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        public IEnumerable<User> list()
        {
            IEnumerable<User> tp = bd.User;

            return tp;
        }
        public User findid(int id)
        {
            User c = bd.User.Find(id);

            return c;
        }
        public User findnom(string nom)
        {
            User c = (User)bd.User.Where(p => p.nomUser == nom);

            return c;
        }
        public User findemail(string email)
        {
            User c = (User)bd.User.Where(p => p.emailUser == email);

            return c;
        }
        */
    }
}
