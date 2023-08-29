#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LuxRentals.Models;
public class Status
{
    [Key]
    public int StatusId { get; set; }

    [Required]
    public string Code { get; set; }

    public string Description { get; set; }


}