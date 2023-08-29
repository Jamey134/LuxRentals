#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace LuxRentals.Models;
public class Status
{
    [Key]
    public int StatusId { get; set; }

    [Required]
    public string Code { get; set; }

    public string Description { get; set; }

// Upload to mySQL
    public IEnumerable<Rental> Rentals {get; set;}
}