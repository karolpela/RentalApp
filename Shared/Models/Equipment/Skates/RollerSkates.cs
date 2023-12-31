using System.Text.Json.Serialization;

namespace RentalApp.Shared.Models.Equipment.Skates;

public class RollerSkates : SportsEquipment
{
    [JsonConstructor]
    public RollerSkates(int id, decimal size, string purpose, bool isFunctional, int wheelHardness) : base(id, size,
        purpose, isFunctional)
    {
        WheelHardness = wheelHardness;
    }

    public int WheelHardness { get; set; }
}