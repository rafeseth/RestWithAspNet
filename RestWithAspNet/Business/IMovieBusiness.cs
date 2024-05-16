using RestWithAspNet.Data.VO;

namespace RestWithAspNet.Business
{
    public interface IMovieBusiness
    {
        MovieVO Create(MovieVO movie);
        MovieVO FindById(long id);
        List<MovieVO> FindAll();
        MovieVO Update(MovieVO movie);
        void Delete(long id);
    }
}
