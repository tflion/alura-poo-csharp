using AluraBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraBank.Funcionarios
{
    class GerenteDeConta : Autenticavel
    {

        public GerenteDeConta(string cpf) : base(cpf, 4000)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }
    }
}
