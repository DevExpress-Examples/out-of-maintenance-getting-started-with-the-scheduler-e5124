Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports System.Reflection
Imports System.Windows.Forms
Imports DevExpress.Utils.Controls
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Localization
Imports DevExpress.XtraScheduler.Native
Imports DevExpress.XtraScheduler.UI
Imports DevExpress.Utils
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Native
Imports DevExpress.Utils.Internal
Imports System.Collections.Generic
Imports DevExpress.XtraScheduler.Internal

Namespace Scheduler
    Partial Public Class CustomAppointmentForm
        Inherits DevExpress.XtraEditors.XtraForm
        Implements IDXManagerPopupMenu

        #Region "Fields"
        Private _contacts As String

        Private openRecurrenceForm_Renamed As Boolean

        Private ReadOnly storage_Renamed As ISchedulerStorage

        Private ReadOnly control_Renamed As SchedulerControl

        Private recurringIcon_Renamed As Icon

        Private normalIcon_Renamed As Icon

        Private ReadOnly controller_Renamed As AppointmentFormController

        Private menuManager_Renamed As IDXMenuManager
        #End Region

        <EditorBrowsable(EditorBrowsableState.Never)> _
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment)
            Me.New(control, apt, False)
        End Sub
        Public Sub New(ByVal control As SchedulerControl, ByVal apt As Appointment, ByVal openRecurrenceForm As Boolean)
            Guard.ArgumentNotNull(control, "control")
            Guard.ArgumentNotNull(control.Storage, "control.Storage")
            Guard.ArgumentNotNull(apt, "apt")

            Me.openRecurrenceForm_Renamed = openRecurrenceForm
            Me.controller_Renamed = CreateController(control, apt)
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            SetupPredefinedConstraints()

            LoadIcons()

            Me.control_Renamed = control
            Me.storage_Renamed = control.Storage

            Me.edtShowTimeAs.Storage = Me.storage_Renamed
            Me.edtLabel.Storage = storage_Renamed
            Me.edtResource.SchedulerControl = control
            Me.edtResource.Storage = storage_Renamed
            Me.edtResources.SchedulerControl = control

            SubscribeControllerEvents(Controller)
            BindControllerToControls()

        End Sub
        #Region "Properties"
        Protected Overrides ReadOnly Property ShowMode() As FormShowMode
            Get
                Return DevExpress.XtraEditors.FormShowMode.AfterInitialization
            End Get
        End Property
        Public Property MenuManager() As IDXMenuManager
            Get
                Return menuManager_Renamed
            End Get
            Private Set(ByVal value As IDXMenuManager)
                menuManager_Renamed = value
            End Set
        End Property
        Protected Friend ReadOnly Property Controller() As AppointmentFormController
            Get
                Return controller_Renamed
            End Get
        End Property
        Protected Friend ReadOnly Property Control() As SchedulerControl
            Get
                Return control_Renamed
            End Get
        End Property
        Protected Friend ReadOnly Property Storage() As ISchedulerStorage
            Get
                Return storage_Renamed
            End Get
        End Property
        Protected Friend ReadOnly Property IsNewAppointment() As Boolean
            Get
                Return If(controller_Renamed IsNot Nothing, controller_Renamed.IsNewAppointment, True)
            End Get
        End Property
        Protected Friend ReadOnly Property RecurringIcon() As Icon
            Get
                Return recurringIcon_Renamed
            End Get
        End Property
        Protected Friend ReadOnly Property NormalIcon() As Icon
            Get
                Return normalIcon_Renamed
            End Get
        End Property
        Protected Friend ReadOnly Property OpenRecurrenceForm() As Boolean
            Get
                Return openRecurrenceForm_Renamed
            End Get
        End Property
        Public Property [ReadOnly]() As Boolean
            Get
                Return Controller IsNot Nothing AndAlso Controller.ReadOnly
            End Get
            Set(ByVal value As Boolean)
                If Controller.ReadOnly = value Then
                    Return
                End If
                Controller.ReadOnly = value
            End Set
        End Property
        #End Region
        #Region "#customformfields"
        Public Overridable Sub LoadFormData(ByVal appointment As Appointment)
            If appointment.CustomFields("Contacts") Is Nothing Then
                tbContacts.Text = ""
            Else
                _contacts = appointment.CustomFields("Contacts").ToString()
                tbContacts.Text = _contacts
            End If

        End Sub
        Public Overridable Function SaveFormData(ByVal appointment As Appointment) As Boolean
            appointment.CustomFields("Contacts") = tbContacts.Text
            Return True

        End Function
        Public Overridable Function IsAppointmentChanged(ByVal appointment As Appointment) As Boolean
            If _contacts = appointment.CustomFields("Contacts").ToString() Then
                Return False
            Else
                Return True
            End If
        End Function
        #End Region ' #customformfields              

        Public Overridable Sub SetMenuManager(ByVal menuManager As DevExpress.Utils.Menu.IDXMenuManager)
            MenuManagerUtils.SetMenuManager(Controls, menuManager)
            Me.menuManager_Renamed = menuManager
        End Sub

        Protected Friend Overridable Sub SetupPredefinedConstraints()
            Me.tbProgress.Properties.Minimum = AppointmentProcessValues.Min
            Me.tbProgress.Properties.Maximum = AppointmentProcessValues.Max
            Me.tbProgress.Properties.SmallChange = AppointmentProcessValues.Step
            Me.edtResources.Visible = True
        End Sub
        Protected Overridable Sub BindControllerToControls()
            BindControllerToIcon()
            BindProperties(Me.tbSubject, "Text", "Subject")
            BindProperties(Me.tbLocation, "Text", "Location")
            BindProperties(Me.tbDescription, "Text", "Description")
            BindProperties(Me.edtShowTimeAs, "Status", "Status")
            BindProperties(Me.edtStartDate, "EditValue", "DisplayStartDate")
            BindProperties(Me.edtStartDate, "Enabled", "IsDateTimeEditable")
            BindProperties(Me.edtStartTime, "EditValue", "DisplayStartTime")
            BindProperties(Me.edtStartTime, "Visible", "IsTimeVisible")
            BindProperties(Me.edtStartTime, "Enabled", "IsTimeVisible")
            BindProperties(Me.edtEndDate, "EditValue", "DisplayEndDate", DataSourceUpdateMode.Never)
            BindProperties(Me.edtEndDate, "Enabled", "IsDateTimeEditable", DataSourceUpdateMode.Never)
            BindProperties(Me.edtEndTime, "EditValue", "DisplayEndTime", DataSourceUpdateMode.Never)
            BindProperties(Me.edtEndTime, "Visible", "IsTimeVisible", DataSourceUpdateMode.Never)
            BindProperties(Me.edtEndTime, "Enabled", "IsTimeVisible", DataSourceUpdateMode.Never)
            BindProperties(Me.chkAllDay, "Checked", "AllDay")
            BindProperties(Me.chkAllDay, "Enabled", "IsDateTimeEditable")

            BindProperties(Me.edtResource, "ResourceId", "ResourceId")
            BindProperties(Me.edtResource, "Enabled", "CanEditResource")
            BindToBoolPropertyAndInvert(Me.edtResource, "Visible", "ResourceSharing")

            BindProperties(Me.edtResources, "ResourceIds", "ResourceIds")
            BindProperties(Me.edtResources, "Visible", "ResourceSharing")
            BindProperties(Me.edtResources, "Enabled", "CanEditResource")
            BindProperties(Me.lblResource, "Enabled", "CanEditResource")

            BindProperties(Me.edtLabel, "Label", "Label")
            BindProperties(Me.chkReminder, "Enabled", "ReminderVisible")
            BindProperties(Me.chkReminder, "Visible", "ReminderVisible")
            BindProperties(Me.chkReminder, "Checked", "HasReminder")
            BindProperties(Me.cbReminder, "Enabled", "HasReminder")
            BindProperties(Me.cbReminder, "Visible", "ReminderVisible")
            BindProperties(Me.cbReminder, "Duration", "ReminderTimeBeforeStart")

            BindProperties(Me.tbProgress, "Value", "PercentComplete")
            BindProperties(Me.lblPercentCompleteValue, "Text", "PercentComplete", AddressOf ObjectToStringConverter)
            BindProperties(Me.progressPanel, "Visible", "ShouldEditTaskProgress")
            BindToBoolPropertyAndInvert(Me.btnOk, "Enabled", "ReadOnly")
            BindToBoolPropertyAndInvert(Me.btnRecurrence, "Enabled", "ReadOnly")
            BindProperties(Me.btnDelete, "Enabled", "CanDeleteAppointment")
            BindProperties(Me.btnRecurrence, "Visible", "ShouldShowRecurrenceButton")
        End Sub
        Protected Overridable Sub BindControllerToIcon()
            Dim binding As New Binding("Icon", Controller, "AppointmentType")
            AddHandler binding.Format, AddressOf AppointmentTypeToIconConverter
            DataBindings.Add(binding)
        End Sub
        Protected Overridable Sub ObjectToStringConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
            e.Value = e.Value.ToString()
        End Sub
        Protected Overridable Sub AppointmentTypeToIconConverter(ByVal o As Object, ByVal e As ConvertEventArgs)
            Dim type As AppointmentType = DirectCast(e.Value, AppointmentType)
            If type = AppointmentType.Pattern Then
                e.Value = RecurringIcon
            Else
                e.Value = NormalIcon
            End If
        End Sub
        Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
            BindProperties(target, targetProperty, sourceProperty, DataSourceUpdateMode.OnPropertyChanged)
        End Sub
        Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal updateMode As DataSourceUpdateMode)
            target.DataBindings.Add(targetProperty, Controller, sourceProperty, True, updateMode)
        End Sub
        Protected Overridable Sub BindProperties(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String, ByVal objectToStringConverter As ConvertEventHandler)
            Dim binding As New Binding(targetProperty, Controller, sourceProperty, True)
            AddHandler binding.Format, objectToStringConverter
            target.DataBindings.Add(binding)
        End Sub
        Protected Overridable Sub BindToBoolPropertyAndInvert(ByVal target As Control, ByVal targetProperty As String, ByVal sourceProperty As String)
            target.DataBindings.Add(New BoolInvertBinding(targetProperty, Controller, sourceProperty))
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            If Controller Is Nothing Then
                Return
            End If
            Me.DataBindings.Add("Text", Controller, "Caption")
            SubscribeControlsEvents()
            LoadFormData(Controller.EditedAppointmentCopy)
            RecalculateLayoutOfControlsAffectedByProgressPanel()
        End Sub
        Protected Overridable Function CreateController(ByVal control As SchedulerControl, ByVal apt As Appointment) As AppointmentFormController
            Return New AppointmentFormController(control, apt)
        End Function
        Private Sub SubscribeControllerEvents(ByVal controller As AppointmentFormController)
            If controller Is Nothing Then
                Return
            End If
            AddHandler controller.PropertyChanged, AddressOf OnControllerPropertyChanged
        End Sub
        Private Sub OnControllerPropertyChanged(ByVal sender As Object, ByVal e As PropertyChangedEventArgs)
            If e.PropertyName = "ReadOnly" Then
                UpdateReadonly()
            End If
        End Sub
        Protected Overridable Sub UpdateReadonly()
            If Controller Is Nothing Then
                Return
            End If
            Dim controls As IList(Of Control) = GetAllControls(Me)

            For Each control_Renamed As Control In controls
                Dim editor As BaseEdit = TryCast(control_Renamed, BaseEdit)
                If editor Is Nothing Then
                    Continue For
                End If
                editor.ReadOnly = Controller.ReadOnly
            Next control_Renamed
            Me.btnOk.Enabled = Not Controller.ReadOnly
            Me.btnRecurrence.Enabled = Not Controller.ReadOnly
        End Sub

        Private Function GetAllControls(ByVal rootControl As Control) As List(Of Control)
            Dim result As New List(Of Control)()

            For Each control_Renamed As Control In rootControl.Controls
                result.Add(control_Renamed)
                Dim childControls As IList(Of Control) = GetAllControls(control_Renamed)
                result.AddRange(childControls)
            Next control_Renamed
            Return result
        End Function
        Protected Friend Overridable Sub LoadIcons()
            Dim asm As System.Reflection.Assembly = GetType(SchedulerControl).Assembly
            recurringIcon_Renamed = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.RecurringAppointment, asm)
            normalIcon_Renamed = ResourceImageHelper.CreateIconFromResources(SchedulerIconNames.Appointment, asm)
        End Sub
        Protected Friend Overridable Sub SubscribeControlsEvents()
            AddHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
            AddHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
            AddHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
            AddHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
            AddHandler cbReminder.InvalidValue, AddressOf OnCbReminderInvalidValue
            AddHandler cbReminder.Validating, AddressOf OnCbReminderValidating
        End Sub
        Protected Friend Overridable Sub UnsubscribeControlsEvents()
            RemoveHandler edtEndDate.Validating, AddressOf OnEdtEndDateValidating
            RemoveHandler edtEndDate.InvalidValue, AddressOf OnEdtEndDateInvalidValue
            RemoveHandler edtEndTime.Validating, AddressOf OnEdtEndTimeValidating
            RemoveHandler edtEndTime.InvalidValue, AddressOf OnEdtEndTimeInvalidValue
            RemoveHandler cbReminder.InvalidValue, AddressOf OnCbReminderInvalidValue
            RemoveHandler cbReminder.Validating, AddressOf OnCbReminderValidating
        End Sub
        Private Sub OnBtnOkClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnOk.Click
            OnOkButton()
        End Sub
        Protected Friend Overridable Sub OnEdtEndDateValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not IsValidInterval()
            If Not e.Cancel Then
                Me.edtEndDate.DataBindings("EditValue").WriteValue()
            End If
        End Sub
        Protected Friend Overridable Sub OnEdtEndDateInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        End Sub
        Protected Friend Overridable Sub OnEdtEndTimeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            e.Cancel = Not IsValidInterval()
            If Not e.Cancel Then
                Me.edtEndTime.DataBindings("EditValue").WriteValue()
            End If
        End Sub
        Protected Friend Overridable Sub OnEdtEndTimeInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidEndDate)
        End Sub
        Protected Friend Overridable Function IsValidInterval() As Boolean
            Return AppointmentFormControllerBase.ValidateInterval(edtStartDate.DateTime.Date, edtStartTime.Time.TimeOfDay, edtEndDate.DateTime.Date, edtEndTime.Time.TimeOfDay)
        End Function
        Protected Friend Overridable Sub OnOkButton()
            If Not SaveFormData(Controller.EditedAppointmentCopy) Then
                Return
            End If
            If Not Controller.IsConflictResolved() Then
                ShowMessageBox(SchedulerLocalizer.GetString(SchedulerStringId.Msg_Conflict), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
            If Controller.IsAppointmentChanged() OrElse Controller.IsNewAppointment OrElse IsAppointmentChanged(Controller.EditedAppointmentCopy) Then
                Controller.ApplyChanges()
            End If

            Me.DialogResult = DialogResult.OK
        End Sub
        Protected Friend Overridable Function ShowMessageBox(ByVal text As String, ByVal caption As String, ByVal buttons As MessageBoxButtons, ByVal icon As MessageBoxIcon) As DialogResult
            Return XtraMessageBox.Show(Me, text, caption, buttons, icon)
        End Function
        Private Sub OnBtnDeleteClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDelete.Click
            OnDeleteButton()
        End Sub
        Protected Friend Overridable Sub OnDeleteButton()
            If IsNewAppointment Then
                Return
            End If

            Controller.DeleteAppointment()

            DialogResult = DialogResult.Abort
            Close()
        End Sub
        Private Sub OnBtnRecurrenceClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRecurrence.Click
            OnRecurrenceButton()
        End Sub
        Protected Friend Overridable Sub OnRecurrenceButton()
            If Not Controller.ShouldShowRecurrenceButton Then
                Return
            End If

            Dim patternCopy As Appointment = Controller.PrepareToRecurrenceEdit()

            Dim result As DialogResult
            Using form As Form = CreateAppointmentRecurrenceForm(patternCopy, Control.OptionsView.FirstDayOfWeek)
                result = ShowRecurrenceForm(form)
            End Using

            If result = DialogResult.Abort Then
                Controller.RemoveRecurrence()
            ElseIf result = DialogResult.OK Then
                Controller.ApplyRecurrence(patternCopy)
            End If
        End Sub
        Protected Overridable Function ShowRecurrenceForm(ByVal form As Form) As DialogResult
            Return FormTouchUIAdapter.ShowDialog(form, Me)
        End Function
        Protected Friend Overridable Function CreateAppointmentRecurrenceForm(ByVal patternCopy As Appointment, ByVal firstDayOfWeek As FirstDayOfWeek) As Form
            Dim form As New AppointmentRecurrenceForm(patternCopy, firstDayOfWeek, Controller)
            form.SetMenuManager(MenuManager)
            form.LookAndFeel.ParentLookAndFeel = LookAndFeel
            form.ShowExceptionsRemoveMsgBox = controller_Renamed.AreExceptionsPresent()
            Return form
        End Function
        Friend Sub OnAppointmentFormActivated(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Activated
            If openRecurrenceForm_Renamed Then
                openRecurrenceForm_Renamed = False
                OnRecurrenceButton()
            End If
        End Sub
        Protected Friend Overridable Sub OnCbReminderValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            Dim span As TimeSpan = cbReminder.Duration
            e.Cancel = (span = TimeSpan.MinValue) OrElse (span.Ticks < 0)
            If Not e.Cancel Then
                Me.cbReminder.DataBindings("Duration").WriteValue()
            End If
        End Sub
        Protected Friend Overridable Sub OnCbReminderInvalidValue(ByVal sender As Object, ByVal e As InvalidValueExceptionEventArgs)
            e.ErrorText = SchedulerLocalizer.GetString(SchedulerStringId.Msg_InvalidReminderTimeBeforeStart)
        End Sub
        Protected Friend Overridable Sub RecalculateLayoutOfControlsAffectedByProgressPanel()
            If progressPanel.Visible Then
                Return
            End If
            Dim intDeltaY As Integer = progressPanel.Height
            tbDescription.Location = New Point(tbDescription.Location.X, tbDescription.Location.Y - intDeltaY)
            tbDescription.Size = New Size(tbDescription.Size.Width, tbDescription.Size.Height + intDeltaY)
        End Sub
    End Class
End Namespace