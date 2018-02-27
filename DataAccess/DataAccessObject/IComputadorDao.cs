using DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.DataAccessObject
{
    public interface IComputadorDao
    {
        void Inserir(Computador computador);
        void Deletar(int idComputador);
        void Atualizar(Computador computador);
        Computador Obter(int idComputador);
        List<Computador> ObterTodos();
    }
}
