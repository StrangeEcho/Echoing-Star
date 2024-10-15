public interface IVehicle {
    string GetMake();
    string GetModel();
    void Start();
    void Stop();
    void Drive(string destination); 
}