

using GoogleForms.Entities.Interface;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.Entities.UserEntities
{
    public class AppUser: IdentityUser<int> 
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public List<Form>? Forms { get; set; }

    }
}
