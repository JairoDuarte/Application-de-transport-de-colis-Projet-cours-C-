using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;
using System.Linq;
using AppWeb.ViewModels;

namespace AppWeb.ViewModels
{
    // Vous pouvez ajouter des données de profil pour l'utilisateur en ajoutant plus de propriétés à votre classe ApplicationUser ; consultez http://go.microsoft.com/fwlink/?LinkID=317594 pour en savoir davantage.
    public class ApplicationUser : IdentityUser
    {
        public string motpasse { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {

            // Notez qu'authenticationType doit correspondre à l'élément défini dans CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Ajouter les revendications personnalisées de l’utilisateur ici
            return userIdentity;
        }
    }

  
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("conposte", throwIfV1Schema: false)
        {
        }
        
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
    

    public class UserRolesRepository
    {
        public UserManager<ApplicationUser> UserManager { get; set; }
        public ApplicationDbContext context { get; set; }
        ApplicationDbContext bd = new ApplicationDbContext();

        public UserRolesRepository()
        {
            context = new ApplicationDbContext();
            UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

        }

        public void delete(string idu,string rnom)
        {
            try
            {
                UserManager.RemoveFromRole(idu, rnom);
                bd.SaveChanges();
                context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        
        public void update(UserViewModel item)
        {
            ApplicationUser it = bd.Users.Find(item.Userid);
            it.Email = item.emailUser;
            it.UserName = item.nomUser;
            it.PasswordHash = item.motpasseUser;
            bd.SaveChanges();
        }
        public void add(string id,string item)
        {
            IdentityRole it = bd.Roles.Find(item);
            UserManager.AddToRole(id, it.Name);
            context.SaveChanges();
            bd.SaveChanges();
        }
    }

    public  class RoleRepository
    {
        ApplicationDbContext bd = new ApplicationDbContext();

        public void add(RoleViewModels rl)
        {
            IdentityRole r = new IdentityRole();
            r.Id = rl.Id;
            r.Name = rl.Nom;
            bd.Roles.Add(r);
            bd.SaveChanges();

        }

        public int delete(string id)
        {
            try
            {

                var query = bd.Roles.Find(id);
                bd.Roles.Remove(query);
                bd.SaveChanges();
                return 0;
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<RoleViewModels> list()
        {
            var t = bd.Roles;
            List<RoleViewModels> tp = new List<RoleViewModels>();

            foreach (var item in t)
            {
                var u = new RoleViewModels
                {
                    Id = item.Id,
                    Nom = item.Name
                };
                tp.Add(u);
            }

            return tp;
        }
        public RoleViewModels findid(string id)
        {
            var item = bd.Roles.Find(id);
            var u = new RoleViewModels
            {
                Id = item.Id,
                Nom = item.Name, 
            };

            return u;

        }
        public void update(RoleViewModels item)
        {
            var it = bd.Roles.Find(item.Id);
            it.Name= item.Nom;
             bd.SaveChanges();
        }

    }

    public class UserRepository
    {
        ApplicationDbContext bd = new ApplicationDbContext();
        ApplicationDbContext bd1 = new ApplicationDbContext();
        public UserViewModel findroles(string id)
        {
            var query = bd.Users.Find(id);
            IEnumerable<IdentityUserRole> t =    query.Roles;
           
                UserViewModel us = new UserViewModel();
            us.Userid = query.Id;
            us.nomUser = query.UserName;
            us.Roles = new List<RoleViewModels>();
                bd.SaveChanges();
            RoleViewModels rl;
            foreach (var item in t)
            { rl= new RoleViewModels();
                rl.Id = item.RoleId;
                rl.Nom = bd1.Roles.Find(item.RoleId).Name;

                us.Roles.Add(rl);
            }
            bd1.SaveChanges();
            return us;
        }

        public void delete(string id)
        {
            try
            {
                var query = bd.Users.Find(id);
                bd.Users.Remove(query);
                bd.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        public List<UserViewModel> list()
        {
            IEnumerable<ApplicationUser> t = bd.Users;
            List<UserViewModel> tp = new List<UserViewModel>();

            foreach (var item in t)
            {
                var u = new UserViewModel
                {
                    emailUser = item.Email,
                    nomUser = item.UserName,
                    motpasseUser = item.motpasse,
                    Userid= item.Id
                };
                tp.Add(u);
            }

            return tp;
        }
        public UserViewModel findnom(string nom)
        {
            ApplicationUser item = (ApplicationUser)bd.Users.Where(p => p.UserName == nom);
            var u = new UserViewModel
            {
                emailUser = item.Email,
                nomUser = item.UserName,
                motpasseUser = item.PasswordHash,
                Userid = item.Id
            };
            return u;
        }
        public UserViewModel findid(string id)
        {
            ApplicationUser item = bd.Users.Find(id);
            var u = new UserViewModel
            {
                emailUser = item.Email,
                nomUser = item.UserName,
                motpasseUser = item.PasswordHash,
                Userid = item.Id
            };

            return u;

        }
        public void update(UserViewModel item)
        {
            ApplicationUser it = bd.Users.Find(item.Userid);
            it.Email = item.emailUser;
            it.UserName = item.nomUser;
            it.PasswordHash = item.motpasseUser;
            bd.SaveChanges();
        }
        public void passupdate(string id,string item)
        {
            ApplicationUser it = bd.Users.Find(id);
            it.motpasse = item;
            bd.SaveChanges();
        }
    }

  
}