using AdvancedRepository.Core;
using AdvancedRepository.DTOs;
using AdvancedRepository.Models.Classes;
using AdvancedRepository.Models.Data;
using AdvancedRepository.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedRepository.Repository.Classes
{
    public class UnitsRepos : BaseRepository<Units>, IUnitsRepos
    {
        public UnitsRepos(SirketContext db) : base (db)
        {

        }

        public List<UnitsList> GetUnits()
        {
            var units = Set().Select(x => new UnitsList
            {
                Id = x.Id,
                UnitName = x.UnitName
            }).ToList();
            return units;
        }
    }
}
