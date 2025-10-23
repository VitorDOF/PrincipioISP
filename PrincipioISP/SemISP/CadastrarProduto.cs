namespace PrincipioISP.SemISP
{

    //Violando o ISP (Principio da Segregação por Interface)

    class CadastrarProduto : IPersistencia
    {
        public void ValidarDados()
        {
            Console.WriteLine("Valida Dados");
        }
        public void SalvarDados()
        {
            Console.WriteLine("Salva Dados");
        }

        public void EnviarEmail()
        {
            //Implementando uma funcionalidade que ela não vai usar
            
        }
    }
}
