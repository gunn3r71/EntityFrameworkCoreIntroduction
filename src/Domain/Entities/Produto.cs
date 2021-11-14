using Domain.Enuns;

namespace Domain.Entities
{
    public class Produto : Base
    {
        protected Produto()
        {
        }

        public Produto(string codigoBarras, 
            string descricao,
            decimal valor,
            TipoProduto tipo, 
            bool status)
                : this()
        {
            CodigoBarras = codigoBarras;
            Descricao = descricao;
            Valor = valor;
            Tipo = tipo;
            Status = status;
        }

        public string CodigoBarras { get; private set; }
        public string Descricao { get; private set; }
        public decimal Valor { get; private set; }
        public TipoProduto Tipo { get; private set; }
        public bool Status { get; private set; }
    }
}
