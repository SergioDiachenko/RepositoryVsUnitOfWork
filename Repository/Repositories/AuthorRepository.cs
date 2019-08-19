using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Model;
using System.Data.Entity;

namespace Repository
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        public AuthorRepository(PlutoContext context) 
            : base(context)
        {
        }

        public Author GetAuthorWithCourses(int id)
        {
            return PlutoContext.Authors
                .Include(a => a.Courses)
                .SingleOrDefault(a => a.Id == id);
        }

        public PlutoContext PlutoContext
        {
            get { return context as PlutoContext; }
        }
    }
}
