﻿namespace PrincipioISP.SemISP
{
    
    class CadastrarCliente : IPersistencia
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
            Console.WriteLine("Envia Email");

        }

    }
}
