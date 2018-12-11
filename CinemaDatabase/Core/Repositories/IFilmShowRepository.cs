﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDatabase.Core.Repositories
{
    public interface IFilmShowRepository : IRepository<FilmShow>
    {
        IEnumerable<FilmShow> GetOccupiedSeats();
    }
}
