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
        public int Contra {  get; set; }

        public Usuario(string nickName, int contra)
        {
            this.NickName = nickName;
            this.Contra = contra;
        }

        public Usuario()
        {
        }
    }
}
