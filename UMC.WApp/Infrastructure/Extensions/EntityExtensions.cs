using UMC.Model.Models;
using UMC.WApp.Models;

namespace UMC.WApp.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateShift(this Shift shift, ShiftViewModel shiftVm)
        {
            shift.ID = shiftVm.ID;
            shift.Name = shiftVm.Name;
            shift.From = shiftVm.From;
            shift.To = shiftVm.To;          
        }
       
    }
}