namespace APBD_D_Cw2_s31616.Classes;

public class Cargo(string cargoName, bool? cargoHazardous)
{
    public string CargoName { get; private set; } = cargoName;
    public bool? CargoHazardous { get; private set; } = cargoHazardous;
}