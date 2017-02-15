using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CultureExplorer.Properties;

namespace CultureExplorer
{
    /// <summary>
    ///     Summary description for CalendarForm.
    /// </summary>
    public class CalendarForm : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private CultureExplorerLabel _algorithm;
        private CultureExplorerLabel _am;
        private Button _buttonClose;
        private CheckBox _checkGenitiveMonths;
        private ColumnHeader _columnDay;
        private ColumnHeader _columnDayAbbr;
        private ColumnHeader _columnDayShortest;
        private ColumnHeader _columnMonth;
        private ColumnHeader _columnMonthAbbr;

        private CultureInfo _culture;
        private CultureExplorerLabel _currentEra;
        private CultureExplorerLabel _firstDay;
        private GroupBox _groupBoxCalendar;
        private GroupBox _groupBoxDays;
        private GroupBox _groupBoxMonths;
        private GroupBox _groupBoxTime;
        private Label _labelAlgorithm;
        private Label _labelAm;
        private Label _labelDays;
        private Label _labelEra;
        private Label _labelFirstDay;
        private Label _labelMonths;
        private Label _labelMonthsPerYear;
        private Label _labelNativeName;
        private Label _labelPm;
        private CultureExplorerListView _listDays;
        private CultureExplorerListView _listMonths;
        private CultureExplorerLabel _monthsPerYear;
        private CultureExplorerLabel _nativeName;
        private CultureExplorerLabel _pm;

