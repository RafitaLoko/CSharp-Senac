namespace OrientacaoAObjeto
{
    internal class Pedido
    {
        public Pedido(Pessoa cliente, double valorTotal, DateTime dataDoServico, bool isPago) 
        {
            Cliente = cliente;
            ValorTotal = valorTotal;
            DataDoServico = dataDoServico;
            IsPago = isPago;
        }
        public Pedido(Pessoa cliente, DateTime dataDoServico, double valorTotal, string observacao) 
        {
            Cliente = cliente;
            DataDoServico = dataDoServico;
            ValorTotal = valorTotal;
            Observacao = observacao;    
        }



        public Pessoa Cliente { get; private set; }

        public IList<string> Produto { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataDoServico { get; private set; }

        public bool IsPago { get; private set; }

        public string Observacao { get; set; }
    }

}
