
using ClassLibrary;
using DATA.Context;
using System.Collections.Generic;
using System.Linq;

namespace Metier.Repository
{
    public class ClientRepository
    {
      
        protected ProjetContext bd = new ProjetContext();

        public void add(Client type_)
        {
            bd.Client.Add(type_);
            bd.SaveChanges();
        }
        public void update(Client type_)
        {
            var query = bd.Client.Find(type_.Clientid);

            if (query != null)
            {
                query.nomClient = type_.nomClient;
                query.adresseClient = type_.adresseClient;
                query.prenomClient = type_.prenomClient;
                query.telClient = type_.telClient;
                query.emailClient = type_.emailClient;
                query.faxClient = type_.faxClient;

                bd.SaveChanges();
            }
            
        }
        public int delete(int id)
        {
            int i = bd.Colis.Where(p => p.clientid == id).Count();

            if (i == 0)
            {
                try
                {
                    var query = bd.Client.Find(id);
                    bd.Client.Remove(query);
                    bd.SaveChanges();
                    return 0;
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            else
            {
                return i;
            }
    }
        public IEnumerable<Client> list()
        {
            IEnumerable<Client> tp = bd.Client;
            
            return tp;
        }
        public Client findnom(string nom)
        {
            Client c =bd.Client.Where(p => p.nomClient == nom).FirstOrDefault();

            return c;
        }
        public Client findid(int id)
        {
            Client c = bd.Client.Find(id);

            return c;
        }

        public Client findprenom(string nom)
        {
            Client c = bd.Client.Where(p => p.prenomClient == nom).FirstOrDefault();

            return c;
        }
        public IEnumerable<Colis> findcolis(int id)
        {
            IEnumerable<Colis> c = bd.Colis.Where(p => p.clientid == id);
            
            return c;
        }

    }
}
