using ClassLibrary;
using DATA.Context;
using System.Collections.Generic;
using System.Linq;

namespace Metier.Repository
{
    public class ColisRepository
    {
        
        protected ProjetContext bd = new ProjetContext();

        public void add(Colis type_)
        {
            bd.Colis.Add(type_);
            bd.SaveChanges();
        }
        public void update(Colis type_)
        {
            var query = bd.Colis.Find(type_.Colisid);

            if (query != null)
            {
                query.adresseDestinaraire = type_.adresseDestinaraire;
                query.clientid = type_.clientid;
                query.dateArriveColis = type_.dateArriveColis;
                query.dateDepartColis = type_.dateDepartColis;
                query.detailsColis = type_.detailsColis;
                query.etatColis = type_.etatColis;
                query.naturecolisid = type_.naturecolisid;
                query.nomDestinateire = type_.nomDestinateire;
                query.prixColis = type_.prixColis;
                query.telDestinataire = type_.telDestinataire;
                query.typecolisid = type_.typecolisid;
                query.villeArriveColisid = type_.villeArriveColisid;
                query.villeDepartColisid = type_.villeDepartColisid;
                query.voietransmissionid = type_.voietransmissionid;
                bd.SaveChanges();
            }
            
        }
        public void delete(int id)
        {
            try
                {
                    var query = bd.Colis.Find(id);
                    bd.Colis.Remove(query);
                    bd.SaveChanges();
 
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        public List<Colis> list()
        {
            var tp = bd.Colis;
            List < Colis > lc = new List<Colis>();
            var bd1 = new ProjetContext();
            foreach (var item in tp)
            {
                //var v = bd.Ville.Where(p => p.Villeid == item.villeDepartColisid).FirstOrDefault();
                var v = bd1.Ville.Find(item.villeDepartColisid);
                item.villeDepartColis = v;
                 v = bd1.Ville.Find(item.villeArriveColisid);
                item.villeArriveColis = v;
                lc.Add(item);
            }
            return lc;
        }
        public Colis findid(int id)
        {
            var bd1 = new ProjetContext();

            Colis c = bd.Colis.Find(id);
            if (c != null)
            {
                var v = bd1.Ville.Find(c.villeDepartColisid);
                c.villeDepartColis = v;

                v = bd1.Ville.Find(c.villeArriveColisid);
                c.villeArriveColis = v;
                return c;
            }
            else {
                c = new Colis();
                c.Colisid = -1;
                return c;
            }
        }
        
      /*  public IEnumerable<Colis> findbyvillearrive(string ville)
        {
            IEnumerable<Colis> c = bd.Colis.Where(p => p.villeArriveColis == ville).FirstOrDefault();
            
            return c;
        }*/

    }
}
