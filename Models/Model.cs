#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace LuxRentals.Models;
public class Vehicle
{
    [Key]
    public int Id { get; set; }

    [Required]
    public decimal DailyHireRate { get; set; }
    [Required]
    public string Name {get; set;}

    public int MakeId {get; set;}
    public Make Make {get; set;}

    // Upload to mySQL
    public IEnumerable<Vehicle> Vehicles { get; set; }
}