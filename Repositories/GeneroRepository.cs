using api_filmes_senai.Context;
using api_filmes_senai.Domais;
using api_filmes_senai.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace api_filmes_senai.Repositories
{
    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// Ou seja. vamos umplementar os métodos, toda a lógica dos métodos
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {

        /// <summary>
        /// Variável privada e somente leitura 
        /// que "guarda" os dados no contexto
        /// </summary>
        private readonly Filmes_Context _context;
        //private object _generoReposirory;

        /// <summary>
        /// Construtor do repositorio
        /// Aqui, todas vez que o construtor for chamado,
        /// os dados do contexro estarão disponíveis
        /// </summary>
        /// <param name="contexto">Dados do contexto</param>
        public GeneroRepository(Filmes_Context contexto)
        {
            _context = contexto;
        }

        public void Atualizar(Guid id, Genero genero)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null)
                {
                    generoBuscado.Nome = genero.Nome;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Genero BuscarPorId(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                return generoBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                // adicionar um novo genero na tabela Generos(DB)
                _context.Genero.Add(novoGenero);

                //apos o cadastro salvar as altera;oes 
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;

                if (generoBuscado != null)
                {
                    _context.Genero.Remove(generoBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Genero id)
        {
            try
            {
                Genero generoBuscado = _context.Genero.Find(id)!;
                if (generoBuscado != null)
                {
                    _context.Genero.Remove(generoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> listaGeneros = _context.Genero.ToList();

                return listaGeneros;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}