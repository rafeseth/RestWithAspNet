using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RestWithAspNet.Data.VO;
using RestWithAspNet.Model;
using RestWithAspNet.Model.Context;
using RestWithAspNet.Model.Data.Converter.Implementations;
using RestWithAspNet.Repository;
using System;
using System.Diagnostics.CodeAnalysis;

namespace RestWithAspNet.Business.Implementations
{
    public class BookBusinessImplementation : IBookBusiness
    {
        private readonly IRepository<Book> _bookRepository;
        private readonly BookConverter _converter;
        public BookBusinessImplementation(IRepository<Book> repository)
        {
            _bookRepository = repository;
            _converter = new BookConverter();
        }
        public List<BookVO> FindAll()
        {
            return _converter.Parse(_bookRepository.FindAll());
        }

        public BookVO FindById(long id)
        {
            return _converter.Parse(_bookRepository.FindById(id));
        }
        public BookVO Create(BookVO book)
        {
            var entity = _converter.Parse(book);
            return  _converter.Parse(_bookRepository.Create(entity));
        }

        public BookVO Update(BookVO book)
        {
            var entity = _converter.Parse(book);
            return _converter.Parse(_bookRepository.Update(entity));
        }

        public void Delete(long id)
        {
            _bookRepository.Delete(id);
        }
    }

    

}
