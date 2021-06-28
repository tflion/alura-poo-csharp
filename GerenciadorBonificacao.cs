using AluraBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraBank
{
    public class GerenciadorBonificacao
    {
        private double _totalBonificacao;
        
        public void Registar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
