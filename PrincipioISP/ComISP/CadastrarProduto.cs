namespace PrincipioISP.ComISP
{
    //Com o ISP
    class CadastrarProduto : IPersistencia
    {
        public void SalvarDataBase()
        {
            Console.WriteLine("Salva Dados");
        }
        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados");
        }
    }
}
