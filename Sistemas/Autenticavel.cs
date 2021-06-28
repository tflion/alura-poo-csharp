using AluraBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraBank.Sistemas
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }

        public Autenticavel(double salario, string cpf) : base(cpf,salario)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
