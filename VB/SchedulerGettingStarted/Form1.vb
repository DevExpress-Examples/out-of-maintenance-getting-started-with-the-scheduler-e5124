Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraScheduler


Namespace SchedulerGettingStarted
    Partial Public Class Form1
        Inherits RibbonForm

        Public Sub New()
            InitializeComponent()
            InitSkinGallery()
            schedulerControl.Start = Date.Now
            schedulerControl.WorkWeekView.TimeIndicatorDisplayOptions.Visibility = TimeIndicatorVisibility.CurrentDate
            schedulerControl.WorkWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment = True

        End Sub
        Private Sub InitSkinGallery()
            SkinHelper.InitSkinGallery(rgbiSkins, True)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Resources' table. You can move, or remove it, as needed.
            Me.resourcesTableAdapter.Fill(Me.schedulerTestDataSet.Resources)
            ' TODO: This line of code loads data into the 'schedulerTestDataSet.Appointments' table. You can move, or remove it, as needed.
            Me.appointmentsTableAdapter.Fill(Me.schedulerTestDataSet.Appointments)

        End Sub
        Private Sub OnAppointmentChangedInsertedDeleted(ByVal sender As Object, ByVal e As PersistentObjectsEventArgs) Handles schedulerStorage.AppointmentsInserted, schedulerStorage.AppointmentsChanged, schedulerStorage.AppointmentsDeleted
            appointmentsTableAdapter.Update(schedulerTestDataSet)
            schedulerTestDataSet.AcceptChanges()
        End Sub

        Private Sub schedulerControl_EditAppointmentFormShowing(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = (DirectCast(sender, DevExpress.XtraScheduler.SchedulerControl))


        End Sub

        Private Sub schedulerControl_EditAppointmentFormShowing_1(ByVal sender As Object, ByVal e As AppointmentFormEventArgs)

        End Sub

        Private Sub schedulerControl_EditAppointmentFormShowing_2(ByVal sender As Object, ByVal e As AppointmentFormEventArgs) Handles schedulerControl.EditAppointmentFormShowing
            Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = (DirectCast(sender, DevExpress.XtraScheduler.SchedulerControl))
            Dim form As New Scheduler.CustomAppointmentForm(scheduler, e.Appointment, e.OpenRecurrenceForm)
            Try
                e.DialogResult = form.ShowDialog()
                e.Handled = True
            Finally
                form.Dispose()
            End Try

        End Sub
    End Class
End Namespace