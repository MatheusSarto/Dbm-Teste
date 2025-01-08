using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dbm.Core.Requests.Cliente
{
    public class UpdateCliente : Request
    {
        [Required(ErrorMessage = "Campo obrigatório")]
        public long ClienteId { get; set; } 
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Email { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Telefone { get; set; } = string.Empty;
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Endereco { get; set; } = string.Empty;
    }
}
