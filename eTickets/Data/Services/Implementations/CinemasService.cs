﻿using eTickets.Data.Base;
using eTickets.Data.Services.Interfaces;
using eTickets.Models;

namespace eTickets.Data.Services.Implementations
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context) : base(context) { }
    }
}
