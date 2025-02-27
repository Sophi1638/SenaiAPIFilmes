using api_filmes_senai.Context;
using api_filmes_senai.Domais;
using api_filmes_senai.Interfaces;

namespace api_filmes_senai.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly Filmes_Context _context;

        public FilmeRepository(Filmes_Context context)
        public FilmeRepository(Filmes_Context context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, Filme filme)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id)!;

                if (filmeBuscado != null)
                {
                    filmeBuscado.Titulo = filme.Titulo;
                    filmeBuscado.IdGenero = filme.IdGenero;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public Filme BuscarPorId(Guid id)
        {
            try
            {
                Filme filmeBuscado = _context.Filme.Find(id)!;

                return filmeBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(Filme novoFilme)
        {
            try
            {
                _context.Filme.Add(novoFilme);

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
                Filme filmeBuscado = _context.Filme.Find(id)!;

                if (filmeBuscado != null)
                {
                    _context.Filme.Remove(filmeBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Filme> Listar()
        {
            try
            {
                List<Filme> ListaDeFilmes = _context.Filme.ToList();
                return ListaDeFilmes;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
    }