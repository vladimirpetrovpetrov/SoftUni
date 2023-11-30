using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Trucks.Data.Models.Enums;

namespace Trucks.Data.Models;

public class Truck
{
    [Key]
    public int Id { get; set; }
    [MaxLength(8)]
    public string RegistrationNumber { get; set; }
    [Required]
    [StringLength(17)]
    public string VinNumber { get; set; }
    [Range(950,1420)]
    public int TankCapacity { get; set; }
    [Range(5000,29000)]
    public int CargoCapacity { get; set; }
    [Required]
    public CategoryType CategoryType { get; set; }
    [Required]
    public MakeType MakeType { get; set; }
    [Required]
    public int DespatcherId { get; set; }
    [ForeignKey(nameof(DespatcherId))]
    public Despatcher Despatcher { get; set; } = null!;
    public ICollection<ClientTruck> ClientsTrucks { get; set; } = new List<ClientTruck>();




}
