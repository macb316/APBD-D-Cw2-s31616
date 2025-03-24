namespace APBD_D_Cw2_s31616.Classes;

public class CoolerContainer(int height, int depth, int mass, int capacity, string cargoIntended, double temperature) : Container(height, depth, mass, capacity, 'C')
{

    public string CargoIntended { get; set; } = cargoIntended;
    public double ContainerTemperature { get; set; } = temperature;
    
    public override void LoadContainer(int newCargoMass, Cargo cargo)
    {
        base.LoadContainer(newCargoMass, cargo);
        
    }
    
    public override void UnloadContainer()
    {
        CargoMass = 0;
        CargoName = null;
    }
}