using PrincipioISP.ComISP;

namespace PrincipioISP.SemISP
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDados();
        void EnviarEmail();
    }
}

