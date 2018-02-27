using BusinessLayer.Interface;
using DataAccess.DataAccessObject;
using DataAccess.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Implementacao
{
    public class ComputadorBll : IComputadorBll
    {

        public readonly IComputadorDao _computadorDAO;

        public ComputadorBll(IComputadorDao computadorDao)
        {
            _computadorDAO = computadorDao;
        }

        /// <summary>
        /// Atualizar computador
        /// </summary>
        /// <param name="idComputador">Identificador do computador</param>
        /// <param name="computador">Objeto computador</param>
        public void Atualizar(int idComputador, Computador computador)
        {
            var computadorAtual = _computadorDAO.Obter(idComputador);
            computadorAtual.AutoAtualizar(computador);
            _computadorDAO.Atualizar(computadorAtual);
        }

        /// <summary>
        /// Excluir um computador
        /// </summary>
        /// <param name="idComputador">Identificador do computador</param>
        public void Deletar(int idComputador)
        {
            _computadorDAO.Deletar(idComputador);
        }

        /// <summary>
        /// Inserir um novo computador
        /// </summary>
        /// <param name="computador">Obejto no computador</param>
        public void Inserir(Computador computador)
        {
            _computadorDAO.Inserir(computador);
        }

        /// <summary>
        /// Obter um computador
        /// </summary>
        /// <param name="idComputador">Identificador do computador</param>
        /// <returns>Retorna computador encontrado</returns>
        public Computador Obter(int idComputador)
        {
            return _computadorDAO.Obter(idComputador);
        }

        /// <summary>
        /// Obtem todos os computadores
        /// </summary>
        /// <returns>Retorna uma lista de computadores</returns>
        public List<Computador> ObterTodos()
        {
            return _computadorDAO.ObterTodos();
        }
    }
}
