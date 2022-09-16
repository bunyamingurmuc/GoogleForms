using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs.ControllerDtos
{
    public class ControllerRoleAssignListDto
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public bool Exist { get; set; }
    }
    public class ControllerRoleAssignSendDto
    {
        public List<ControllerRoleAssignListDto> Roles { get; set; }
        public int UserId { get; set; }
    }
}
