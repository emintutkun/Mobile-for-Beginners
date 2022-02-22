using BasicRepositorySoftDelete.Models.Classes;
using BasicRepositorySoftDelete.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicRepositorySoftDelete.Repos
{
    public class PersonelRepository : BaseRepository<Personel>
    {
        public PersonelRepository(PerContext db) : base (db)
        {

        }
    }
}
