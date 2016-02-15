using ClassLibrary;
using DATA.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metier.Repository
{
    public class EmployeRepository
    {
        protected ProjetContext bd = new ProjetContext();

        public void add(Employe type_)
        {
            bd.Employe.Add(type_);
            bd.SaveChanges();
        }
        public void update(Employe type_)
        {
            var query = bd.Employe.Find(type_.Employeid);

            if (query != null)
            {
                query.nomEmploye = type_.nomEmploye;
                query.prenomEmploye = type_.prenomEmploye;
                query.telEmploye = type_.telEmploye;
                query.adresseEmploye = type_.adresseEmploye;
                query.emailEmploye = type_.emailEmploye;
                query.typeEmployeId = type_.typeEmployeId;
                bd.SaveChanges();
            }
            
        }
        public void delete(int id)
        {
            try
                {
                    var query = bd.Employe.Find(id);
                    bd.Employe.Remove(query);
                    bd.SaveChanges();
                }
                catch (System.Exception)
                {
                    throw;
                }
         }
        public Employe findid(int id)
        {
            Employe c = bd.Employe.Find(id);

            return c;
        }
        public IEnumerable<Employe> list()
        {
            IEnumerable<Employe> tp = bd.Employe;
            
            return tp;
        }
        public IEnumerable<Employe> findnom(string nom)
        {
            IEnumerable<Employe> c = bd.Employe.Where(p => p.nomEmploye.Contains(nom)); //.FirstOrDefault();

            return c;
        }
        public Employe findprenom(string nom)
        {
            Employe c = bd.Employe.Where(p => p.prenomEmploye == nom).FirstOrDefault();

            return c;
        }
        public IEnumerable<Employe> findtype(int id)
        {
            IEnumerable<Employe> tp = bd.Employe.Where(p=>p.typeEmployeId==id);

            return tp;
        }


    }
}
