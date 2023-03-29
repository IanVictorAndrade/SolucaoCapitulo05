﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_Reajuste_Salarial
{
    class RepositorioFuncionario
    {
        private IList<Funcionario> funcionarios = new BindingList<Funcionario>();
        public void Inserir(Funcionario funcionario)
        {
            funcionarios.Add(funcionario);
        }
        public IList<Funcionario> ObterTodos()
        {
            return this.funcionarios;
        }
    }
}
