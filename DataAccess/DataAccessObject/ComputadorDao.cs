using DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.DataAccessObject
{
    public class ComputadorDao : IComputadorDao
    {

        private readonly BancoDeDados _bancoDeDados;

        public ComputadorDao(BancoDeDados bancoDeDados)
        {
            _bancoDeDados = bancoDeDados;
        }

        public void Inserir(Computador computador)
        {
            _bancoDeDados.Computadores.Add(computador);
            _bancoDeDados.SaveChanges();
        }

        public void Atualizar(Computador computador)
        {
            _bancoDeDados.Computadores.Update(computador);
            _bancoDeDados.SaveChanges();
        }

        public void Deletar(int idComputador)
        {
            var computador = _bancoDeDados.Computadores.Find(idComputador);
            _bancoDeDados.Computadores.Remove(computador);
            _bancoDeDados.SaveChanges();
        }

        public Computador Obter(int idComputador)
        {
            return _bancoDeDados.Computadores.Find(idComputador);
        }

        public List<Computador> ObterTodos()
        {
            return _bancoDeDados.Computadores.ToList();
        }
    }
}
