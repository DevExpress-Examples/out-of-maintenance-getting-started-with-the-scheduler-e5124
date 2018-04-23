Imports DevExpress.XtraScheduler.UI
Namespace Scheduler
    Partial Public Class CustomAppointmentForm
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If components IsNot Nothing Then
                    components.Dispose()
                End If
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(CustomAppointmentForm))
            Me.lblSubject = New DevExpress.XtraEditors.LabelControl()
            Me.lblLocation = New DevExpress.XtraEditors.LabelControl()
            Me.tbSubject = New DevExpress.XtraEditors.TextEdit()
            Me.lblLabel = New DevExpress.XtraEditors.LabelControl()
            Me.lblStartTime = New DevExpress.XtraEditors.LabelControl()
            Me.lblEndTime = New DevExpress.XtraEditors.LabelControl()
            Me.chkAllDay = New DevExpress.XtraEditors.CheckEdit()
            Me.lblShowTimeAs = New DevExpress.XtraEditors.LabelControl()
            Me.btnOk = New DevExpress.XtraEditors.SimpleButton()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.btnRecurrence = New DevExpress.XtraEditors.SimpleButton()
            Me.edtStartDate = New DevExpress.XtraEditors.DateEdit()
            Me.edtEndDate = New DevExpress.XtraEditors.DateEdit()
            Me.chkReminder = New DevExpress.XtraEditors.CheckEdit()
            Me.tbDescription = New DevExpress.XtraEditors.MemoEdit()
            Me.lblResource = New DevExpress.XtraEditors.LabelControl()
            Me.tbLocation = New DevExpress.XtraEditors.TextEdit()
            Me.panel1 = New DevExpress.XtraEditors.PanelControl()
            Me.edtResource = New DevExpress.XtraScheduler.UI.AppointmentResourceEdit()
            Me.edtResources = New DevExpress.XtraScheduler.UI.AppointmentResourcesEdit()
            Me.cbReminder = New DevExpress.XtraScheduler.UI.DurationEdit()
            Me.edtLabel = New DevExpress.XtraScheduler.UI.AppointmentLabelEdit()
            Me.progressPanel = New System.Windows.Forms.Panel()
            Me.tbProgress = New DevExpress.XtraEditors.TrackBarControl()
            Me.lblPercentCompleteValue = New DevExpress.XtraEditors.LabelControl()
            Me.lblPercentComplete = New DevExpress.XtraEditors.LabelControl()
            Me.edtStartTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
            Me.edtEndTime = New DevExpress.XtraScheduler.UI.SchedulerTimeEdit()
            Me.edtShowTimeAs = New DevExpress.XtraScheduler.UI.AppointmentStatusEdit()
            Me.label1 = New System.Windows.Forms.Label()
            Me.tbContacts = New DevExpress.XtraEditors.MemoEdit()
            DirectCast(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.panel1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            DirectCast(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.progressPanel.SuspendLayout()
            DirectCast(Me.tbProgress, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tbContacts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' lblSubject
            ' 
            resources.ApplyResources(Me.lblSubject, "lblSubject")
            Me.lblSubject.Name = "lblSubject"
            ' 
            ' lblLocation
            ' 
            resources.ApplyResources(Me.lblLocation, "lblLocation")
            Me.lblLocation.Name = "lblLocation"
            ' 
            ' tbSubject
            ' 
            resources.ApplyResources(Me.tbSubject, "tbSubject")
            Me.tbSubject.Name = "tbSubject"
            Me.tbSubject.Properties.AccessibleName = resources.GetString("tbSubject.Properties.AccessibleName")
            ' 
            ' lblLabel
            ' 
            resources.ApplyResources(Me.lblLabel, "lblLabel")
            Me.lblLabel.Appearance.BackColor = (DirectCast(resources.GetObject("lblLabel.Appearance.BackColor"), System.Drawing.Color))
            Me.lblLabel.Name = "lblLabel"
            ' 
            ' lblStartTime
            ' 
            resources.ApplyResources(Me.lblStartTime, "lblStartTime")
            Me.lblStartTime.Name = "lblStartTime"
            ' 
            ' lblEndTime
            ' 
            resources.ApplyResources(Me.lblEndTime, "lblEndTime")
            Me.lblEndTime.Name = "lblEndTime"
            ' 
            ' chkAllDay
            ' 
            resources.ApplyResources(Me.chkAllDay, "chkAllDay")
            Me.chkAllDay.Name = "chkAllDay"
            Me.chkAllDay.Properties.AccessibleName = resources.GetString("chkAllDay.Properties.AccessibleName")
            Me.chkAllDay.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.CheckButton
            Me.chkAllDay.Properties.AutoWidth = True
            Me.chkAllDay.Properties.Caption = resources.GetString("chkAllDay.Properties.Caption")
            ' 
            ' lblShowTimeAs
            ' 
            resources.ApplyResources(Me.lblShowTimeAs, "lblShowTimeAs")
            Me.lblShowTimeAs.Name = "lblShowTimeAs"
            ' 
            ' btnOk
            ' 
            resources.ApplyResources(Me.btnOk, "btnOk")
            Me.btnOk.Name = "btnOk"
            ' 
            ' btnCancel
            ' 
            resources.ApplyResources(Me.btnCancel, "btnCancel")
            Me.btnCancel.CausesValidation = False
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.Name = "btnCancel"
            ' 
            ' btnDelete
            ' 
            resources.ApplyResources(Me.btnDelete, "btnDelete")
            Me.btnDelete.CausesValidation = False
            Me.btnDelete.Name = "btnDelete"
            ' 
            ' btnRecurrence
            ' 
            resources.ApplyResources(Me.btnRecurrence, "btnRecurrence")
            Me.btnRecurrence.Name = "btnRecurrence"
            ' 
            ' edtStartDate
            ' 
            resources.ApplyResources(Me.edtStartDate, "edtStartDate")
            Me.edtStartDate.Name = "edtStartDate"
            Me.edtStartDate.Properties.AccessibleName = resources.GetString("edtStartDate.Properties.AccessibleName")
            Me.edtStartDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("edtStartDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.edtStartDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtStartDate.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.edtStartDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
            ' 
            ' edtEndDate
            ' 
            resources.ApplyResources(Me.edtEndDate, "edtEndDate")
            Me.edtEndDate.Name = "edtEndDate"
            Me.edtEndDate.Properties.AccessibleName = resources.GetString("edtEndDate.Properties.AccessibleName")
            Me.edtEndDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("edtEndDate.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.edtEndDate.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.edtEndDate.Properties.FirstDayOfWeek = System.DayOfWeek.Sunday
            Me.edtEndDate.Properties.MaxValue = New Date(4000, 1, 1, 0, 0, 0, 0)
            ' 
            ' chkReminder
            ' 
            resources.ApplyResources(Me.chkReminder, "chkReminder")
            Me.chkReminder.Name = "chkReminder"
            Me.chkReminder.Properties.AutoWidth = True
            Me.chkReminder.Properties.Caption = resources.GetString("chkReminder.Properties.Caption")
            ' 
            ' tbDescription
            ' 
            resources.ApplyResources(Me.tbDescription, "tbDescription")
            Me.tbDescription.Name = "tbDescription"
            Me.tbDescription.Properties.AccessibleName = resources.GetString("tbDescription.Properties.AccessibleName")
            Me.tbDescription.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.Client
            ' 
            ' lblResource
            ' 
            resources.ApplyResources(Me.lblResource, "lblResource")
            Me.lblResource.Name = "lblResource"
            ' 
            ' tbLocation
            ' 
            resources.ApplyResources(Me.tbLocation, "tbLocation")
            Me.tbLocation.Name = "tbLocation"
            Me.tbLocation.Properties.AccessibleName = resources.GetString("tbLocation.Properties.AccessibleName")
            ' 
            ' panel1
            ' 
            resources.ApplyResources(Me.panel1, "panel1")
            Me.panel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panel1.Controls.Add(Me.edtResource)
            Me.panel1.Controls.Add(Me.lblLabel)
            Me.panel1.Controls.Add(Me.lblResource)
            Me.panel1.Controls.Add(Me.edtResources)
            Me.panel1.Controls.Add(Me.cbReminder)
            Me.panel1.Controls.Add(Me.chkAllDay)
            Me.panel1.Controls.Add(Me.edtLabel)
            Me.panel1.Controls.Add(Me.chkReminder)
            Me.panel1.Name = "panel1"
            ' 
            ' edtResource
            ' 
            resources.ApplyResources(Me.edtResource, "edtResource")
            Me.edtResource.Name = "edtResource"
            Me.edtResource.Properties.AccessibleName = resources.GetString("edtResource.Properties.AccessibleName")
            Me.edtResource.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
            Me.edtResource.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("edtResource.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            ' 
            ' edtResources
            ' 
            resources.ApplyResources(Me.edtResources, "edtResources")
            Me.edtResources.Name = "edtResources"
            Me.edtResources.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("edtResources.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            ' 
            ' 
            ' 
            Me.edtResources.ResourcesCheckedListBoxControl.Location = (DirectCast(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.Location"), System.Drawing.Point))
            Me.edtResources.ResourcesCheckedListBoxControl.Name = ""
            Me.edtResources.ResourcesCheckedListBoxControl.TabIndex = (DirectCast(resources.GetObject("edtResources.ResourcesCheckedListBoxControl.TabIndex"), Integer))
            ' 
            ' cbReminder
            ' 
            resources.ApplyResources(Me.cbReminder, "cbReminder")
            Me.cbReminder.Name = "cbReminder"
            Me.cbReminder.Properties.AccessibleName = resources.GetString("cbReminder.Properties.AccessibleName")
            Me.cbReminder.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("cbReminder.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            Me.cbReminder.Properties.DisabledStateText = ""
            Me.cbReminder.Properties.ShowEmptyItem = False
            ' 
            ' edtLabel
            ' 
            resources.ApplyResources(Me.edtLabel, "edtLabel")
            Me.edtLabel.Name = "edtLabel"
            Me.edtLabel.Properties.AccessibleName = resources.GetString("edtLabel.Properties.AccessibleName")
            Me.edtLabel.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
            Me.edtLabel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("edtLabel.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            ' 
            ' progressPanel
            ' 
            resources.ApplyResources(Me.progressPanel, "progressPanel")
            Me.progressPanel.Controls.Add(Me.tbProgress)
            Me.progressPanel.Controls.Add(Me.lblPercentCompleteValue)
            Me.progressPanel.Controls.Add(Me.lblPercentComplete)
            Me.progressPanel.Name = "progressPanel"
            Me.progressPanel.TabStop = True
            ' 
            ' tbProgress
            ' 
            resources.ApplyResources(Me.tbProgress, "tbProgress")
            Me.tbProgress.Name = "tbProgress"
            Me.tbProgress.Properties.AutoSize = False
            Me.tbProgress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.tbProgress.Properties.Maximum = 100
            Me.tbProgress.Properties.ShowValueToolTip = True
            Me.tbProgress.Properties.TickFrequency = 10
            ' 
            ' lblPercentCompleteValue
            ' 
            resources.ApplyResources(Me.lblPercentCompleteValue, "lblPercentCompleteValue")
            Me.lblPercentCompleteValue.Appearance.BackColor = (DirectCast(resources.GetObject("lblPercentCompleteValue.Appearance.BackColor"), System.Drawing.Color))
            Me.lblPercentCompleteValue.Name = "lblPercentCompleteValue"
            ' 
            ' lblPercentComplete
            ' 
            resources.ApplyResources(Me.lblPercentComplete, "lblPercentComplete")
            Me.lblPercentComplete.Appearance.BackColor = (DirectCast(resources.GetObject("lblPercentComplete.Appearance.BackColor"), System.Drawing.Color))
            Me.lblPercentComplete.Name = "lblPercentComplete"
            ' 
            ' edtStartTime
            ' 
            resources.ApplyResources(Me.edtStartTime, "edtStartTime")
            Me.edtStartTime.Name = "edtStartTime"
            Me.edtStartTime.Properties.AccessibleName = resources.GetString("edtStartTime.Properties.AccessibleName")
            Me.edtStartTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            ' 
            ' edtEndTime
            ' 
            resources.ApplyResources(Me.edtEndTime, "edtEndTime")
            Me.edtEndTime.Name = "edtEndTime"
            Me.edtEndTime.Properties.AccessibleName = resources.GetString("edtEndTime.Properties.AccessibleName")
            Me.edtEndTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            ' 
            ' edtShowTimeAs
            ' 
            resources.ApplyResources(Me.edtShowTimeAs, "edtShowTimeAs")
            Me.edtShowTimeAs.Name = "edtShowTimeAs"
            Me.edtShowTimeAs.Properties.AccessibleName = resources.GetString("edtShowTimeAs.Properties.AccessibleName")
            Me.edtShowTimeAs.Properties.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox
            Me.edtShowTimeAs.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((DirectCast(resources.GetObject("edtShowTimeAs.Properties.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
            ' 
            ' label1
            ' 
            resources.ApplyResources(Me.label1, "label1")
            Me.label1.Name = "label1"
            ' 
            ' tbContacts
            ' 
            resources.ApplyResources(Me.tbContacts, "tbContacts")
            Me.tbContacts.Name = "tbContacts"
            ' 
            ' CustomAppointmentForm
            ' 
            Me.AcceptButton = Me.btnOk
            Me.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.btnCancel
            Me.Controls.Add(Me.tbContacts)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.tbDescription)
            Me.Controls.Add(Me.progressPanel)
            Me.Controls.Add(Me.panel1)
            Me.Controls.Add(Me.edtStartTime)
            Me.Controls.Add(Me.edtStartDate)
            Me.Controls.Add(Me.btnOk)
            Me.Controls.Add(Me.lblStartTime)
            Me.Controls.Add(Me.tbSubject)
            Me.Controls.Add(Me.lblLocation)
            Me.Controls.Add(Me.lblSubject)
            Me.Controls.Add(Me.tbLocation)
            Me.Controls.Add(Me.lblEndTime)
            Me.Controls.Add(Me.lblShowTimeAs)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.btnDelete)
            Me.Controls.Add(Me.btnRecurrence)
            Me.Controls.Add(Me.edtEndDate)
            Me.Controls.Add(Me.edtEndTime)
            Me.Controls.Add(Me.edtShowTimeAs)
            Me.Name = "CustomAppointmentForm"
            Me.ShowInTaskbar = False
            DirectCast(Me.tbSubject.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chkAllDay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtStartDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtStartDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtEndDate.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtEndDate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chkReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbDescription.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbLocation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.panel1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            Me.panel1.PerformLayout()
            DirectCast(Me.edtResource.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtResources.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtResources.ResourcesCheckedListBoxControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.cbReminder.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtLabel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.progressPanel.ResumeLayout(False)
            Me.progressPanel.PerformLayout()
            DirectCast(Me.tbProgress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbProgress, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtStartTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtEndTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.edtShowTimeAs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tbContacts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        #End Region

        Protected lblSubject As DevExpress.XtraEditors.LabelControl
        Protected lblLocation As DevExpress.XtraEditors.LabelControl
        Protected lblLabel As DevExpress.XtraEditors.LabelControl
        Protected lblStartTime As DevExpress.XtraEditors.LabelControl
        Protected lblEndTime As DevExpress.XtraEditors.LabelControl
        Protected lblShowTimeAs As DevExpress.XtraEditors.LabelControl
        Protected chkAllDay As DevExpress.XtraEditors.CheckEdit
        Protected WithEvents btnOk As DevExpress.XtraEditors.SimpleButton
        Protected btnCancel As DevExpress.XtraEditors.SimpleButton
        Protected WithEvents btnDelete As DevExpress.XtraEditors.SimpleButton
        Protected WithEvents btnRecurrence As DevExpress.XtraEditors.SimpleButton
        Protected edtStartDate As DevExpress.XtraEditors.DateEdit
        Protected edtEndDate As DevExpress.XtraEditors.DateEdit
        Protected edtStartTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit
        Protected edtEndTime As DevExpress.XtraScheduler.UI.SchedulerTimeEdit
        Protected edtLabel As DevExpress.XtraScheduler.UI.AppointmentLabelEdit
        Protected edtShowTimeAs As DevExpress.XtraScheduler.UI.AppointmentStatusEdit
        Protected tbSubject As DevExpress.XtraEditors.TextEdit
        Protected edtResource As DevExpress.XtraScheduler.UI.AppointmentResourceEdit
        Protected lblResource As DevExpress.XtraEditors.LabelControl
        Protected edtResources As DevExpress.XtraScheduler.UI.AppointmentResourcesEdit
        Protected chkReminder As DevExpress.XtraEditors.CheckEdit
        Protected tbDescription As DevExpress.XtraEditors.MemoEdit
        Protected cbReminder As DevExpress.XtraScheduler.UI.DurationEdit
        Private components As System.ComponentModel.IContainer = Nothing
        Protected tbLocation As DevExpress.XtraEditors.TextEdit
        Protected panel1 As DevExpress.XtraEditors.PanelControl
        Protected progressPanel As System.Windows.Forms.Panel
        Protected tbProgress As DevExpress.XtraEditors.TrackBarControl
        Protected lblPercentComplete As DevExpress.XtraEditors.LabelControl
        Protected lblPercentCompleteValue As DevExpress.XtraEditors.LabelControl
        Private label1 As System.Windows.Forms.Label
        Private tbContacts As DevExpress.XtraEditors.MemoEdit
    End Class
End Namespace
