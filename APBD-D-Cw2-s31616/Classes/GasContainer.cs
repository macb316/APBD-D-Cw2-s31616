namespace APBD_D_Cw2_s31616.Classes;

public class GasContainer(int height, int depth, int mass, int capacity) : Container(height, depth, mass, capacity, 'G')
{
    
    public override void LoadContainer(int newCargoMass)
    {
        base.LoadContainer(newCargoMass);
        
    }
    
    public override void UnloadContainer()
    {
        throw new NotImplementedException();
    }
}