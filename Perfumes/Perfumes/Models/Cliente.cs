using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Perfumes.Models
{
    public class Cliente
    {
        public Guid ClienteId { get; set; }
        public string Nome { get; set; }
        [DisplayName("Endereço")]
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public int Cpf { get; set;
        }
        public string Email { get; set; }
        public DateTime Nascimento { get; set; }

        public IEnumerable<Venda>? Vendas { get; set; }
    }
}
