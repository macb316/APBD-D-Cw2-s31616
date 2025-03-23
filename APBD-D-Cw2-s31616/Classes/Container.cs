using APBD_D_Cw2_s31616.Exceptions;

namespace APBD_D_Cw2_s31616.Classes;


public abstract class Container (int height, int depth, int mass, int capacity, char serialType)
{
    private static int _nextSerialNo = 1;

    public int CargoMass { get; protected set; } = 0;
    public int Height { get; private set; } = height;
    public int OwnMass { get; private set; } = mass;
    public int Depth { get; private set; } = depth;
    public int CargoMassCapacity { get; private set; } = capacity;
    public string Serial { get; private set; } = "KON-" + serialType + '-' + _nextSerialNo++;

    public virtual void LoadContainer(int cargoMass)
    {
        if (cargoMass >= CargoMassCapacity)
        {
            throw new OverfillException("You're trying to load more than the capacity allows.");
        }
    }
    
    public abstract void UnloadContainer();
    
    

}