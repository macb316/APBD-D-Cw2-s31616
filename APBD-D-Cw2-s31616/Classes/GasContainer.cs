using APBD_D_Cw2_s31616.Interfaces;

namespace APBD_D_Cw2_s31616.Classes;

public class GasContainer(int height, int depth, int mass, int capacity) : Container(height, depth, mass, capacity, 'G'), IHazardNotifier
{
    
    public override void LoadContainer(int newCargoMass, Cargo cargo)
    {
        base.LoadContainer(newCargoMass, cargo);
        
    }
    
    public override void UnloadContainer()
    {
        CargoMass /= 20;
    }
}