using AutoMapper;
using GoogleForms.BLL.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.BLL.Helper
{
    public static class ProfileHelper
    {
        public static List<Profile> GetProfiles()
        {

            return new List<Profile>
            {
                new Profiles()
            };
        }
    }
}

