using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AfterSchoolEntityModel;
using WinFormsMvp;

namespace AfterSchoolManagementSystem.Views
{
    public interface ITodayCareReservationView : IView<CurrentCareReservationList>
    {
        void SetDataSource();
        int GetSelectedWeekday();

        event EventHandler UpdateEventHandler;
        event EventHandler AddNewEventHandler;
        event EventHandler RemoveEventHandler;

        event EventHandler WeekdaySelectedEventHandler;
        event EventHandler ReCreateEventHandler;
        event EventHandler ExportEventHandler;
        
    }
}
