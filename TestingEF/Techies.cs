using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingEF.DataAccess;

namespace TestingEF
{
    public class Techies
    {
        private readonly TechiesDbContext _context;
        public Techies(TechiesDbContext context)
        {
            _context = context;
        }

        public TechiePerson GetTechieById(int id)
        {
            Contract.Ensures(id > 0);

            var techie = _context.Techies.FirstOrDefault(x => x.Id == id);

            if (techie == null)
                throw new InvalidOperationException("There is no techie with this id.");

            return techie;
        }
    }
}
