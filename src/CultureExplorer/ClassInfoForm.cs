using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CultureExplorer
{
    /// <summary>
    ///     Summary description for ClassInfoForm.
    /// </summary>
    public class ClassInfoForm : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Button _buttonClearAll;
        private Button _buttonClose;
        private Button _buttonSelectAll;
        private CheckBox _cbCalendar;
        private CheckBox _cbCultureInfo;
        private CheckBox _cbDateTimeFormatInfo;
        private CheckBox _cbNumberFormatInfo;
        private CheckBox _cbRegionInfo;
        private CheckBox _cbTextInfo;

        private GroupBox _groupBox1;
        private Label _labelCalendar;
        private Label _labelCi;
        private Label _labelDtfi;
        private Label _labelNfi;
        private Label _labelRi;
        private Label _labelTi;
        private MainForm _myMainForm;

        public ClassInfoForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            _labelCi.BackColor = ProgramSettings.ColorCultureInfo;
            _labelRi.BackColor = ProgramSettings.ColorRegionInfo;
            _labelNfi.BackColor = ProgramSettings.ColorNumberFormatInfo;
            _labelDtfi.BackColor = ProgramSettings.ColorDateTimeFormatInfo;
            _labelTi.BackColor = ProgramSettings.ColorTextInfo;
            _labelCalendar.BackColor = ProgramSettings.ColorCalendar;
        }

        /// <summary>
        ///     Clean up any resources being used.
        /// </summary>
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
            var resources = new ComponentResourceManager(typeof(ClassInfoForm));
            _groupBox1 = new System.Windows.Forms.GroupBox();
            _labelTi = new Label();
            _cbTextInfo = new System.Windows.Forms.CheckBox();
            _labelDtfi = new Label();
            _labelNfi = new Label();
            _labelRi = new Label();
            _labelCi = new Label();
            _cbDateTimeFormatInfo = new System.Windows.Forms.CheckBox();
            _cbNumberFormatInfo = new System.Windows.Forms.CheckBox();
            _cbRegionInfo = new System.Windows.Forms.CheckBox();
            _cbCultureInfo = new System.Windows.Forms.CheckBox();
            _buttonSelectAll = new Button();
            _buttonClearAll = new Button();
            _buttonClose = new Button();
            _cbCalendar = new System.Windows.Forms.CheckBox();
            _labelCalendar = new Label();
            _groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            _groupBox1.Controls.Add(_labelCalendar);
            _groupBox1.Controls.Add(_cbCalendar);
            _groupBox1.Controls.Add(_labelTi);
            _groupBox1.Controls.Add(_cbTextInfo);
            _groupBox1.Controls.Add(_labelDtfi);
            _groupBox1.Controls.Add(_labelNfi);
            _groupBox1.Controls.Add(_labelRi);
            _groupBox1.Controls.Add(_labelCi);
            _groupBox1.Controls.Add(_cbDateTimeFormatInfo);
            _groupBox1.Controls.Add(_cbNumberFormatInfo);
            _groupBox1.Controls.Add(_cbRegionInfo);
            _groupBox1.Controls.Add(_cbCultureInfo);
            _groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupBox1, "_groupBox1");
            _groupBox1.Name = "_groupBox1";
            _groupBox1.TabStop = false;
            // 
            // labelTI
            // 
            _labelTi.BackColor = System.Drawing.Color.Thistle;
            _labelTi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(_labelTi, "_labelTi");
            _labelTi.Name = "_labelTi";
            // 
            // cbTextInfo
            // 
            resources.ApplyResources(_cbTextInfo, "_cbTextInfo");
            _cbTextInfo.Name = "_cbTextInfo";
            _cbTextInfo.CheckedChanged += new System.EventHandler(cbTextInfo_CheckedChanged);
            // 
            // labelDTFI
            // 
            _labelDtfi.BackColor = System.Drawing.Color.Khaki;
            _labelDtfi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(_labelDtfi, "_labelDtfi");
            _labelDtfi.Name = "_labelDtfi";
            // 
            // labelNFI
            // 
            _labelNfi.BackColor = System.Drawing.Color.Chartreuse;
            _labelNfi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(_labelNfi, "_labelNfi");
            _labelNfi.Name = "_labelNfi";
            // 
            // labelRI
            // 
            _labelRi.BackColor = System.Drawing.Color.Tomato;
            _labelRi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(_labelRi, "_labelRi");
            _labelRi.Name = "_labelRi";
            // 
            // labelCI
            // 
            _labelCi.BackColor = System.Drawing.Color.LightSteelBlue;
            _labelCi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(_labelCi, "_labelCi");
            _labelCi.Name = "_labelCi";
            // 
            // cbDateTimeFormatInfo
            // 
            resources.ApplyResources(_cbDateTimeFormatInfo, "_cbDateTimeFormatInfo");
            _cbDateTimeFormatInfo.Name = "_cbDateTimeFormatInfo";
            _cbDateTimeFormatInfo.CheckedChanged += new System.EventHandler(cbDateTimeFormatInfo_CheckedChanged);
            // 
            // cbNumberFormatInfo
            // 
            resources.ApplyResources(_cbNumberFormatInfo, "_cbNumberFormatInfo");
            _cbNumberFormatInfo.Name = "_cbNumberFormatInfo";
            _cbNumberFormatInfo.CheckedChanged += new System.EventHandler(cbNumberFormatInfo_CheckedChanged);
            // 
            // cbRegionInfo
            // 
            resources.ApplyResources(_cbRegionInfo, "_cbRegionInfo");
            _cbRegionInfo.Name = "_cbRegionInfo";
            _cbRegionInfo.CheckedChanged += new System.EventHandler(cbRegionInfo_CheckedChanged);
            // 
            // cbCultureInfo
            // 
            resources.ApplyResources(_cbCultureInfo, "_cbCultureInfo");
            _cbCultureInfo.Name = "_cbCultureInfo";
            _cbCultureInfo.CheckedChanged += new System.EventHandler(cbCultureInfo_CheckedChanged);
            // 
            // buttonSelectAll
            // 
            resources.ApplyResources(_buttonSelectAll, "_buttonSelectAll");
            _buttonSelectAll.Name = "_buttonSelectAll";
            _buttonSelectAll.Click += new System.EventHandler(buttonSelectAll_Click);
            // 
            // buttonClearAll
            // 
            resources.ApplyResources(_buttonClearAll, "_buttonClearAll");
            _buttonClearAll.Name = "_buttonClearAll";
            _buttonClearAll.Click += new System.EventHandler(buttonClearAll_Click);
            // 
            // buttonClose
            // 
            resources.ApplyResources(_buttonClose, "_buttonClose");
            _buttonClose.Name = "_buttonClose";
            _buttonClose.Click += new System.EventHandler(buttonClose_Click);
            // 
            // cbCalendar
            // 
            resources.ApplyResources(_cbCalendar, "_cbCalendar");
            _cbCalendar.Name = "_cbCalendar";
            _cbCalendar.CheckedChanged += new System.EventHandler(cbCalendar_CheckedChanged);
            // 
            // labelCalendar
            // 
            _labelCalendar.BackColor = System.Drawing.Color.Tan;
            _labelCalendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(_labelCalendar, "_labelCalendar");
            _labelCalendar.Name = "_labelCalendar";
            // 
            // ClassInfoForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(_buttonClose);
            Controls.Add(_buttonClearAll);
            Controls.Add(_buttonSelectAll);
            Controls.Add(_groupBox1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "ClassInfoForm";
            ShowInTaskbar = false;
            Closing += new System.ComponentModel.CancelEventHandler(OnClosing);
            _groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public void SetMainForm(MainForm mainForm)
        {
            _myMainForm = mainForm;
        }

        private void buttonSelectAll_Click(object sender, EventArgs e)
        {
            _cbCultureInfo.Checked = true;
            _cbRegionInfo.Checked = true;
            _cbNumberFormatInfo.Checked = true;
            _cbDateTimeFormatInfo.Checked = true;
            _cbTextInfo.Checked = true;
            _cbCalendar.Checked = true;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            _cbCultureInfo.Checked = false;
            _cbRegionInfo.Checked = false;
            _cbNumberFormatInfo.Checked = false;
            _cbDateTimeFormatInfo.Checked = false;
            _cbTextInfo.Checked = false;
            _cbCalendar.Checked = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void cbCultureInfo_CheckedChanged(object sender, EventArgs e)
        {
            _myMainForm.NotifyClassColorChange(_cbCultureInfo.Checked ? ProgramSettings.ClassColor.ApplyCultureInfo : ProgramSettings.ClassColor.ClearCultureInfo);
        }

        private void cbRegionInfo_CheckedChanged(object sender, EventArgs e)
        {
            _myMainForm.NotifyClassColorChange(_cbRegionInfo.Checked ? ProgramSettings.ClassColor.ApplyRegionInfo : ProgramSettings.ClassColor.ClearRegionInfo);
        }

        private void cbNumberFormatInfo_CheckedChanged(object sender, EventArgs e)
        {
            _myMainForm.NotifyClassColorChange(_cbNumberFormatInfo.Checked ? ProgramSettings.ClassColor.ApplyNumberFormatInfo : ProgramSettings.ClassColor.ClearNumberFormatInfo);
        }

        private void cbDateTimeFormatInfo_CheckedChanged(object sender, EventArgs e)
        {
            _myMainForm.NotifyClassColorChange(_cbDateTimeFormatInfo.Checked ? ProgramSettings.ClassColor.ApplyDateTimeFormatInfo : ProgramSettings.ClassColor.ClearDateTimeFormatInfo);
        }

        private void cbTextInfo_CheckedChanged(object sender, EventArgs e)
        {
            _myMainForm.NotifyClassColorChange(_cbTextInfo.Checked ? ProgramSettings.ClassColor.ApplyTextInfo : ProgramSettings.ClassColor.ClearTextInfo);
        }

        private void cbCalendar_CheckedChanged(object sender, EventArgs e)
        {
            _myMainForm.NotifyClassColorChange(_cbCalendar.Checked ? ProgramSettings.ClassColor.ApplyCalendar : ProgramSettings.ClassColor.ClearCalendar);
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}