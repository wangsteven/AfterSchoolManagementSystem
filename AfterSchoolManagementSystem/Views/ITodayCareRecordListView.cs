using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections;
using System.Windows.Forms;
using AfterSchoolEntityModel;
using WinFormsMvp;
using System.ComponentModel;

namespace AfterSchoolManagementSystem.Views
{
    public interface ITodayCareRecordListView : IView<CareRecordList>
    {
        void SetDataSource();

        void SetStudentList(IList list);

        DateTime GetSelStartDate();

        DateTime GetSelEndDate();

        int GetSelStudentId();

        event EventHandler QueryEventHandler;
        event EventHandler ImportEventHandler;
        event EventHandler SaveEventHandler;
        event EventHandler AddNewEventHandler;
    }
}
