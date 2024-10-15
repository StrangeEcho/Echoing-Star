public class Car : IVehicle {
    private string m_make;
    private string m_model;
    private bool m_running;
    private string m_destination;

    public Car(string make, string model, bool running, string destination) {
        m_make = make;
        m_model = model;
        m_running = running;
        m_destination = destination;
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
        string translated = m_running ? "Running" : "Not running";
        return $"Make: {m_make}\nModel: {m_model}\nThe car is {translated} and is heading to {m_destination}";
    }
}