public class CargoTruck : IVehicle {
    private string m_make;
    private string m_model;
    private bool m_running;
    private string m_destination;
    public string CargoCapacity {get; set; }

    public CargoTruck(string make, string model, bool running, string destination, string cargocapacity) { 
        m_make = make;
        m_model = model;
        m_running = running;
        m_destination = destination;
        CargoCapacity = cargocapacity;
    }

    public string GetMake() {
        return m_make;
    }

    public string GetModel() {
        return m_model;
    }

    public void Start() {
        m_running = true;
    }

    public void Stop() {
        m_running = false;
    }

    public void Drive(string destination) {
        m_destination = destination;
    }

    public override string ToString() {
        string translated = m_running ? "Running" : "Not Running";
        return $"Make: {m_make}\nModel: {m_model}\nThe is truck is {translated} and hauling {CargoCapacity} of cargo to {m_destination}";
    }
}