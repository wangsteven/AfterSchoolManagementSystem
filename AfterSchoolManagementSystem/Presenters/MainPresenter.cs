using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using AfterSchoolManagementSystem.Views;
using WinFormsMvp;


namespace AfterSchoolManagementSystem.Presenters
{
    public class MainPresenter : Presenter<IMainView>   
    {
        public MainPresenter(IMainView view)
            : base(view)
        {
            View.ViewLoding += View_ViewLoding;
            View.LoadStudentForm += View_LoadStudentForm;
            View.LoadTodayCareReservationForm += View_TodayCareReservationForm;
            View.LoadCareRecordForm += View_LoadCareRecordForm;
            View.LoadTodayCareRecordListForm += View_LoadTodayCareRecordListForm;

        }

        private void View_ViewLoding(object sender, EventArgs e)
        {
            View.ConfirmLoaded();
        }

        private void View_LoadStudentForm(object sender, EventArgs e)
        {
            var type = GetViewTypeFromInterface(typeof(IStudentView));
            View.LoadChildForm(type);
        }

        private void View_TodayCareReservationForm(object sender, EventArgs e)
        {

            var type = GetViewTypeFromInterface(typeof(ITodayCareReservationView));
            View.LoadChildForm(type);
        }

        private void View_LoadCareRecordForm(object sender, EventArgs e)
        {
            var type = GetViewTypeFromInterface(typeof(ICareRecordListView));
            View.LoadChildForm(type);
        }

        private void View_LoadTodayCareRecordListForm(object sender, EventArgs e)
        {
            var type = GetViewTypeFromInterface(typeof(ITodayCareRecordListView));
            View.LoadChildForm(type);
        }

        private Type GetViewTypeFromInterface(Type type)
        {
            Type viewType = null;

            var assembly = Assembly.GetExecutingAssembly();

            foreach (var exportedType in assembly.GetExportedTypes().Where(t => t.IsSubclassOf(typeof(Control))))
            {
                if (type.IsAssignableFrom(exportedType))
                {
                    viewType = exportedType;
                    break;
                }
            }

            return viewType;
        }

    }
}
