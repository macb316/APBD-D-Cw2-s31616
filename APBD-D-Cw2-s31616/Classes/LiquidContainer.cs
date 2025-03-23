namespace APBD_D_Cw2_s31616.Classes;


public class LiquidContainer(int height, int depth, int mass, int capacity) : Container(height, depth, mass, capacity, 'L'), IHazardNotifier
{
    public override void LoadContainer(int newCargoMass)
    {
        base.LoadContainer(newCargoMass);
        if (newCargoMass >= CargoMassCapacity * 0.5)
        {
            
        }
        else
        {
            CargoMass = newCargoMass;
        }
    }

    public override void UnloadContainer()
    {
        throw new NotImplementedException();
    }
}