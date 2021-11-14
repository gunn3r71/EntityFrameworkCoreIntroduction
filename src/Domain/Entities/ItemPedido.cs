namespace Domain.Entities
{
    public class ItemPedido : Base
    {
        protected ItemPedido()
        {
        }

        public ItemPedido(Guid pedidoId,
            Guid produtoId, 
            int quantidade, 
            decimal valor,
            int? desconto)
                : this()
        {
            PedidoId = pedidoId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
            Valor = valor;
            Desconto = desconto;
        }

        public Guid PedidoId { get; private set; }
        public Guid ProdutoId { get; private set; }
        public int Quantidade { get; private set; }
        public decimal Valor { get; private set; }
        public int? Desconto { get; private set; }

        //Navigation properties
        public Produto Produto { get; private set; }
        public Pedido Pedido { get; private set; }

    }
}
