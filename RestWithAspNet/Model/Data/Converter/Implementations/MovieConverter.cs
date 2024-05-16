using RestWithAspNet.Data.VO;
using RestWithAspNet.Model.Data.Converter.Contract;
using System.Reflection.Metadata.Ecma335;

namespace RestWithAspNet.Model.Data.Converter.Implementations
{
    public class MovieConverter : IParser<MovieVO, Movie>, IParser<Movie, MovieVO>
    {
        public Movie Parse(MovieVO origin)
        {
            if (origin == null)
                return null;
            else
            {
                return new Movie
                {
                    Id = origin.Id,
                    Name = origin.Name,
                    Gender = origin.Gender,
                    LaunchDate = origin.LaunchDate,
                    Description = origin.Description,
                    DurationTime = origin.DurationTime,
                    Director=origin.Director
                };
            }
        }

        public List<Movie> Parse(List<MovieVO> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public MovieVO Parse(Movie origin)
        {
            if (origin == null)
                return null;
            else
            {
                return new MovieVO
                {
                    Id = origin.Id,
                    Name = origin.Name,
                    Gender = origin.Gender,
                    LaunchDate = origin.LaunchDate,
                    Description = origin.Description,
                    DurationTime = origin.DurationTime,
                    Director = origin.Director
                };
            }
        }

        public List<MovieVO> Parse(List<Movie> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
