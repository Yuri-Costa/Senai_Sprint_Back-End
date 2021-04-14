using Senai_Filmes_WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Filmes_WebApi.Interfaces
{
    /// <summary>
    /// Interface responsavel pelo Genero
    /// </summary>
    interface IGeneros
    {
        /// <summary>
        /// Listar todos Generos
        /// </summary>
        /// <returns>Todos os Generos</returns>
        List<GeneroDomain> ListarTodos();


        /// <summary>
        /// busca o genero atraves do id
        /// </summary>
        /// <param name="Id"> o id do genero buscado</param>
        /// <returns> Retorna o genero </returns>
        GeneroDomain BuscarPorId(int Id);


        /// <summary>
        /// cadastra um novo Genero
        /// </summary>
        /// <param name="NovoGenero">objeto "NovoGenero" com as informações de generos que serão cadastradas</param>
        void Cadastrar(GeneroDomain NovoGenero);

        /// <summary>
        /// Atualiza um genero existente passando o id pelo corpo da requisição
        /// </summary>
        /// <param name="Genero">genero com a nova atualização</param>
        void AtualizarIdCorpo(GeneroDomain Genero);

        /// <summary>
        /// Atualiza um genero existente passando o id pelo Url da requisição
        /// </summary>
        /// <param name="id">atualização do id do genero</param>
        /// <param name="Genero">atualização do genero</param>
        void AtualizarIdUrl(int id, GeneroDomain Genero);


        /// <summary>
        /// Deleta um Genero Existente
        /// </summary>
        /// <param name="id">id do genero que será deletado</param>
        void Delete(int id);

    }
}
