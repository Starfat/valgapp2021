﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Valgapplikasjon.Models
{
    public class UserRolesViewModel
    {
        public string UserId { get; set; }
        public string Fornavn { get; set; }
        public string Etternavn { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Roles { get; set; }
    }
}