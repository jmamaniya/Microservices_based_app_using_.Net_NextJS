using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http.Features;

public class UpdateAuctionDto
{
    [Required]
    public string Make { get; set; }
    [Required]
    public string Model { get; set; }
    [Required]
    public int? Year { get; set; }
    [Required]
    public string Color { get; set; }
    [Required]
    public int? Mileage { get; set; }
}