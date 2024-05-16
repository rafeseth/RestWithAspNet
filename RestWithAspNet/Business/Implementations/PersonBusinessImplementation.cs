using RestWithAspNet.Data.VO;
using RestWithAspNet.Model;
using RestWithAspNet.Model.Data.Converter.Implementations;
using RestWithAspNet.Repository;

namespace RestWithAspNet.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _personRepository;
        private readonly PersonConverter _converter;
        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _personRepository = repository;
            _converter = new PersonConverter();
        }
        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_personRepository.FindAll());
        }

        public PersonVO FindById(long id)
        {
            return _converter.Parse(_personRepository.FindById(id));
        }
        public PersonVO Create(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _personRepository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public PersonVO Update(PersonVO person)
        {
            var personEntity = _converter.Parse(person);
            personEntity = _personRepository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
            _personRepository.Delete(id);
        }
    }



}
