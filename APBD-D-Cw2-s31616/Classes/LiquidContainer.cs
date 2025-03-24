using APBD_D_Cw2_s31616.Interfaces;

namespace APBD_D_Cw2_s31616.Classes;


public class LiquidContainer(int height, int depth, int mass, int capacity) : Container(height, depth, mass, capacity, 'L'), IHazardNotifier
{
    public override void LoadContainer(int newCargoMass, Cargo cargo)
    {
        base.LoadContainer(newCargoMass, cargo);
        if (newCargoMass >= CargoMassCapacity * 0.5 && cargo.CargoHazardous == true) //oh man, an actual reason to type "== true"
        {
            HazardNotify($"Can't fill container {Serial} with this much hazardous liquid cargo");
        }
        else if (newCargoMass >= CargoMassCapacity * 0.9)
        {
            HazardNotify($"Can't fill container {Serial} with this much liquid cargo");
        } 
        else
        {
            CargoMass = newCargoMass;
            CargoName = cargo.CargoName;
        }
    }

    public override void UnloadContainer()
    {
        CargoMass = 0;
        CargoName = null;
    }

    public void HazardNotify(string msg)
    {
        Console.WriteLine(msg);
    }
}