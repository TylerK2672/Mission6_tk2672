using System;
using Microsoft.EntityFrameworkCore;

namespace Mission6_tk2672.Models
{
	public class DateApplicationContext : DbContext
	{
		public DateApplicationContext(DbContextOptions<DateApplicationContext> options) : base(options)
		{

		}

		public DbSet<ApplicationResponse> responses { get; set; }
	}
}

