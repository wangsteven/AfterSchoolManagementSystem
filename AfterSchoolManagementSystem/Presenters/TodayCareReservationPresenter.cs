using System;//
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;
using WinFormsMvp;

using System.Reflection;
using System.Windows.Forms;


namespace AfterSchoolManagementSystem.Presenters
{
    public class TodayCareReservationPresenter : Presenter<ITodayCareReservationView>
    {
        private CurrentCareReservationList _CurrentCareReservationListInstance;
        private StudentSelection _StudentSelectionInstance;
        public TodayCareReservationPresenter(ITodayCareReservationView view) 
            : base(view)
        {
            View.Load += View_Load;
            View.UpdateEventHandler += View_Update;
            View.AddNewEventHandler += View_AddNew;
            View.RemoveEventHandler += View_Remove;
            View.WeekdaySelectedEventHandler += View_WeekdaySelected;
            View.ReCreateEventHandler += View_ReCreate;
            View.ExportEventHandler += View_Export;

            _CurrentCareReservationListInstance = new CurrentCareReservationList();
            _StudentSelectionInstance = new StudentSelection();
        }

        private void View_Load(object sender, System.EventArgs e)
        {

            View.Model = _CurrentCareReservationListInstance;
            View.SetDataSource();
        }

        private void View_Update(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                View.Model.Update(sender as currentcarereservation);
            }

        }

        private void View_AddNew(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                var type = GetViewTypeFromInterface(typeof(IStudentSelectionView));
                IStudentSelectionView studentselectionview = Activator.CreateInstance(type) as IStudentSelectionView;

                _StudentSelectionInstance.SelectedStudents = View.Model.GetAllSelectedStudents();
                _StudentSelectionInstance.UnselectedStudents = View.Model.GetAllUnSelectedStudents();

                studentselectionview.Model = _StudentSelectionInstance;

                studentselectionview.SetDataSource();

                List<currentcarereservation> newreservation = new List<currentcarereservation>();

                //studentselectionview.ShowDialogBox();
                if (DialogResult.Cancel != studentselectionview.ShowDialogBox())
                {
                    List<student> newSelStudents = studentselectionview.Model.GetNewSelectedStudents();
                    foreach (student stu in newSelStudents)
                    {
                        currentcarereservation newres = new currentcarereservation();
                        newres.studentId = stu.studentId;
                        newres.name = stu.name;
                        newres.school = stu.school;
                        newres.schoolTeacher = stu.schoolTeacher;
                        newres.grade = stu.grade;
                        newres.classGroup = stu.classGroup;
                        newres.guardian = stu.guardian;

                        newreservation.Add(newres);
                    }
                }

                if (newreservation.Count > 0)
                {
                    foreach(currentcarereservation newcareres in newreservation)
                        View.Model.Insert(newcareres);
                }
            }

        }

        private void View_Remove(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                View.Model.Delete(sender as currentcarereservation);
            }

        }

        private void View_WeekdaySelected(object sender, System.EventArgs e)
        {
            View.Model.SelectedWeekday = View.GetSelectedWeekday();
            
            View.Model.Refresh();
            View.SetDataSource();
        }



        private void View_ReCreate(object sender, System.EventArgs e)
        {
            View.Model.Refresh();
            View.SetDataSource();
        }

        private void View_Export(object sender, System.EventArgs e)
        {
            View.Model.SaveCurrentCareReservations();

            // ExportToExcel();

    

           // DataTable dt = ModelConvertHelper<currentcarereservation>.ConvertToDataTable(View.Model.CurrentCareReservations);
           // string filepath = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "签到表.xlsx";

            //ExportHelper.Instance.Save(dt, filepath, 1, 1, 1);
            //GC.Collect();

            //System.Diagnostics.Process.Start(filepath);
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
