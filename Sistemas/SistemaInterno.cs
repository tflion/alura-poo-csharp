﻿using AluraBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-vindo ao sistema!");
                return true;
            }else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
