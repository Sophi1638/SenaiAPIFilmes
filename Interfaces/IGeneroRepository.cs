using api_filmes_senai.Domais;

namespace api_filmes_senai.Interfaces
{
    /// <summary>
    /// Inter face para genero : vontrato 
    /// todas as classes que herdar(Implementar) esse inrfave,
    /// devera implementar todos os metodos definidos aqui dentro
    /// </summary>
    public interface IGeneroRepository
    {
        /// CRUD : Metodos
        /// C : criate : cadastrar um novo objeto 
        /// R : Read : Listar todos os objetos
        /// U : Update : alterar um objeto
        /// D : Delete : Deleto ou excluo um objeto

        ///Metodo = TipoDeRetorno NomeDoMetodo(Argumentos)

        void Cadastrar(Genero novoGenero);

        List<Genero> Listar();

        void Atualizar(Genero id, Genero genero);

        void Deletar(Genero id);

        Genero BuscarPorId(Guid id);
        void Deletar(Guid id);
        void Atualizar(Guid id, Genero genero);
    }
}
