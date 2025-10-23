namespace PrincipioISP.ComISP
{
    internal class CadastrarCliente : IValidaDados, ISalvaDados, IMensagemEmail
    {
        public void SalvarDados()
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
