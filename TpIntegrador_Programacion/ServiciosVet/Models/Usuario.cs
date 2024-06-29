using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosVet.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public string Contranueva { get; set; }

        public Usuario(string nickName, string contranueva)
        {
            this.NickName = nickName;
            this.Contranueva = contranueva;
        }

        public Usuario()
        {
        }
    }
}