using RestWithAspNet.Data.VO;
using RestWithAspNet.Model;
using RestWithAspNet.Model.Data.Converter.Implementations;
using RestWithAspNet.Repository;

namespace RestWithAspNet.Business.Implementations
{
    public class MovieBusinessImplementation : IMovieBusiness
    {
        private readonly IRepository<Movie> _movieRepository;
        private readonly MovieConverter _Converter;
        public MovieBusinessImplementation(IRepository<Movie> repository)
        {
            _movieRepository = repository;
            _Converter = new MovieConverter();
        }
        public List<MovieVO> FindAll()
        {
            return _Converter.Parse(_movieRepository.FindAll());
        }

        public MovieVO FindById(long id)
        {
            return _Converter.Parse(_movieRepository.FindById(id));
        }
        public MovieVO Create(MovieVO movie)
        {
            var entity = _Converter.Parse(movie);
            return _Converter.Parse(_movieRepository.Create(entity));
        }

        public MovieVO Update(MovieVO movie)
        {
            var entity = _Converter.Parse(movie);
            return _Converter.Parse(_movieRepository.Update(entity));
        }

        public void Delete(long id)
        {
            _movieRepository.Delete(id);
        }
    }

    

}
