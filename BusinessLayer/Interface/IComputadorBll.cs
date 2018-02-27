using DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Interface
{
    public interface IComputadorBll
    {
        void Inserir(Computador computador);
        void Deletar(int idComputador);
        void Atualizar(int idComputador, Computador computador);
        Computador Obter(int idComputador);
        List<Computador> ObterTodos();
    }
}
