using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class LoginDto
    {
        public string UserName { get; set; }
        
        public string Password { get; set; }
    }
}