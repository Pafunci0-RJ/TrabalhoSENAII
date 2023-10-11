namespace Perfumes.Models
{
    public class Venda
    {
        public Guid VendaId { get; set; }
        public int Nota { get; set; }
        public DateTime Horario { get; set; }


        public Guid ClienteId { get; set; }
        public Cliente? Clientes { get; set;}


        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

    }
}
