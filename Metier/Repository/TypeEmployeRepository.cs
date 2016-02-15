using ClassLibrary;
using DATA.Context;
using System.Collections.Generic;
using System.Linq;

namespace Metier.Repository
{
    public class TypeEmployeRepository
    {
        protected ProjetContext bd = new ProjetContext();


        public TypeEmploye findid(int id)
        {
            return bd.TypeEmploye.Find(id);
        }
        public void add(TypeEmploye type_)
        {   
                bd.TypeEmploye.Add(type_);
                bd.SaveChanges();  
        }
        public void update(TypeEmploye type_)
        {
           var query =  bd.TypeEmploye.Find(type_.TypeEmployeid);

                if(query != null)
                {
                    query.nomTypeEmploye = type_.nomTypeEmploye;
                }

                bd.SaveChanges();
        }
        public int delete(int id)
        {
            int i = bd.Employe.Where(p => p.typeEmployeId == id).Count();
            if (i == 0)
            {
                try
                {
                    var query = bd.TypeEmploye.Find(id);
                    bd.TypeEmploye.Remove(query);
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
        public IEnumerable<TypeEmploye> list()
        {
            IEnumerable<TypeEmploye> tp = bd.TypeEmploye;
             return tp;
        }
        

    }

    public class NatureColisRepository
    {
        protected ProjetContext bd = new ProjetContext();

        public NatureColis findid(int id)
        {
            return bd.Nuturecolis.Find(id);
        }
        public void add(NatureColis type_)
        {
            bd.Nuturecolis.Add(type_);
            bd.SaveChanges();
        }
        public void update(NatureColis type_)
        {
            var query = bd.Nuturecolis.Find(type_.NatureColisid);

            if (query != null)
            {
                query.NomNatureColis = type_.NomNatureColis;
            }
            bd.SaveChanges();
        }
        public int delete(int id)
        {
            int i = bd.Colis.Where(p => p.naturecolisid == id).Count();

            if (i == 0)
            {
                try
                {
                    var query = bd.Nuturecolis.Find(id);
                    bd.Nuturecolis.Remove(query);
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
        public IEnumerable<NatureColis> list()
        {
            IEnumerable<NatureColis> tp = bd.Nuturecolis;
            
            return tp;
        }

    }

    public class TypeColisRepository
    {
        protected ProjetContext bd = new ProjetContext();

        public TypeColis findid(int id)
        {
            return bd.Typecolis.Find(id);
        }
        public void add(TypeColis type_)
        {
            bd.Typecolis.Add(type_);
            bd.SaveChanges();
        }
        public void update(TypeColis type_)
        {
            var query = bd.Typecolis.Find(type_.TypeColisid);

            if (query != null)
            {
                query.nomTypeColis = type_.nomTypeColis;
            }
            bd.SaveChanges();
        }
        public int delete(int id)
        {
            int i = bd.Colis.Where(p => p.typecolisid == id).Count();

            if (i == 0)
            {
                try
                {
                    var query = bd.Typecolis.Find(id);
                    bd.Typecolis.Remove(query);
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
        public IEnumerable<TypeColis> list()
        {
            IEnumerable<TypeColis> tp = bd.Typecolis;
            
            return tp;
        }


    }

    public class VilleRepository
    {
        protected ProjetContext bd = new ProjetContext();

        public void add(Ville type_)
        {

            bd.Ville.Add(type_);
            bd.SaveChanges();
        }
        public void update(Ville type_)
        {
            var query = bd.Ville.Find(type_.Villeid);

            if (query != null)
            {
                query.NomVille = type_.NomVille;
            }

            bd.SaveChanges();
        }
        public int delete(int id)
        {
            int i = bd.Colis.Where(p => p.villeArriveColisid == id).Count();
            int k = bd.Colis.Where(p =>p.villeDepartColisid == id).Count();
            
            try
            {
                if (i == 0  && k==0)
                {
                    var query = bd.Ville.Find(id);
                    bd.Ville.Remove(query);
                    bd.SaveChanges();
                }
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        public IEnumerable<Ville> list()
        {
            IEnumerable<Ville> tp = bd.Ville;
            return tp;
        }
        public Ville findid(int id)
        {
            return bd.Ville.Find(id);     
        }
        
    }
    public class VoieTransmissionRepository
    {
        protected ProjetContext bd = new ProjetContext();


        public VoieTransmission findid(int id)
        {
            return bd.Voietransmission.Find(id);
        }
        public void add(VoieTransmission type_)
        {
            bd.Voietransmission.Add(type_);
            bd.SaveChanges();
        }
        public void update(VoieTransmission type_)
        {
            var query = bd.Voietransmission.Find(type_.VoieTransmissionid);

            if (query != null)
            {
                query.VoieTransmissionNom = type_.VoieTransmissionNom;
            }
            bd.SaveChanges();
        }
        public int delete(int id)
        {
            int i = bd.Colis.Where(p => p.voietransmissionid == id).Count();

            if (i == 0)
            {
                try
                {
                    var query = bd.Voietransmission.Find(id);
                    bd.Voietransmission.Remove(query);
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
        public IEnumerable<VoieTransmission> list()
        {
            IEnumerable<VoieTransmission> tp = bd.Voietransmission;
            
            return tp;
        }
    }
}
