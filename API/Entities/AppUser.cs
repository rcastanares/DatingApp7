using System;
using System.Security.Cryptography.X509Certificates;

namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
    }
}
