using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleForms.DTOs
{
    public class ControllerCreateRoleDto
    {
        [Required(ErrorMessage = "Ad alanı gereklidir")]
        public string Name { get; set; }
    }
}
