﻿using Book.DataAccess.Data;
using Book.DataAccess.Repository.IRepository;
using Book.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Book.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {

        private ApplicationDbContext _db;
        public ApplicationUserRepository(ApplicationDbContext db) :base(db)
        {
            _db = db;
        }
    }
}
