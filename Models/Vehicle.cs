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
    public string RegistrationNumber { get; set; }

    public int modelId {get; set;}
    public Model Model{get; set;}

    public int TypeId { get; set; }
    public VehicleType Type { get; set; }

    public int LocationId { get; set; }
    public Location Location{get; set;}

    // Upload to mySQL
    public IEnumerable<Rental> Rentals { get; set; }
}