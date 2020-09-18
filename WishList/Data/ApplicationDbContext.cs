<<<<<<< Updated upstream
﻿using Microsoft.EntityFrameworkCore;
=======
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WishList.Models;
>>>>>>> Stashed changes

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Models.Item> Items { get; set; }
    }
}
