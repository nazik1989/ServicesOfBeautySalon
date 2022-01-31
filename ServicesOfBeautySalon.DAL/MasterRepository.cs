using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicesOfBeautySalon.DAL
{
    public class MasterRepository
    {
        static public List<User> getMasters()
        {
            var masters = new List<User>();
            using (var context = new BeautySalonServiceDBEntities())
            {
                masters = context.Users.AsNoTracking().Select(u => u).Where(u => u.RoleID == 3).ToList();
            }
            return masters;
        } 

    }
}
