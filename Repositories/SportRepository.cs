﻿using ACEbets.Models;
using ACEbets.Repositories.Interfaces;

namespace ACEbets.Repositories
{
    public class SportRepository : RepositoryBase<Sport>, ISportRepository
    {
        public SportRepository(BetService bettingContext) : base(bettingContext)
        {
        }
    }
}
