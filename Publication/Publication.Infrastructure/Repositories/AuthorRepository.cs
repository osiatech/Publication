
using Publication.Domain.Entities;
using Publication.Infrastructure.Context;
using Publication.Infrastructure.Core;
using Publication.Infrastructure.Interfaces;

namespace Publication.Infrastructure.Repositories
{
    public class AuthorRepository : BaseRepository<Author>, IAuthorRepository
    {
        private readonly PublicationContext dbContext;

        public AuthorRepository(PublicationContext dbContext) : base(dbContext)
        {
            this.dbContext = dbContext; 
        }


        public override void Save(Author author)
        {
            dbContext.Authors.Add(author);   
            dbContext.SaveChanges();
        }


        public override void Update(Author author)
        {
            var authorToUpdate = base.GetEntity(author.AuthorId);

            authorToUpdate.FirstName = author.FirstName;
            authorToUpdate.LastName = author.LastName;
            author.PhoneNumber = author.PhoneNumber;
            author.Address = author.Address;
            authorToUpdate.City = author.City;
            authorToUpdate.State = author.State;
            authorToUpdate.Zip = author.Zip;
            authorToUpdate.Contract = author.Contract;
            
            dbContext.Authors.Update(authorToUpdate);
            dbContext.SaveChanges();
        }


        public override void Delete(Author author)
        {

        }

    }
}
