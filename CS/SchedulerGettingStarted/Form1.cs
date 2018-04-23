using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraScheduler;


namespace SchedulerGettingStarted
{
    public partial class Form1 : RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            schedulerControl.Start = System.DateTime.Now;
            schedulerControl.WorkWeekView.TimeIndicatorDisplayOptions.Visibility = TimeIndicatorVisibility.CurrentDate;
            schedulerControl.WorkWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment = true;

        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            this.resourcesTableAdapter.Fill(this.schedulerTestDataSet.Resources);
            // TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            this.appointmentsTableAdapter.Fill(this.schedulerTestDataSet.Appointments);

        }
        private void OnAppointmentChangedInsertedDeleted(object sender, PersistentObjectsEventArgs e)
        {
            appointmentsTableAdapter.Update(schedulerTestDataSet);
            schedulerTestDataSet.AcceptChanges();
        }

        private void schedulerControl_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
           

        }

        private void schedulerControl_EditAppointmentFormShowing_1(object sender, AppointmentFormEventArgs e)
        {

        }

        private void schedulerControl_EditAppointmentFormShowing_2(object sender, AppointmentFormEventArgs e)
        {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ((DevExpress.XtraScheduler.SchedulerControl)(sender));
            Scheduler.CustomAppointmentForm form = new Scheduler.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm);
            try
            {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            }
            finally
            {
                form.Dispose();
            }

        }
    }
}