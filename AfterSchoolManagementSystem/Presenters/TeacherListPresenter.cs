using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using WinFormsMvp;
using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;

namespace AfterSchoolManagementSystem.Presenters
{
    public class TeacherListPresenter : Presenter<ITeacherListView>
    {
        private TeacherList _TeacherListInstace;
        public TeacherListPresenter(ITeacherListView view) 
            : base(view)
        {
            View.Load += View_Load;
            View.UpdateEventHandler += View_Update;
            View.AddNewEventHandler += View_AddNew;
            View.RemoveEventHandler += View_Remove;

            _TeacherListInstace = new TeacherList();
        }

        private void View_Load(object sender, System.EventArgs e)
        {
            View.Model = _TeacherListInstace;
            View.SetDataSource();
        }

        private void View_Update(object sender, System.EventArgs e)
        {
            if(sender != null)
            {
                View.Model.Update(sender as teacher);
                View.SetDataSource();
            }

        }

        private void View_AddNew(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                View.Model.Insert(sender as teacher);
                View.SetDataSource();
            }

        }

        private void View_Remove(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                View.Model.Delete(sender as teacher);
                View.SetDataSource();
            }

        }



    }
}
