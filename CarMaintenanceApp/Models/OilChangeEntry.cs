namespace CarMaintenanceApp.Models;

public class OilChangeEntry
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Date { get; set; }
    public int OdometerMiles { get; set; }
    public string Notes { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }

    public string Status => IsCompleted ? "Completed" : "Pending";
}
