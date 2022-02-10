using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.DAL
{
    public class MasterRepository
    {
        static public List<User> GetMasters()
        {
            var masters = new List<User>();
            using (var context = new BeautySalonServiceDBEntities())
            {
                masters = context.Users.AsNoTracking().Select(u => u).Where(u => u.RoleID == 3).ToList();
            }
            return masters;
        }

        static public User GetSpecialMaster(long id)
        {
            var master = new User();
            using (var context = new BeautySalonServiceDBEntities())
            {
                master = context.Users.FirstOrDefault(m => m.ID == id && m.RoleID == 3);

            }
            return master;
        }

        //static public List<User> GetSpecialMaster1(long id)
        //{
        //    var masters = new List<User>();
        //    using (var context = new BeautySalonServiceDBEntities())
        //    {
        //        masters = context.Users.Join(context.BeautySalonServices,
        //            m => m.ID,
        //            bss => bss.MasterUserID,
        //            (m, bss) => new { user = m, beautySalonServices = bss }).Where(mbss => mbss.beautySalonServices.MasterUserID == id).Select(mbss => mbss.user).ToList();


        //    }
        //    return masters;
        //}

    }
}
