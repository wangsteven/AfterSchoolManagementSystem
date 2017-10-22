using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Windows.Forms;
using WinFormsMvp;
using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;

namespace AfterSchoolManagementSystem.Presenters
{
    public class StudentDetailPresenter : Presenter<IStudentDetailView>
    {

        private StudentList _studentListInstance;
        private CareReservationList _CareReservationListInstance;
        public StudentDetailPresenter(IStudentDetailView view) 
            : base(view)
        {
            View.Load += View_Load;
            View.ConfirmToSave += SaveUpdate;
            View.ConfirmToDelete += ConfirmedToDelete;
            View.OpenCareReservationView += OpenCareReservationView;

            _studentListInstance = new StudentList();
            _CareReservationListInstance = new CareReservationList();
        }

        private void View_Load(object sender, System.EventArgs e)
        {
            
        }
        private void SaveUpdate(object sender, System.EventArgs e)
        {
            student st = (student)sender;
            _studentListInstance.Update(st);           
        }

        private void ConfirmedToDelete(object sender, System.EventArgs e)
        {
            student st = (student)sender;
            _studentListInstance.Delete(st);
        }


        private void OpenCareReservationView(object sender, System.EventArgs e)
        {
            var type = GetViewTypeFromInterface(typeof(ICareReservationView));

            ICareReservationView reservationview = Activator.CreateInstance(type) as ICareReservationView;
            _CareReservationListInstance.CurrentStudentId = View.Model.studentId;

            reservationview.Model = _CareReservationListInstance;
            reservationview.SetTitile(View.Model.name + "--托管预约");
            reservationview.SetDataSource();
            reservationview.ShowDialogBox();
            /*if (DialogResult.Cancel != reservationview.ShowDialogBox())
            {
               // View.Model = StudentList.Instance;
                //View.SetDataSource();
            }
             * */

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
