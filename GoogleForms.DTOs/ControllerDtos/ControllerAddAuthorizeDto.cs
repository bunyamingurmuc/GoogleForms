using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs
{
    public class ControllerAddAuthorizeDto
    {
        public int FormId { get; set; }
        public string Email { get; set; }
    }
}
