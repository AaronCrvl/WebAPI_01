
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_01.Models
{
    public class Usuario
    {
        public long Id 
        { 
            get { return Id; }
            set { Id = value; } 
        }
        public string Nome 
        {
            get { return Nome; }
            set { Nome = value; }
        }
        public string Senha 
        {
            get { return Senha; }
            set { Senha = value; }
        }
        public string Email 
        {
            get { return Email; }
            set { Email = value; }
        }
    }
}
