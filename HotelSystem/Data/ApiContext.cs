using HotelSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelSystem.Data;

public class ApiContext: DbContext
{
    public DbSet<HotelBooking> Bookings { get; set; }

    public ApiContext(DbContextOptions<ApiContext> dbContextOptions)
    :base (dbContextOptions)
    {
        
    }
}