
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Bases
{
    public class UserBase : EntityBase
    {
        public IdentityUser User { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
