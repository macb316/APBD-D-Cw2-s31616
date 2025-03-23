namespace APBD_D_Cw2_s31616.Interfaces;

public interface IHazardNotifier
{
    public void HazardNotify(string msg) { Console.WriteLine(msg); }
}