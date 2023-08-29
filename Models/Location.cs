#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace LuxRentals.Models;
public class Location
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Code { get; set; }
    [Required]
    public string Name { get; set; }



    // Upload to mySQL
    public IEnumerable<Vehicle> Vehicles { get; set; }
}