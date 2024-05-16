using RestWithAspNet.Data.VO;
using RestWithAspNet.Model.Data.Converter.Contract;
using System.Reflection.Metadata.Ecma335;

namespace RestWithAspNet.Model.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
            if (origin == null)
                return null;
            else
            {
                return new Book
                {
                    Id = origin.Id,
                    Name = origin.Name,
                    Author = origin.Author,
                    Gender = origin.Gender,
                    LaunchDate = origin.LaunchDate,
                    Description = origin.Description,
                    Price= origin.Price
                };
            }
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item => Parse(item)).ToList();
        }

        public BookVO Parse(Book origin)
        {
            if (origin == null)
                return null;
            else
            {
                return new BookVO
                {
                    Id = origin.Id,
                    Name = origin.Name,
                    Author = origin.Author,
                    Gender = origin.Gender,
                    LaunchDate = origin.LaunchDate,
                    Description = origin.Description,
                    Price = origin.Price
                };
            }
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
