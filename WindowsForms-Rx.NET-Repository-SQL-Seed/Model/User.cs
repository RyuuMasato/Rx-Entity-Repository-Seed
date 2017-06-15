using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RxRepoSeed.Model
{
    public class User : IUser
    {
        public int UserID { get; set; }
        public string Username { get; set; }
    }
}
