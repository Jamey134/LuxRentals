#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace LuxRentals.Models;
public class Rental
{
    [Key]
    public int Id { get; set; }

    [Required]
    public DateTime DateFrom { get; set; }

    public DateTime DateTo { get; set; }
    public int StatusId {get; set;}
    public Status Status {get; set;}
    public int VehicleId {get; set;}
    public Vehicle Vehicle {get; set;}
    public int UserId {get; set;}
    public User User {get; set;}

    // Upload to mySQL
    public IEnumerable<Vehicle> Vehicles { get; set; }
}