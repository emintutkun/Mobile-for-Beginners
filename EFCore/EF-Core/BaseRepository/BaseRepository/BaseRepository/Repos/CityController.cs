using BaseRepository.Models.Classes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseRepository.Repos
{
    public class CityController : Controller
    {
        IBaseRepository<City> _repCity;
        public CityController(IBaseRepository<City> repCity)
        {
            _repCity = repCity;
        }

        public IActionResult List()
        {
            var clist = _repCity.List();
            return View(clist);
        }
    }
}
