namespace Perfumes.Models
{
    public class Compra
    {
        public Guid CompraId { get; set; }
        public int Nota { get; set; }
        public DateTime Horario { get; set; }

        public string Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
    }
}
