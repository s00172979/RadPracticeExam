﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadPracticeExam
{
   public class BusinessDbContext: DbContext
    {

        public BusinessDbContext() : base("DefaultConnection")
        {
            Database.SetInitializer(new BusinessDbContextInitializer());
            Database.Initialize(true);
        }

        public DbSet<Orders> Orders { get; set; }
     
    }
}
