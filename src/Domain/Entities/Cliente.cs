namespace Domain.Entities
{
    public class Cliente : Base
    {
        protected Cliente()
        {
        }

        public Cliente(string nome,
            string telefone,
            string cep,
            string cidade, 
            string estado)
                : this()
        {
            Nome = nome;
            Telefone = telefone;
            Cep = cep;
            Cidade = cidade;
            Estado = estado;
        }

        public string Nome { get; private set; }
        public string Telefone { get; private set; }
        public string Cep { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        //Navigation properties
        public IEnumerable<Pedido>? Pedidos { get; private set; }
    }
}
