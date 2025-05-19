namespace Cars;

public interface IVehicle
{
    void StartEngine();
    void StopEngine();
    void Drive(int kilometers);
}