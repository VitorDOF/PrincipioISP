namespace PrincipioISP.ComISP
{
    internal class CadastrarCliente : IPersistencia, IMensagemEmail
    {
        public void SalvarDataBase()
        {
            Console.WriteLine("Salva Dados");
        }
        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados");
        }
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar Email");
        }
    }
}