        public CalendarForm(CultureInfo ci)
        {
            InitializeComponent();
            UpdateCulture(ci);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                if (_components != null)
                    _components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            var resources = new ComponentResourceManager(typeof(CalendarForm));
            _buttonClose = new Button();
            _labelFirstDay = new Label();
            _groupBoxDays = new System.Windows.Forms.GroupBox();
            _labelDays = new Label();
            _firstDay = new CultureExplorerLabel();
            _listDays = new CultureExplorerListView();
            _columnDay = new System.Windows.Forms.ColumnHeader();
            _columnDayAbbr = new System.Windows.Forms.ColumnHeader();
            _columnDayShortest = new System.Windows.Forms.ColumnHeader();
            _groupBoxMonths = new System.Windows.Forms.GroupBox();
            _checkGenitiveMonths = new System.Windows.Forms.CheckBox();
            _labelMonths = new Label();
            _listMonths = new CultureExplorerListView();
            _columnMonth = new System.Windows.Forms.ColumnHeader();
            _columnMonthAbbr = new System.Windows.Forms.ColumnHeader();
            _monthsPerYear = new CultureExplorerLabel();
            _labelMonthsPerYear = new Label();
            _groupBoxTime = new System.Windows.Forms.GroupBox();
            _pm = new CultureExplorerLabel();
            _labelPm = new Label();
            _am = new CultureExplorerLabel();
            _labelAm = new Label();
            _labelAlgorithm = new Label();
            _groupBoxCalendar = new System.Windows.Forms.GroupBox();
            _currentEra = new CultureExplorerLabel();
            _labelEra = new Label();
            _nativeName = new CultureExplorerLabel();
            _labelNativeName = new Label();
            _algorithm = new CultureExplorerLabel();
            _groupBoxDays.SuspendLayout();
            _groupBoxMonths.SuspendLayout();
            _groupBoxTime.SuspendLayout();
            _groupBoxCalendar.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            resources.ApplyResources(_buttonClose, "_buttonClose");
            _buttonClose.Name = "_buttonClose";
            _buttonClose.Click += new System.EventHandler(buttonClose_Click);
            // 
            // labelFirstDay
            // 
            resources.ApplyResources(_labelFirstDay, "_labelFirstDay");
            _labelFirstDay.Name = "_labelFirstDay";
            // 
            // groupBoxDays
            // 
            _groupBoxDays.Controls.Add(_labelDays);
            _groupBoxDays.Controls.Add(_firstDay);
            _groupBoxDays.Controls.Add(_listDays);
            _groupBoxDays.Controls.Add(_labelFirstDay);
            _groupBoxDays.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupBoxDays, "_groupBoxDays");
            _groupBoxDays.Name = "_groupBoxDays";
            _groupBoxDays.TabStop = false;
            // 
            // labelDays
            // 
            resources.ApplyResources(_labelDays, "_labelDays");
            _labelDays.Name = "_labelDays";
            // 
            // FirstDay
            // 
            _firstDay.BackColor = System.Drawing.SystemColors.Info;
            _firstDay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _firstDay.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_firstDay, "_firstDay");
            _firstDay.Name = "_firstDay";
            // 
            // listDays
            // 
            _listDays.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                _columnDay,
                _columnDayAbbr,
                _columnDayShortest
            });
            _listDays.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_listDays, "_listDays");
            _listDays.FullRowSelect = true;
            _listDays.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            _listDays.Name = "_listDays";
            _listDays.UseCompatibleStateImageBehavior = false;
            _listDays.View = System.Windows.Forms.View.Details;
            // 
            // columnDay
            // 
            resources.ApplyResources(_columnDay, "_columnDay");
            // 
            // columnDayAbbr
            // 
            resources.ApplyResources(_columnDayAbbr, "_columnDayAbbr");
            // 
            // columnDayShortest
            // 
            resources.ApplyResources(_columnDayShortest, "_columnDayShortest");
            // 
            // groupBoxMonths
            // 
            _groupBoxMonths.Controls.Add(_checkGenitiveMonths);
            _groupBoxMonths.Controls.Add(_labelMonths);
            _groupBoxMonths.Controls.Add(_listMonths);
            _groupBoxMonths.Controls.Add(_monthsPerYear);
            _groupBoxMonths.Controls.Add(_labelMonthsPerYear);
            _groupBoxMonths.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupBoxMonths, "_groupBoxMonths");
            _groupBoxMonths.Name = "_groupBoxMonths";
            _groupBoxMonths.TabStop = false;
            // 
            // checkGenitiveMonths
            // 
            resources.ApplyResources(_checkGenitiveMonths, "_checkGenitiveMonths");
            _checkGenitiveMonths.Name = "_checkGenitiveMonths";
            _checkGenitiveMonths.UseVisualStyleBackColor = true;
            _checkGenitiveMonths.CheckedChanged += new System.EventHandler(checkGenitiveMonths_CheckedChanged);
            // 
            // labelMonths
            // 
            resources.ApplyResources(_labelMonths, "_labelMonths");
            _labelMonths.Name = "_labelMonths";
            // 
            // listMonths
            // 
            _listMonths.Columns.AddRange(new System.Windows.Forms.ColumnHeader[]
            {
                _columnMonth,
                _columnMonthAbbr
            });
            _listMonths.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_listMonths, "_listMonths");
            _listMonths.FullRowSelect = true;
            _listMonths.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            _listMonths.Name = "_listMonths";
            _listMonths.UseCompatibleStateImageBehavior = false;
            _listMonths.View = System.Windows.Forms.View.Details;
            // 
            // columnMonth
            // 
            resources.ApplyResources(_columnMonth, "_columnMonth");
            // 
            // columnMonthAbbr
            // 
            resources.ApplyResources(_columnMonthAbbr, "_columnMonthAbbr");
            // 
            // MonthsPerYear
            // 
            _monthsPerYear.BackColor = System.Drawing.SystemColors.Info;
            _monthsPerYear.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _monthsPerYear.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_monthsPerYear, "_monthsPerYear");
            _monthsPerYear.Name = "_monthsPerYear";
            // 
            // labelMonthsPerYear
            // 
            resources.ApplyResources(_labelMonthsPerYear, "_labelMonthsPerYear");
            _labelMonthsPerYear.Name = "_labelMonthsPerYear";
            // 
            // groupBoxTime
            // 
            _groupBoxTime.Controls.Add(_pm);
            _groupBoxTime.Controls.Add(_labelPm);
            _groupBoxTime.Controls.Add(_am);
            _groupBoxTime.Controls.Add(_labelAm);
            _groupBoxTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupBoxTime, "_groupBoxTime");
            _groupBoxTime.Name = "_groupBoxTime";
            _groupBoxTime.TabStop = false;
            // 
            // PM
            // 
            _pm.BackColor = System.Drawing.SystemColors.Info;
            _pm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _pm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_pm, "_pm");
            _pm.Name = "_pm";
            // 
            // labelPM
            // 
            resources.ApplyResources(_labelPm, "_labelPm");
            _labelPm.Name = "_labelPm";
            // 
            // AM
            // 
            _am.BackColor = System.Drawing.SystemColors.Info;
            _am.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _am.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_am, "_am");
            _am.Name = "_am";
            // 
            // labelAM
            // 
            resources.ApplyResources(_labelAm, "_labelAm");
            _labelAm.Name = "_labelAm";
            // 
            // labelAlgorithm
            // 
            resources.ApplyResources(_labelAlgorithm, "_labelAlgorithm");
            _labelAlgorithm.Name = "_labelAlgorithm";
            // 
            // groupBoxCalendar
            // 
            _groupBoxCalendar.Controls.Add(_currentEra);
            _groupBoxCalendar.Controls.Add(_labelEra);
            _groupBoxCalendar.Controls.Add(_nativeName);
            _groupBoxCalendar.Controls.Add(_labelNativeName);
            _groupBoxCalendar.Controls.Add(_labelAlgorithm);
            _groupBoxCalendar.Controls.Add(_algorithm);
            resources.ApplyResources(_groupBoxCalendar, "_groupBoxCalendar");
            _groupBoxCalendar.Name = "_groupBoxCalendar";
            _groupBoxCalendar.TabStop = false;
            // 
            // CurrentEra
            // 
            _currentEra.BackColor = System.Drawing.SystemColors.Info;
            _currentEra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _currentEra.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_currentEra, "_currentEra");
            _currentEra.Name = "_currentEra";
            // 
            // labelEra
            // 
            resources.ApplyResources(_labelEra, "_labelEra");
            _labelEra.Name = "_labelEra";
            // 
            // NativeName
            // 
            _nativeName.BackColor = System.Drawing.SystemColors.Info;
            _nativeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _nativeName.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_nativeName, "_nativeName");
            _nativeName.Name = "_nativeName";
            // 
            // labelNativeName
            // 
            resources.ApplyResources(_labelNativeName, "_labelNativeName");
            _labelNativeName.Name = "_labelNativeName";
            // 
            // Algorithm
            // 
            _algorithm.BackColor = System.Drawing.SystemColors.Info;
            _algorithm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _algorithm.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_algorithm, "_algorithm");
            _algorithm.Name = "_algorithm";
            // 
            // CalendarForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(_groupBoxCalendar);
            Controls.Add(_groupBoxTime);
            Controls.Add(_groupBoxMonths);
            Controls.Add(_groupBoxDays);
            Controls.Add(_buttonClose);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "CalendarForm";
            ShowInTaskbar = false;
            Closing += new System.ComponentModel.CancelEventHandler(OnClosing);
            _groupBoxDays.ResumeLayout(false);
            _groupBoxMonths.ResumeLayout(false);
            _groupBoxMonths.PerformLayout();
            _groupBoxTime.ResumeLayout(false);
            _groupBoxCalendar.ResumeLayout(false);
            _groupBoxCalendar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public void UpdateCulture(CultureInfo ci)
        {
            _culture = ci;
            if (null == ci)
            {
                _firstDay.Text = string.Empty;
                _am.Text = string.Empty;
                _pm.Text = string.Empty;
                _algorithm.Text = string.Empty;
                _nativeName.Text = string.Empty;
                _currentEra.Text = string.Empty;
                _checkGenitiveMonths.Enabled = false;
            }
            else if (ci.IsNeutralCulture)
            {
                _firstDay.Text = Resources.NotAvailable;
                _am.Text = Resources.NotAvailable;
                _pm.Text = Resources.NotAvailable;
                _algorithm.Text = Resources.NotAvailable;
                _nativeName.Text = Resources.NotAvailable;
                _currentEra.Text = Resources.NotAvailable;
                _checkGenitiveMonths.Enabled = false;
            }
            else
            {
                var firstDay = ci.DateTimeFormat.FirstDayOfWeek;

                _firstDay.Text = ci.DateTimeFormat.GetDayName(firstDay);
                _am.Text = ci.DateTimeFormat.AMDesignator;
                _pm.Text = ci.DateTimeFormat.PMDesignator;
                _nativeName.Text = ci.DateTimeFormat.NativeCalendarName;
                _currentEra.Text = ci.DateTimeFormat.GetEraName(ci.DateTimeFormat.Calendar.GetEra(DateTime.Now));

                _checkGenitiveMonths.Enabled = AreGenitiveMonthsSignificant(ci.DateTimeFormat);

                switch (ci.DateTimeFormat.Calendar.AlgorithmType)
                {
                    case CalendarAlgorithmType.LunarCalendar:
                        _algorithm.Text = Resources.LunarCalendarType;
                        break;

                    case CalendarAlgorithmType.LunisolarCalendar:
                        _algorithm.Text = Resources.LuniSolarCalendarType;
                        break;

                    case CalendarAlgorithmType.SolarCalendar:
                        _algorithm.Text = Resources.SolarCalendarType;
                        break;

                    case CalendarAlgorithmType.Unknown:
                        _algorithm.Text = Resources.UnknowCalendarType;
                        break;
                }
            }

            UpdateDayInfo(ci);
            UpdateMonthInfo(ci, _checkGenitiveMonths.Checked);
        }

        private void UpdateDayInfo(CultureInfo ci)
        {
            _listDays.Items.Clear();

            if (null == ci || ci.IsNeutralCulture)
            {
                _listDays.RightToLeft = RightToLeft.No;
                _listDays.RightToLeftLayout = false;
            }

            else
            {
                var names = new string[3];
                var dayNames = ci.DateTimeFormat.DayNames;
                var abbDayNames = ci.DateTimeFormat.AbbreviatedDayNames;

                _listDays.RightToLeft = ci.TextInfo.IsRightToLeft ? RightToLeft.Yes : RightToLeft.No;
                _listDays.RightToLeftLayout = ci.TextInfo.IsRightToLeft ? true : false;

                var firstDay = ci.DateTimeFormat.FirstDayOfWeek;
                DayOfWeek currentDay;

                // in order to fill the days information correctly for the current
                // culture, we need to do a bit of work in order to start showing 
                // the days with the first day of the week for this culture.
                var daysPerWeek = dayNames.Length;
                for (var i = 0; i < daysPerWeek; i++)
                {
                    currentDay = (DayOfWeek) (((int) firstDay + i) % daysPerWeek);
                    names[0] = ci.DateTimeFormat.GetDayName(currentDay);
                    names[1] = ci.DateTimeFormat.GetAbbreviatedDayName(currentDay);
                    names[2] = ci.DateTimeFormat.GetShortestDayName(currentDay);
                    _listDays.Items.Add(new ListViewItem(names));
                }
            }
        }

        private void UpdateMonthInfo(CultureInfo ci, bool useGenitiveMonthNames)
        {
            _listMonths.Items.Clear();

            if (null == ci)
            {
                _monthsPerYear.Text = string.Empty;
                _listMonths.RightToLeft = RightToLeft.No;
                _listMonths.RightToLeftLayout = false;
            }
            else if (ci.IsNeutralCulture)
            {
                _monthsPerYear.Text = Resources.NotAvailable;
                _listMonths.RightToLeft = RightToLeft.No;
                _listMonths.RightToLeftLayout = false;
            }
            else
            {
                _listMonths.RightToLeft = ci.TextInfo.IsRightToLeft ? RightToLeft.Yes : RightToLeft.No;
                _listMonths.RightToLeftLayout = ci.TextInfo.IsRightToLeft ? true : false;

                var monthNames = useGenitiveMonthNames ? ci.DateTimeFormat.MonthGenitiveNames : ci.DateTimeFormat.MonthNames;
                var abbMonthNames = useGenitiveMonthNames ? ci.DateTimeFormat.AbbreviatedMonthGenitiveNames : ci.DateTimeFormat.AbbreviatedMonthNames;

                var monthsPerYear = monthNames.Length;
                // we need to check if the last month is actually significant or not
                // as there are calendars where there are potentially more than 12 
                // months for a given year... 
                // the MonthName table actually accomodates for these, which means that 
                // the size of the table may not yield significant results for all calendars
                while (monthsPerYear > 12 && string.Empty == monthNames[monthsPerYear - 1])
                    monthsPerYear--;
                _monthsPerYear.Text = monthsPerYear.ToString();

                var names = new string[2];
                for (var i = 0; i < monthsPerYear; i++)
                {
                    names[0] = monthNames[i];
                    names[1] = abbMonthNames[i];
                    _listMonths.Items.Add(new ListViewItem(names));
                }
            }
        }

        public bool AreGenitiveMonthsSignificant(DateTimeFormatInfo dtfi)
        {
            var monthNames = dtfi.MonthNames;
            var genitiveMonthNames = dtfi.MonthGenitiveNames;
            var isSignificant = false;

            for (var i = 0; !isSignificant && i < monthNames.Length; i++)
                if (0 != string.CompareOrdinal(monthNames[i], genitiveMonthNames[i]))
                    isSignificant = true;

            return isSignificant;
        }

        public void ClassColor(ProgramSettings.ClassColor cc)
        {
            switch (cc)
            {
                case ProgramSettings.ClassColor.ApplyDateTimeFormatInfo:
                    ColorDtfi(ProgramSettings.ColorDateTimeFormatInfo);
                    break;

                case ProgramSettings.ClassColor.ClearDateTimeFormatInfo:
                    ColorDtfi(ProgramSettings.ColorNone);
                    break;

                case ProgramSettings.ClassColor.ApplyCalendar:
                    ColorCalendar(ProgramSettings.ColorCalendar);
                    break;

                case ProgramSettings.ClassColor.ClearCalendar:
                    ColorCalendar(ProgramSettings.ColorNone);
                    break;
            }
        }

        private void ColorDtfi(Color color)
        {
            _firstDay.BackColor = color;
            _monthsPerYear.BackColor = color;
            _am.BackColor = color;
            _pm.BackColor = color;
            _nativeName.BackColor = color;
            _currentEra.BackColor = color;
        }

        private void ColorCalendar(Color color)
        {
            _algorithm.BackColor = color;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void checkGenitiveMonths_CheckedChanged(object sender, EventArgs e)
        {
            UpdateMonthInfo(_culture, _checkGenitiveMonths.Checked);
        }
    }
}