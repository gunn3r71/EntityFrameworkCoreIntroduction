using Domain.Enuns;

namespace Domain.Entities
{
    public class Pedido : Base
    {
        public Pedido(Guid clienteId,
            DateTime iniciadoEm, 
            DateTime finalizadoEm, 
            TipoFrete tipoFrete,
            Status status,
            string observacao)
        {
            ClienteId = clienteId;
            IniciadoEm = iniciadoEm;
            FinalizadoEm = finalizadoEm;
            TipoFrete = tipoFrete;
            Status = status;
            Observacao = observacao;
        }

        public Guid ClienteId { get; private set; }
        public DateTime IniciadoEm { get; private set; }
        public DateTime FinalizadoEm { get; private set; }
        public TipoFrete TipoFrete { get; private set; }
        public Status Status { get; private set; }
        public string Observacao { get; private set; }


        //Navigation Properties
        public IEnumerable<ItemPedido> Itens { get; private set; }
        public Cliente Cliente { get; private set; }
    }
}
