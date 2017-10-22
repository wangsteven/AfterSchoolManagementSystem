using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;
using WinFormsMvp;

using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;


namespace AfterSchoolManagementSystem.Presenters
{
    public class TodayCareRecordListPresenter : Presenter<ITodayCareRecordListView>
    {
        private CareRecordList _CareRecordListInstace;
        public TodayCareRecordListPresenter(ITodayCareRecordListView view)
            : base(view)
        {
            View.Load += View_Load;
            View.QueryEventHandler += View_QueryEventHandler;
            View.ImportEventHandler += View_ImportEventHandler;
            View.SaveEventHandler += View_SaveEventHandler;
            View.AddNewEventHandler += View_AddNewEventHandler;

            _CareRecordListInstace = new CareRecordList();

        }

        private void View_Load(object sender, System.EventArgs e)
        { 

            GetLatestSelection();
            View.Model = _CareRecordListInstace;
            View.SetStudentList(DBModel.Instance.students);
            View_ImportEventHandler(null, null);
        }

        private void View_QueryEventHandler(object sender, System.EventArgs e)
        {
            GetLatestSelection();

            _CareRecordListInstace.InitFromDB_CareRecord();
            View.SetDataSource();
        }

        private void View_ImportEventHandler(object sender, System.EventArgs e)
        {
            GetLatestSelection();            

            _CareRecordListInstace.InitFromDB_CurrentCareReservation();
            View.SetDataSource();

        }

        private void View_SaveEventHandler(object sender, System.EventArgs e)
        {
            GetLatestSelection();
            _CareRecordListInstace.SaveCareRecordList(View.GetImportingMode());
            View.SetDataSource();
        }

        private void View_AddNewEventHandler(object sender, System.EventArgs e)
        {
            if (sender != null)
            {
                var type = GetViewTypeFromInterface(typeof(IStudentSelectionView));
                IStudentSelectionView studentselectionview = Activator.CreateInstance(type) as IStudentSelectionView;

                StudentSelection _StudentSelectionInstance = new StudentSelection();
                //_StudentSelectionInstance.SelectedStudents = (View.Model.GetSelStudentList()) as BindingList<student>;               
                _StudentSelectionInstance.UnselectedStudents = (View.Model.GetAllUnSelectedStudents()) as BindingList<student>;
                studentselectionview.Model = _StudentSelectionInstance;

                studentselectionview.SetDataSource();

                List<CareRecordItem> newreclist = new List<CareRecordItem>();

                //studentselectionview.ShowDialogBox();
                if (DialogResult.Cancel != studentselectionview.ShowDialogBox())
                {
                    List<student> newSelStudents = studentselectionview.Model.GetNewSelectedStudents();
                    CareRecordItem preRec = null;
                    if (View.Model.CareRecordItems.Count >0)
                    {
                        preRec = View.Model.CareRecordItems.Last();
                    }
                    
                    foreach (student stu in newSelStudents)
                    {
                        CareRecordItem newrec = new  CareRecordItem();
                        if (preRec != null)
                        {
                            newrec.breakfast = preRec.breakfast;
                            newrec.morningTea = preRec.morningTea;
                            newrec.lunch = preRec.lunch;
                            newrec.afternoonTea = preRec.afternoonTea;
                            newrec.supper = preRec.supper;
                            newrec.outcare = preRec.outcare;
                            newrec.checkinTime = preRec.checkinTime;
                            newrec.checkoutTime = preRec.checkoutTime;
                            newrec.description = preRec.description;
                        }               
                        
                        newrec.studentId = stu.studentId;
                        newrec.name = stu.name;
                        newrec.carerecordDate = View.GetSelEndDate();
                        newreclist.Add(newrec);
                    }
                }

                if (newreclist.Count > 0)
                {
                    foreach (CareRecordItem newcarerec in newreclist)
                        View.Model.CareRecordItems.Add(newcarerec);
                }
            }

        }

        private void GetLatestSelection()
        {
            _CareRecordListInstace.SelStudentId = View.GetSelStudentId();
            _CareRecordListInstace.SelStartDate = View.GetSelStartDate();
            _CareRecordListInstace.SelEndDate = View.GetSelEndDate();
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