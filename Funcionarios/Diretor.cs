using AluraBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraBank.Funcionarios
{
    public class Diretor : Autenticavel
    {

        public Diretor(string cpf) : base(cpf, 5000)
        {

        }
 
        public override double GetBonificacao()
        {
            return Salario *= 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
