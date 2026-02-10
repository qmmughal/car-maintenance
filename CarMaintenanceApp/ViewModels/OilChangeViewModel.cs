using System.Collections.ObjectModel;
using System.Windows.Input;
using CarMaintenanceApp.Models;

namespace CarMaintenanceApp.ViewModels;

public class OilChangeViewModel : BindableObject
{
    private const int OilChangeIntervalMiles = 5000;

    private DateTime _newDate = DateTime.Today;
    private int _newOdometerMiles;
    private string _newNotes = string.Empty;

    public ObservableCollection<OilChangeEntry> Entries { get; } = new();

    public DateTime NewDate
    {
        get => _newDate;
        set
        {
            _newDate = value;
            OnPropertyChanged();
        }
    }

    public int NewOdometerMiles
    {
        get => _newOdometerMiles;
        set
        {
            _newOdometerMiles = value;
            OnPropertyChanged();
        }
    }

    public string NewNotes
    {
        get => _newNotes;
        set
        {
            _newNotes = value;
            OnPropertyChanged();
        }
    }

    public string NextOilChangeMileage
    {
        get
        {
            var latestCompleted = Entries
                .Where(item => item.IsCompleted)
                .OrderByDescending(item => item.OdometerMiles)
                .FirstOrDefault();

            return latestCompleted is null
                ? "No completed oil change yet"
                : $"{latestCompleted.OdometerMiles + OilChangeIntervalMiles:N0} mi";
        }
    }

    public ICommand AddCommand => new Command(AddEntry);
    public ICommand DeleteCommand => new Command<OilChangeEntry>(DeleteEntry);
    public ICommand ToggleStatusCommand => new Command<OilChangeEntry>(ToggleStatus);

    public OilChangeViewModel()
    {
        Entries.Add(new OilChangeEntry
        {
            Date = DateTime.Today.AddDays(-35),
            OdometerMiles = 41200,
            Notes = "Synthetic 5W-30 and filter replacement",
            IsCompleted = true
        });

        Entries.Add(new OilChangeEntry
        {
            Date = DateTime.Today.AddDays(10),
            OdometerMiles = 46000,
            Notes = "Planned next maintenance",
            IsCompleted = false
        });
    }

    private void AddEntry()
    {
        if (NewOdometerMiles <= 0)
        {
            return;
        }

        Entries.Insert(0, new OilChangeEntry
        {
            Date = NewDate,
            OdometerMiles = NewOdometerMiles,
            Notes = NewNotes,
            IsCompleted = false
        });

        NewDate = DateTime.Today;
        NewOdometerMiles = 0;
        NewNotes = string.Empty;
        OnPropertyChanged(nameof(NextOilChangeMileage));
    }

    private void DeleteEntry(OilChangeEntry? entry)
    {
        if (entry is null)
        {
            return;
        }

        Entries.Remove(entry);
        OnPropertyChanged(nameof(NextOilChangeMileage));
    }

    private void ToggleStatus(OilChangeEntry? entry)
    {
        if (entry is null)
        {
            return;
        }

        entry.IsCompleted = !entry.IsCompleted;

        var index = Entries.IndexOf(entry);
        if (index >= 0)
        {
            Entries.RemoveAt(index);
            Entries.Insert(index, entry);
        }

        OnPropertyChanged(nameof(Entries));
        OnPropertyChanged(nameof(NextOilChangeMileage));
    }
}
