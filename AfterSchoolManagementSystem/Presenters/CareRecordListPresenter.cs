using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AfterSchoolEntityModel;
using AfterSchoolManagementSystem.Views;
using WinFormsMvp;

namespace AfterSchoolManagementSystem.Presenters
{
    public class CareRecordListPresenter : Presenter<ICareRecordListView>
    {
        private CareRecordList _CareRecordListInstace;
        public CareRecordListPresenter(ICareRecordListView view)
            : base(view)
        {
            View.Load += View_Load;
            View.QueryEventHandler += View_QueryEventHandler;
            View.ImportEventHandler += View_ImportEventHandler;
            View.SaveEventHandler += View_SaveEventHandler;

            _CareRecordListInstace = new CareRecordList();

        }

        private void View_Load(object sender, System.EventArgs e)
        {
            GetLatestSelection();

            View.Model = _CareRecordListInstace;

            View.SetStudentList(DBModel.Instance.students);
            View_QueryEventHandler(null, null);

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
            _CareRecordListInstace.SaveCareRecordList(false);
            View.SetDataSource();
        }

        private void GetLatestSelection()
        {
            _CareRecordListInstace.SelStudentId = View.GetSelStudentId();
            _CareRecordListInstace.SelStartDate = View.GetSelStartDate();
            _CareRecordListInstace.SelEndDate = View.GetSelEndDate();

        }
    }
}