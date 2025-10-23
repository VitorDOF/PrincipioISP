namespace PrincipioISP.ComISP
{
    //Com o ISP
    class CadastrarProduto : IValidaDados, ISalvaDados
    {
        public void SalvarDados()
        {
            Console.WriteLine("Salva Dados");
        }
        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados");
        }
    }
}
