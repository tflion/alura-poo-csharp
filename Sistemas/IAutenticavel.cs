﻿using AluraBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace AluraBank.Sistemas
{
    public interface IAutenticavel

    {
        bool Autenticar(string senha);
    }
}
