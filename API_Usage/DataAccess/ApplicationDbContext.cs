﻿using Microsoft.EntityFrameworkCore;
using API_Usage.Models;

namespace API_Usage.DataAccess
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Company> Companies { get; set; }
    public DbSet<Equity> Equities { get; set; }
    public DbSet<News> newsList { get; set; }
    public DbSet<Financial> Financial { get; set; }
    public DbSet<FinancialList> FinancialList { get; set; }
    public DbSet<Sector> sector { get; set; }
    public DbSet<Top_Gainers> Top_Gainers { get; set; }


    }
}