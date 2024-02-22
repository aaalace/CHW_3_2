using Lib.CustomEventArgs;
using Core.Enums.EntityEnums;
using Lib.Utils;

namespace Lib.Entities;

public partial class Machine
{
    public event EventHandler<UpdateEventArgs>? Updated;
    public event EventHandler<RepairChangedEventArgs>? RepairChanged;
    
    private void OnUpdated(object? sender, UpdateEventArgs args)
        => Updated?.Invoke(sender, args);
    
    private void OnRepairChanged(object? sender, RepairChangedEventArgs args)
        => RepairChanged?.Invoke(sender, args);
    
    public void EditMachine<TField>(TField updField, MachineField fieldToEdit)
    {
        switch (fieldToEdit)
        {
            case MachineField.Brand:
                Brand = Convert.ToString(updField)!;
                break;
            case MachineField.IsReady: 
                IsReady = Convert.ToBoolean(updField);
                break;
            case MachineField.Model:
                Model = Convert.ToString(updField)!;
                break;
            case MachineField.Price:
                Price = Convert.ToDouble(updField);
                break;
            case MachineField.Year:
                Year = Convert.ToInt32(updField);
                break;
        }
        
        OnUpdated(this, new UpdateEventArgs(DateTime.Now));
    }

    public void AddRepair(
        string issue,
        double repairCost,
        string technician,
        bool isFixed,
        DateTime repairDate)
    {
        string newRepairId = IdGenerator.GetId(this);
        var repair = new Repair(newRepairId, issue, repairCost, technician, isFixed, repairDate);
        Repairs.Add(repair);
        
        OnUpdated(this, new UpdateEventArgs(DateTime.Now));
        OnRepairChanged(this, new RepairChangedEventArgs(this));
    }

    public void EditRepair<TField>(TField updField, string repairId, RepairField fieldToEdit)
    {
        var repair = Repairs.FirstOrDefault(x => x.RepairId == repairId);
        if (repair is null) return;
        
        switch (fieldToEdit)
        {
            case RepairField.Technician:
                repair.Technician = Convert.ToString(updField)!;
                break;
            case RepairField.IsFixed:
                repair.IsFixed = Convert.ToBoolean(updField);
                break;
            case RepairField.Issue:
                repair.Issue = Convert.ToString(updField)!;
                break;
            case RepairField.RepairCost:
                repair.RepairCost = Convert.ToDouble(updField);
                break;
            case RepairField.RepairDate:
                repair.RepairDate = Convert.ToDateTime(updField);
                break;
        }
        
        OnUpdated(this, new UpdateEventArgs(DateTime.Now));
        OnRepairChanged(this, new RepairChangedEventArgs(this));
    }
}