using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using CultureExplorer.Properties;

namespace CultureExplorer
{
    public class MainForm : Form
    {
        private Button _about;
        private CultureExplorerLabel _bidi;
        private CheckBox _checkAllCultures;
        private CheckBox _checkFrameworkCultures;
        private CheckBox _checkInstalledWin32Cultures;
        private CheckBox _checkNeutralCultures;
        private CheckBox _checkReplacementCultures;
        private CheckBox _checkSpecificCultures;
        private CheckBox _checkUserCustomCultures;
        private CheckBox _checkWindowsOnlyCultures;
        private Button _classDetails;
        private ComboBox _comboCalendar;
        private ComboBox _comboDateTime;
        private ComboBox _comboNumberFormat;
        private LinkLabel _currencyDetails;
        private CultureExplorerLabel _currencyEnglishName;
        private CultureExplorerLabel _currencyIso;
        private CultureExplorerLabel _currencyNativeName;
        private CultureExplorerLabel _currencyNegative;
        private CultureExplorerLabel _currencyPositive;
        private CultureExplorerLabel _currencySymbol;
        private LinkLabel _dateTimeDetails;
        private CultureExplorerLabel _dateTimeText;
        private Button _exit;
        private CultureExplorerLabel _geoId;
        private GroupBox _groupCultures;
        private GroupBox _groupCurrency;
        private GroupBox _groupCurrencyInfo;
        private GroupBox _groupDateTime;

        private GroupBox _groupLang;
        private GroupBox _groupMoreInfo;
        private GroupBox _groupName;
        private GroupBox _groupNumber;
        private GroupBox _groupPercent;
        private GroupBox _groupRegion;
        private GroupBox _groupText;
        private CultureExplorerLabel _ietf;
        private ImageList _imageList;
        private CultureExplorerLabel _iso2Reg;
        private CultureExplorerLabel _iso3Reg;
        private CultureExplorerLabel _isoLang2;
        private CultureExplorerLabel _isoLang3;
        private CultureExplorerLabel _keyboardLayoutId;
        private Label _labelBidi;
        private Label _labelCalendar;
        private Label _labelCurrencyEnglishName;
        private Label _labelCurrencyIso;
        private Label _labelCurrencyNativeName;
        private Label _labelCurrencySymbol;
        private Label _labelDateTimeFormat;
        private Label _labelGeoId;
        private Label _labelIetf;
        private Label _labelIso2Lang;
        private Label _labelIso2Reg;
        private Label _labelIso3Lang;
        private Label _labelIso3Reg;
        private Label _labelKeyboardLayoutId;
        private Label _labelLcid;
        private Label _labelListSeparator;
        private Label _labelMetricReg;
        private Label _labelName;
        private Label _labelNameDisplay;
        private Label _labelNameEnglish;
        private Label _labelNameNative;
        private Label _labelNativeName;
        private Label _labelNeutralCulture;
        private Label _labelNumberFormat;
        private Label _labelWinLang;
        private Label _labelWinReg;
        private CultureExplorerLabel _lcid;
        private CultureExplorerLabel _listSeparator;
        private CultureExplorerLabel _metricReg;
        private CultureExplorerLabel _nameDisplay;
        private CultureExplorerLabel _nameEnglish;
        private CultureExplorerLabel _nameNative;
        private CultureExplorerLabel _neutralCulture;
        private LinkLabel _numberDetails;
        private CultureExplorerLabel _numberNegative;
        private CultureExplorerLabel _numberPositive;
        private LinkLabel _percentDetails;
        private CultureExplorerLabel _percentNegative;
        private CultureExplorerLabel _percentPositive;
        private CultureExplorerLabel _riName;
        private CultureExplorerLabel _riNativeName;

        private TreeView _treeCulture;
        private CultureExplorerLabel _winLang;
        private CultureExplorerLabel _winReg;
        protected CalendarForm CalendarForm;
        protected CultureInfo Ci;
        protected ClassInfoForm ClassForm;
        private IContainer components;
        protected CurrencyFormatForm CurrencyForm;

        protected NumberFormatForm NumberForm;
        protected PercentFormatForm PercentForm;

        #region constructor

        public MainForm()
        {
            // Required for Windows Form Designer support
            InitializeComponent();

            // create ancillary forms
            Ci = new CultureInfo("");
            NumberForm = new NumberFormatForm(Ci);
            CurrencyForm = new CurrencyFormatForm(Ci);
            PercentForm = new PercentFormatForm(Ci);
            CalendarForm = new CalendarForm(Ci);
            ClassForm = new ClassInfoForm();
            ClassForm.SetMainForm(this);

            // load strings from resources for:
            // - invariant culture name
            // - date time format combo box entries
            // - number format combo box entries
            // note: the "d, D Decimal format" and "x, X Hexadecimal format" are 
            // not supported here for number formatting

            _comboDateTime.Items.Add(Resources.DateFormat_D);
            _comboDateTime.Items.Add(Resources.DateFormat_DC);
            _comboDateTime.Items.Add(Resources.DateFormat_F);
            _comboDateTime.Items.Add(Resources.DateFormat_FC);
            _comboDateTime.Items.Add(Resources.DateFormat_G);
            _comboDateTime.Items.Add(Resources.DateFormat_GC);
            _comboDateTime.Items.Add(Resources.DateFormat_M);
            _comboDateTime.Items.Add(Resources.DateFormat_R);
            _comboDateTime.Items.Add(Resources.DateFormat_S);
            _comboDateTime.Items.Add(Resources.DateFormat_T);
            _comboDateTime.Items.Add(Resources.DateFormat_TC);
            _comboDateTime.Items.Add(Resources.DateFormat_U);
            _comboDateTime.Items.Add(Resources.DateFormat_UC);
            _comboDateTime.Items.Add(Resources.DateFormat_Y);
            _comboDateTime.SelectedIndex = 3; // set default to F: long date, long time
            _comboNumberFormat.Items.Add(Resources.NumberFormat_NC);
            _comboNumberFormat.Items.Add(Resources.NumberFormat_FC);
            _comboNumberFormat.Items.Add(Resources.NumberFormat_EC);
            _comboNumberFormat.Items.Add(Resources.NumberFormat_GC);
            _comboNumberFormat.Items.Add(Resources.NumberFormat_RC);
            _comboNumberFormat.SelectedIndex = 0; // set default to n: number format

            // initialize image list used by culture tree (in same order as CultureTypeIcons enum in program.cs)
            _imageList.ColorDepth = ColorDepth.Depth32Bit;
            _imageList.ImageSize = new Size(16, 16);
            _imageList.Images.AddStrip(Resources.TreeViewIcons);

            // initialize culture tree indirectly by selecting the checkbox that we want checked
            _checkFrameworkCultures.Checked = true;
        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                if (components != null)
                    components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///     Required method for Designer support - do not modify
        ///     the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            var resources = new ComponentResourceManager(typeof(MainForm));
            _groupRegion = new System.Windows.Forms.GroupBox();
            _geoId = new CultureExplorerLabel();
            _labelGeoId = new Label();
            _riNativeName = new CultureExplorerLabel();
            _riName = new CultureExplorerLabel();
            _labelNativeName = new Label();
            _labelName = new Label();
            _metricReg = new CultureExplorerLabel();
            _labelMetricReg = new Label();
            _winReg = new CultureExplorerLabel();
            _iso3Reg = new CultureExplorerLabel();
            _labelIso3Reg = new Label();
            _labelIso2Reg = new Label();
            _labelWinReg = new Label();
            _iso2Reg = new CultureExplorerLabel();
            _labelCurrencySymbol = new Label();
            _labelCurrencyIso = new Label();
            _treeCulture = new System.Windows.Forms.TreeView();
            _imageList = new System.Windows.Forms.ImageList(components);
            _labelIso2Lang = new Label();
            _groupDateTime = new System.Windows.Forms.GroupBox();
            _dateTimeText = new CultureExplorerLabel();
            _dateTimeDetails = new LinkLabel();
            _comboDateTime = new System.Windows.Forms.ComboBox();
            _labelDateTimeFormat = new Label();
            _labelCalendar = new Label();
            _comboCalendar = new System.Windows.Forms.ComboBox();
            _groupNumber = new System.Windows.Forms.GroupBox();
            _comboNumberFormat = new System.Windows.Forms.ComboBox();
            _labelNumberFormat = new Label();
            _numberDetails = new LinkLabel();
            _numberNegative = new CultureExplorerLabel();
            _numberPositive = new CultureExplorerLabel();
            _labelNameEnglish = new Label();
            _labelIso3Lang = new Label();
            _currencyDetails = new LinkLabel();
            _labelNameDisplay = new Label();
            _labelNameNative = new Label();
            _groupPercent = new System.Windows.Forms.GroupBox();
            _percentDetails = new LinkLabel();
            _percentNegative = new CultureExplorerLabel();
            _percentPositive = new CultureExplorerLabel();
            _groupLang = new System.Windows.Forms.GroupBox();
            _ietf = new CultureExplorerLabel();
            _winLang = new CultureExplorerLabel();
            _labelIetf = new Label();
            _labelWinLang = new Label();
            _isoLang2 = new CultureExplorerLabel();
            _isoLang3 = new CultureExplorerLabel();
            _groupName = new System.Windows.Forms.GroupBox();
            _nameEnglish = new CultureExplorerLabel();
            _nameDisplay = new CultureExplorerLabel();
            _nameNative = new CultureExplorerLabel();
            _exit = new Button();
            _groupCurrency = new System.Windows.Forms.GroupBox();
            _currencyNegative = new CultureExplorerLabel();
            _currencyPositive = new CultureExplorerLabel();
            _groupMoreInfo = new System.Windows.Forms.GroupBox();
            _keyboardLayoutId = new CultureExplorerLabel();
            _labelKeyboardLayoutId = new Label();
            _neutralCulture = new CultureExplorerLabel();
            _labelLcid = new Label();
            _labelNeutralCulture = new Label();
            _lcid = new CultureExplorerLabel();
            _about = new Button();
            _classDetails = new Button();
            _groupText = new System.Windows.Forms.GroupBox();
            _listSeparator = new CultureExplorerLabel();
            _labelListSeparator = new Label();
            _labelBidi = new Label();
            _bidi = new CultureExplorerLabel();
            _groupCultures = new System.Windows.Forms.GroupBox();
            _checkAllCultures = new System.Windows.Forms.CheckBox();
            _checkUserCustomCultures = new System.Windows.Forms.CheckBox();
            _checkWindowsOnlyCultures = new System.Windows.Forms.CheckBox();
            _checkInstalledWin32Cultures = new System.Windows.Forms.CheckBox();
            _checkReplacementCultures = new System.Windows.Forms.CheckBox();
            _checkSpecificCultures = new System.Windows.Forms.CheckBox();
            _checkNeutralCultures = new System.Windows.Forms.CheckBox();
            _checkFrameworkCultures = new System.Windows.Forms.CheckBox();
            _labelCurrencyEnglishName = new Label();
            _groupCurrencyInfo = new System.Windows.Forms.GroupBox();
            _currencyNativeName = new CultureExplorerLabel();
            _labelCurrencyNativeName = new Label();
            _currencyEnglishName = new CultureExplorerLabel();
            _currencyIso = new CultureExplorerLabel();
            _currencySymbol = new CultureExplorerLabel();
            _groupRegion.SuspendLayout();
            _groupDateTime.SuspendLayout();
            _groupNumber.SuspendLayout();
            _groupPercent.SuspendLayout();
            _groupLang.SuspendLayout();
            _groupName.SuspendLayout();
            _groupCurrency.SuspendLayout();
            _groupMoreInfo.SuspendLayout();
            _groupText.SuspendLayout();
            _groupCultures.SuspendLayout();
            _groupCurrencyInfo.SuspendLayout();
            SuspendLayout();
            // 
            // groupRegion
            // 
            _groupRegion.Controls.Add(_geoId);
            _groupRegion.Controls.Add(_labelGeoId);
            _groupRegion.Controls.Add(_riNativeName);
            _groupRegion.Controls.Add(_riName);
            _groupRegion.Controls.Add(_labelNativeName);
            _groupRegion.Controls.Add(_labelName);
            _groupRegion.Controls.Add(_metricReg);
            _groupRegion.Controls.Add(_labelMetricReg);
            _groupRegion.Controls.Add(_winReg);
            _groupRegion.Controls.Add(_iso3Reg);
            _groupRegion.Controls.Add(_labelIso3Reg);
            _groupRegion.Controls.Add(_labelIso2Reg);
            _groupRegion.Controls.Add(_labelWinReg);
            _groupRegion.Controls.Add(_iso2Reg);
            _groupRegion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupRegion, "_groupRegion");
            _groupRegion.Name = "_groupRegion";
            _groupRegion.TabStop = false;
            // 
            // GeoID
            // 
            _geoId.BackColor = System.Drawing.SystemColors.Info;
            _geoId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _geoId.Cursor = System.Windows.Forms.Cursors.Hand;
            _geoId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_geoId, "_geoId");
            _geoId.Name = "_geoId";
            // 
            // labelGeoID
            // 
            resources.ApplyResources(_labelGeoId, "_labelGeoId");
            _labelGeoId.Name = "_labelGeoId";
            // 
            // RINativeName
            // 
            _riNativeName.BackColor = System.Drawing.SystemColors.Info;
            _riNativeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _riNativeName.Cursor = System.Windows.Forms.Cursors.Hand;
            _riNativeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_riNativeName, "_riNativeName");
            _riNativeName.Name = "_riNativeName";
            // 
            // RIName
            // 
            _riName.BackColor = System.Drawing.SystemColors.Info;
            _riName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _riName.Cursor = System.Windows.Forms.Cursors.Hand;
            _riName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_riName, "_riName");
            _riName.Name = "_riName";
            // 
            // labelNativeName
            // 
            resources.ApplyResources(_labelNativeName, "_labelNativeName");
            _labelNativeName.Name = "_labelNativeName";
            // 
            // labelName
            // 
            resources.ApplyResources(_labelName, "_labelName");
            _labelName.Name = "_labelName";
            // 
            // MetricReg
            // 
            _metricReg.BackColor = System.Drawing.SystemColors.Info;
            _metricReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _metricReg.Cursor = System.Windows.Forms.Cursors.Hand;
            _metricReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_metricReg, "_metricReg");
            _metricReg.Name = "_metricReg";
            // 
            // labelMetricReg
            // 
            _labelMetricReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelMetricReg, "_labelMetricReg");
            _labelMetricReg.Name = "_labelMetricReg";
            // 
            // WinReg
            // 
            _winReg.BackColor = System.Drawing.SystemColors.Info;
            _winReg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _winReg.Cursor = System.Windows.Forms.Cursors.Hand;
            _winReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_winReg, "_winReg");
            _winReg.Name = "_winReg";
            // 
            // Iso3Reg
            // 
            _iso3Reg.BackColor = System.Drawing.SystemColors.Info;
            _iso3Reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _iso3Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            _iso3Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_iso3Reg, "_iso3Reg");
            _iso3Reg.Name = "_iso3Reg";
            // 
            // labelIso3Reg
            // 
            _labelIso3Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelIso3Reg, "_labelIso3Reg");
            _labelIso3Reg.Name = "_labelIso3Reg";
            // 
            // labelIso2Reg
            // 
            _labelIso2Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelIso2Reg, "_labelIso2Reg");
            _labelIso2Reg.Name = "_labelIso2Reg";
            // 
            // labelWinReg
            // 
            _labelWinReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelWinReg, "_labelWinReg");
            _labelWinReg.Name = "_labelWinReg";
            // 
            // Iso2Reg
            // 
            _iso2Reg.BackColor = System.Drawing.SystemColors.Info;
            _iso2Reg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _iso2Reg.Cursor = System.Windows.Forms.Cursors.Hand;
            _iso2Reg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_iso2Reg, "_iso2Reg");
            _iso2Reg.Name = "_iso2Reg";
            // 
            // labelCurrencySymbol
            // 
            _labelCurrencySymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelCurrencySymbol, "_labelCurrencySymbol");
            _labelCurrencySymbol.Name = "_labelCurrencySymbol";
            // 
            // labelCurrencyISO
            // 
            _labelCurrencyIso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelCurrencyIso, "_labelCurrencyIso");
            _labelCurrencyIso.Name = "_labelCurrencyIso";
            // 
            // treeCulture
            // 
            _treeCulture.HideSelection = false;
            resources.ApplyResources(_treeCulture, "_treeCulture");
            _treeCulture.ImageList = _imageList;
            _treeCulture.ItemHeight = 16;
            _treeCulture.Name = "_treeCulture";
            _treeCulture.Sorted = true;
            _treeCulture.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(treeCulture_AfterSelect);
            // 
            // imageList
            // 
            _imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            resources.ApplyResources(_imageList, "_imageList");
            _imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // labelIso2Lang
            // 
            _labelIso2Lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelIso2Lang, "_labelIso2Lang");
            _labelIso2Lang.Name = "_labelIso2Lang";
            // 
            // groupDateTime
            // 
            _groupDateTime.Controls.Add(_dateTimeText);
            _groupDateTime.Controls.Add(_dateTimeDetails);
            _groupDateTime.Controls.Add(_comboDateTime);
            _groupDateTime.Controls.Add(_labelDateTimeFormat);
            _groupDateTime.Controls.Add(_labelCalendar);
            _groupDateTime.Controls.Add(_comboCalendar);
            _groupDateTime.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupDateTime, "_groupDateTime");
            _groupDateTime.Name = "_groupDateTime";
            _groupDateTime.TabStop = false;
            // 
            // DateTimeText
            // 
            _dateTimeText.BackColor = System.Drawing.SystemColors.Info;
            _dateTimeText.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _dateTimeText.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_dateTimeText, "_dateTimeText");
            _dateTimeText.Name = "_dateTimeText";
            // 
            // DateTimeDetails
            // 
            _dateTimeDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_dateTimeDetails, "_dateTimeDetails");
            _dateTimeDetails.Name = "_dateTimeDetails";
            _dateTimeDetails.TabStop = true;
            _dateTimeDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(DateTimeDetails_LinkClicked);
            // 
            // comboDateTime
            // 
            _comboDateTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _comboDateTime.DropDownWidth = 253;
            resources.ApplyResources(_comboDateTime, "_comboDateTime");
            _comboDateTime.FormattingEnabled = true;
            _comboDateTime.Name = "_comboDateTime";
            _comboDateTime.SelectedIndexChanged += new System.EventHandler(comboDateTime_SelectedIndexChanged);
            // 
            // labelDateTimeFormat
            // 
            _labelDateTimeFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelDateTimeFormat, "_labelDateTimeFormat");
            _labelDateTimeFormat.Name = "_labelDateTimeFormat";
            // 
            // labelCalendar
            // 
            _labelCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelCalendar, "_labelCalendar");
            _labelCalendar.Name = "_labelCalendar";
            // 
            // comboCalendar
            // 
            _comboCalendar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _comboCalendar.DropDownWidth = 253;
            resources.ApplyResources(_comboCalendar, "_comboCalendar");
            _comboCalendar.FormattingEnabled = true;
            _comboCalendar.Name = "_comboCalendar";
            _comboCalendar.SelectedIndexChanged += new System.EventHandler(comboCalendar_SelectedIndexChanged);
            // 
            // groupNumber
            // 
            _groupNumber.Controls.Add(_comboNumberFormat);
            _groupNumber.Controls.Add(_labelNumberFormat);
            _groupNumber.Controls.Add(_numberDetails);
            _groupNumber.Controls.Add(_numberNegative);
            _groupNumber.Controls.Add(_numberPositive);
            _groupNumber.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupNumber, "_groupNumber");
            _groupNumber.Name = "_groupNumber";
            _groupNumber.TabStop = false;
            // 
            // comboNumberFormat
            // 
            _comboNumberFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            _comboNumberFormat.DropDownWidth = 119;
            resources.ApplyResources(_comboNumberFormat, "_comboNumberFormat");
            _comboNumberFormat.FormattingEnabled = true;
            _comboNumberFormat.Name = "_comboNumberFormat";
            _comboNumberFormat.SelectedIndexChanged += new System.EventHandler(comboNumberFormat_SelectedIndexChanged);
            // 
            // labelNumberFormat
            // 
            resources.ApplyResources(_labelNumberFormat, "_labelNumberFormat");
            _labelNumberFormat.Name = "_labelNumberFormat";
            // 
            // NumberDetails
            // 
            _numberDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_numberDetails, "_numberDetails");
            _numberDetails.Name = "_numberDetails";
            _numberDetails.TabStop = true;
            _numberDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(NumberDetails_LinkClicked);
            // 
            // NumberNegative
            // 
            _numberNegative.BackColor = System.Drawing.SystemColors.Info;
            _numberNegative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _numberNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            _numberNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_numberNegative, "_numberNegative");
            _numberNegative.Name = "_numberNegative";
            // 
            // NumberPositive
            // 
            _numberPositive.BackColor = System.Drawing.SystemColors.Info;
            _numberPositive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _numberPositive.Cursor = System.Windows.Forms.Cursors.Hand;
            _numberPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_numberPositive, "_numberPositive");
            _numberPositive.Name = "_numberPositive";
            // 
            // labelNameEnglish
            // 
            _labelNameEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelNameEnglish, "_labelNameEnglish");
            _labelNameEnglish.Name = "_labelNameEnglish";
            // 
            // labelIso3Lang
            // 
            _labelIso3Lang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelIso3Lang, "_labelIso3Lang");
            _labelIso3Lang.Name = "_labelIso3Lang";
            // 
            // CurrencyDetails
            // 
            _currencyDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_currencyDetails, "_currencyDetails");
            _currencyDetails.Name = "_currencyDetails";
            _currencyDetails.TabStop = true;
            _currencyDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(CurrencyDetails_LinkClicked);
            // 
            // labelNameDisplay
            // 
            _labelNameDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelNameDisplay, "_labelNameDisplay");
            _labelNameDisplay.Name = "_labelNameDisplay";
            // 
            // labelNameNative
            // 
            _labelNameNative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelNameNative, "_labelNameNative");
            _labelNameNative.Name = "_labelNameNative";
            // 
            // groupPercent
            // 
            _groupPercent.Controls.Add(_percentDetails);
            _groupPercent.Controls.Add(_percentNegative);
            _groupPercent.Controls.Add(_percentPositive);
            _groupPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupPercent, "_groupPercent");
            _groupPercent.Name = "_groupPercent";
            _groupPercent.TabStop = false;
            // 
            // PercentDetails
            // 
            _percentDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_percentDetails, "_percentDetails");
            _percentDetails.Name = "_percentDetails";
            _percentDetails.TabStop = true;
            _percentDetails.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(PercentDetails_LinkClicked);
            // 
            // PercentNegative
            // 
            _percentNegative.BackColor = System.Drawing.SystemColors.Info;
            _percentNegative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _percentNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            _percentNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_percentNegative, "_percentNegative");
            _percentNegative.Name = "_percentNegative";
            // 
            // PercentPositive
            // 
            _percentPositive.BackColor = System.Drawing.SystemColors.Info;
            _percentPositive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _percentPositive.Cursor = System.Windows.Forms.Cursors.Hand;
            _percentPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_percentPositive, "_percentPositive");
            _percentPositive.Name = "_percentPositive";
            // 
            // groupLang
            // 
            _groupLang.Controls.Add(_ietf);
            _groupLang.Controls.Add(_winLang);
            _groupLang.Controls.Add(_labelIetf);
            _groupLang.Controls.Add(_labelWinLang);
            _groupLang.Controls.Add(_labelIso3Lang);
            _groupLang.Controls.Add(_labelIso2Lang);
            _groupLang.Controls.Add(_isoLang2);
            _groupLang.Controls.Add(_isoLang3);
            _groupLang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupLang, "_groupLang");
            _groupLang.Name = "_groupLang";
            _groupLang.TabStop = false;
            // 
            // IETF
            // 
            _ietf.BackColor = System.Drawing.SystemColors.Info;
            _ietf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _ietf.Cursor = System.Windows.Forms.Cursors.Hand;
            _ietf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_ietf, "_ietf");
            _ietf.Name = "_ietf";
            // 
            // WinLang
            // 
            _winLang.BackColor = System.Drawing.SystemColors.Info;
            _winLang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _winLang.Cursor = System.Windows.Forms.Cursors.Hand;
            _winLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_winLang, "_winLang");
            _winLang.Name = "_winLang";
            // 
            // labelIETF
            // 
            resources.ApplyResources(_labelIetf, "_labelIetf");
            _labelIetf.Name = "_labelIetf";
            // 
            // labelWinLang
            // 
            _labelWinLang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelWinLang, "_labelWinLang");
            _labelWinLang.Name = "_labelWinLang";
            // 
            // IsoLang2
            // 
            _isoLang2.BackColor = System.Drawing.SystemColors.Info;
            _isoLang2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _isoLang2.Cursor = System.Windows.Forms.Cursors.Hand;
            _isoLang2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_isoLang2, "_isoLang2");
            _isoLang2.Name = "_isoLang2";
            // 
            // IsoLang3
            // 
            _isoLang3.BackColor = System.Drawing.SystemColors.Info;
            _isoLang3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _isoLang3.Cursor = System.Windows.Forms.Cursors.Hand;
            _isoLang3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_isoLang3, "_isoLang3");
            _isoLang3.Name = "_isoLang3";
            // 
            // groupName
            // 
            _groupName.Controls.Add(_nameEnglish);
            _groupName.Controls.Add(_nameDisplay);
            _groupName.Controls.Add(_nameNative);
            _groupName.Controls.Add(_labelNameEnglish);
            _groupName.Controls.Add(_labelNameDisplay);
            _groupName.Controls.Add(_labelNameNative);
            _groupName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupName, "_groupName");
            _groupName.Name = "_groupName";
            _groupName.TabStop = false;
            // 
            // NameEnglish
            // 
            _nameEnglish.BackColor = System.Drawing.SystemColors.Info;
            _nameEnglish.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _nameEnglish.Cursor = System.Windows.Forms.Cursors.Hand;
            _nameEnglish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_nameEnglish, "_nameEnglish");
            _nameEnglish.Name = "_nameEnglish";
            // 
            // NameDisplay
            // 
            _nameDisplay.BackColor = System.Drawing.SystemColors.Info;
            _nameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _nameDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            _nameDisplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_nameDisplay, "_nameDisplay");
            _nameDisplay.Name = "_nameDisplay";
            // 
            // NameNative
            // 
            _nameNative.BackColor = System.Drawing.SystemColors.Info;
            _nameNative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _nameNative.Cursor = System.Windows.Forms.Cursors.Hand;
            _nameNative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_nameNative, "_nameNative");
            _nameNative.Name = "_nameNative";
            // 
            // Exit
            // 
            resources.ApplyResources(_exit, "_exit");
            _exit.Name = "_exit";
            _exit.Click += new System.EventHandler(buttonExit_Click);
            // 
            // groupCurrency
            // 
            _groupCurrency.Controls.Add(_currencyDetails);
            _groupCurrency.Controls.Add(_currencyNegative);
            _groupCurrency.Controls.Add(_currencyPositive);
            _groupCurrency.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupCurrency, "_groupCurrency");
            _groupCurrency.Name = "_groupCurrency";
            _groupCurrency.TabStop = false;
            // 
            // CurrencyNegative
            // 
            _currencyNegative.BackColor = System.Drawing.SystemColors.Info;
            _currencyNegative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _currencyNegative.Cursor = System.Windows.Forms.Cursors.Hand;
            _currencyNegative.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_currencyNegative, "_currencyNegative");
            _currencyNegative.Name = "_currencyNegative";
            // 
            // CurrencyPositive
            // 
            _currencyPositive.BackColor = System.Drawing.SystemColors.Info;
            _currencyPositive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _currencyPositive.Cursor = System.Windows.Forms.Cursors.Hand;
            _currencyPositive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_currencyPositive, "_currencyPositive");
            _currencyPositive.Name = "_currencyPositive";
            // 
            // groupMoreInfo
            // 
            _groupMoreInfo.Controls.Add(_keyboardLayoutId);
            _groupMoreInfo.Controls.Add(_labelKeyboardLayoutId);
            _groupMoreInfo.Controls.Add(_neutralCulture);
            _groupMoreInfo.Controls.Add(_labelLcid);
            _groupMoreInfo.Controls.Add(_labelNeutralCulture);
            _groupMoreInfo.Controls.Add(_lcid);
            _groupMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupMoreInfo, "_groupMoreInfo");
            _groupMoreInfo.Name = "_groupMoreInfo";
            _groupMoreInfo.TabStop = false;
            // 
            // KeyboardLayoutID
            // 
            _keyboardLayoutId.BackColor = System.Drawing.SystemColors.Info;
            _keyboardLayoutId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _keyboardLayoutId.Cursor = System.Windows.Forms.Cursors.Hand;
            _keyboardLayoutId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_keyboardLayoutId, "_keyboardLayoutId");
            _keyboardLayoutId.Name = "_keyboardLayoutId";
            // 
            // labelKeyboardLayoutID
            // 
            resources.ApplyResources(_labelKeyboardLayoutId, "_labelKeyboardLayoutId");
            _labelKeyboardLayoutId.Name = "_labelKeyboardLayoutId";
            // 
            // NeutralCulture
            // 
            _neutralCulture.BackColor = System.Drawing.SystemColors.Info;
            _neutralCulture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _neutralCulture.Cursor = System.Windows.Forms.Cursors.Hand;
            _neutralCulture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_neutralCulture, "_neutralCulture");
            _neutralCulture.Name = "_neutralCulture";
            // 
            // labelLCID
            // 
            resources.ApplyResources(_labelLcid, "_labelLcid");
            _labelLcid.Name = "_labelLcid";
            // 
            // labelNeutralCulture
            // 
            resources.ApplyResources(_labelNeutralCulture, "_labelNeutralCulture");
            _labelNeutralCulture.Name = "_labelNeutralCulture";
            // 
            // LCID
            // 
            _lcid.BackColor = System.Drawing.SystemColors.Info;
            _lcid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _lcid.Cursor = System.Windows.Forms.Cursors.Hand;
            _lcid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_lcid, "_lcid");
            _lcid.Name = "_lcid";
            // 
            // About
            // 
            resources.ApplyResources(_about, "_about");
            _about.Name = "_about";
            _about.Click += new System.EventHandler(OnAboutClick);
            // 
            // ClassDetails
            // 
            resources.ApplyResources(_classDetails, "_classDetails");
            _classDetails.Name = "_classDetails";
            _classDetails.Click += new System.EventHandler(ClassDetails_Click);
            // 
            // groupText
            // 
            _groupText.Controls.Add(_listSeparator);
            _groupText.Controls.Add(_labelListSeparator);
            _groupText.Controls.Add(_labelBidi);
            _groupText.Controls.Add(_bidi);
            _groupText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupText, "_groupText");
            _groupText.Name = "_groupText";
            _groupText.TabStop = false;
            // 
            // ListSeparator
            // 
            _listSeparator.BackColor = System.Drawing.SystemColors.Info;
            _listSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _listSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
            _listSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_listSeparator, "_listSeparator");
            _listSeparator.Name = "_listSeparator";
            // 
            // labelListSeparator
            // 
            _labelListSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelListSeparator, "_labelListSeparator");
            _labelListSeparator.Name = "_labelListSeparator";
            // 
            // labelBidi
            // 
            resources.ApplyResources(_labelBidi, "_labelBidi");
            _labelBidi.Name = "_labelBidi";
            // 
            // BIDI
            // 
            _bidi.BackColor = System.Drawing.SystemColors.Info;
            _bidi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _bidi.Cursor = System.Windows.Forms.Cursors.Hand;
            _bidi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_bidi, "_bidi");
            _bidi.Name = "_bidi";
            // 
            // groupCultures
            // 
            _groupCultures.Controls.Add(_checkAllCultures);
            _groupCultures.Controls.Add(_checkUserCustomCultures);
            _groupCultures.Controls.Add(_checkWindowsOnlyCultures);
            _groupCultures.Controls.Add(_checkInstalledWin32Cultures);
            _groupCultures.Controls.Add(_checkReplacementCultures);
            _groupCultures.Controls.Add(_checkSpecificCultures);
            _groupCultures.Controls.Add(_checkNeutralCultures);
            _groupCultures.Controls.Add(_checkFrameworkCultures);
            resources.ApplyResources(_groupCultures, "_groupCultures");
            _groupCultures.Name = "_groupCultures";
            _groupCultures.TabStop = false;
            // 
            // checkAllCultures
            // 
            resources.ApplyResources(_checkAllCultures, "_checkAllCultures");
            _checkAllCultures.Name = "_checkAllCultures";
            _checkAllCultures.UseVisualStyleBackColor = true;
            _checkAllCultures.CheckedChanged += new System.EventHandler(checkAllCultures_CheckedChanged);
            // 
            // checkUserCustomCultures
            // 
            resources.ApplyResources(_checkUserCustomCultures, "_checkUserCustomCultures");
            _checkUserCustomCultures.Name = "_checkUserCustomCultures";
            _checkUserCustomCultures.UseVisualStyleBackColor = true;
            _checkUserCustomCultures.CheckedChanged += new System.EventHandler(checkUserCustomCultures_CheckedChanged);
            // 
            // checkWindowsOnlyCultures
            // 
            resources.ApplyResources(_checkWindowsOnlyCultures, "_checkWindowsOnlyCultures");
            _checkWindowsOnlyCultures.Name = "_checkWindowsOnlyCultures";
            _checkWindowsOnlyCultures.UseVisualStyleBackColor = true;
            _checkWindowsOnlyCultures.CheckedChanged += new System.EventHandler(checkWindowsOnlyCultures_CheckedChanged);
            // 
            // checkInstalledWin32Cultures
            // 
            resources.ApplyResources(_checkInstalledWin32Cultures, "_checkInstalledWin32Cultures");
            _checkInstalledWin32Cultures.Name = "_checkInstalledWin32Cultures";
            _checkInstalledWin32Cultures.UseVisualStyleBackColor = true;
            _checkInstalledWin32Cultures.CheckedChanged += new System.EventHandler(checkInstalledWin32Cultures_CheckedChanged);
            // 
            // checkReplacementCultures
            // 
            resources.ApplyResources(_checkReplacementCultures, "_checkReplacementCultures");
            _checkReplacementCultures.Name = "_checkReplacementCultures";
            _checkReplacementCultures.UseVisualStyleBackColor = true;
            _checkReplacementCultures.CheckedChanged += new System.EventHandler(checkReplacementCultures_CheckedChanged);
            // 
            // checkSpecificCultures
            // 
            resources.ApplyResources(_checkSpecificCultures, "_checkSpecificCultures");
            _checkSpecificCultures.Name = "_checkSpecificCultures";
            _checkSpecificCultures.UseVisualStyleBackColor = true;
            _checkSpecificCultures.CheckedChanged += new System.EventHandler(checkSpecificCultures_CheckedChanged);
            // 
            // checkNeutralCultures
            // 
            resources.ApplyResources(_checkNeutralCultures, "_checkNeutralCultures");
            _checkNeutralCultures.Name = "_checkNeutralCultures";
            _checkNeutralCultures.UseVisualStyleBackColor = true;
            _checkNeutralCultures.CheckedChanged += new System.EventHandler(checkNeutralCultures_CheckedChanged);
            // 
            // checkFrameworkCultures
            // 
            resources.ApplyResources(_checkFrameworkCultures, "_checkFrameworkCultures");
            _checkFrameworkCultures.Name = "_checkFrameworkCultures";
            _checkFrameworkCultures.UseVisualStyleBackColor = true;
            _checkFrameworkCultures.CheckedChanged += new System.EventHandler(checkFrameworkCultures_CheckedChanged);
            // 
            // labelCurrencyEnglishName
            // 
            _labelCurrencyEnglishName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelCurrencyEnglishName, "_labelCurrencyEnglishName");
            _labelCurrencyEnglishName.Name = "_labelCurrencyEnglishName";
            // 
            // groupCurrencyInfo
            // 
            _groupCurrencyInfo.Controls.Add(_currencyNativeName);
            _groupCurrencyInfo.Controls.Add(_labelCurrencyNativeName);
            _groupCurrencyInfo.Controls.Add(_currencyEnglishName);
            _groupCurrencyInfo.Controls.Add(_labelCurrencySymbol);
            _groupCurrencyInfo.Controls.Add(_labelCurrencyEnglishName);
            _groupCurrencyInfo.Controls.Add(_currencyIso);
            _groupCurrencyInfo.Controls.Add(_currencySymbol);
            _groupCurrencyInfo.Controls.Add(_labelCurrencyIso);
            resources.ApplyResources(_groupCurrencyInfo, "_groupCurrencyInfo");
            _groupCurrencyInfo.Name = "_groupCurrencyInfo";
            _groupCurrencyInfo.TabStop = false;
            // 
            // CurrencyNativeName
            // 
            _currencyNativeName.BackColor = System.Drawing.SystemColors.Info;
            _currencyNativeName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _currencyNativeName.Cursor = System.Windows.Forms.Cursors.Hand;
            _currencyNativeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_currencyNativeName, "_currencyNativeName");
            _currencyNativeName.Name = "_currencyNativeName";
            // 
            // labelCurrencyNativeName
            // 
            _labelCurrencyNativeName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_labelCurrencyNativeName, "_labelCurrencyNativeName");
            _labelCurrencyNativeName.Name = "_labelCurrencyNativeName";
            // 
            // CurrencyEnglishName
            // 
            _currencyEnglishName.BackColor = System.Drawing.SystemColors.Info;
            _currencyEnglishName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _currencyEnglishName.Cursor = System.Windows.Forms.Cursors.Hand;
            _currencyEnglishName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_currencyEnglishName, "_currencyEnglishName");
            _currencyEnglishName.Name = "_currencyEnglishName";
            // 
            // CurrencyISO
            // 
            _currencyIso.BackColor = System.Drawing.SystemColors.Info;
            _currencyIso.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _currencyIso.Cursor = System.Windows.Forms.Cursors.Hand;
            _currencyIso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_currencyIso, "_currencyIso");
            _currencyIso.Name = "_currencyIso";
            // 
            // CurrencySymbol
            // 
            _currencySymbol.BackColor = System.Drawing.SystemColors.Info;
            _currencySymbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _currencySymbol.Cursor = System.Windows.Forms.Cursors.Hand;
            _currencySymbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_currencySymbol, "_currencySymbol");
            _currencySymbol.Name = "_currencySymbol";
            // 
            // MainForm
            // 
            BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this, "$this");
            Controls.Add(_groupCurrencyInfo);
            Controls.Add(_groupCultures);
            Controls.Add(_groupText);
            Controls.Add(_classDetails);
            Controls.Add(_about);
            Controls.Add(_exit);
            Controls.Add(_groupMoreInfo);
            Controls.Add(_groupPercent);
            Controls.Add(_groupCurrency);
            Controls.Add(_groupNumber);
            Controls.Add(_treeCulture);
            Controls.Add(_groupDateTime);
            Controls.Add(_groupRegion);
            Controls.Add(_groupLang);
            Controls.Add(_groupName);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            _groupRegion.ResumeLayout(false);
            _groupDateTime.ResumeLayout(false);
            _groupNumber.ResumeLayout(false);
            _groupPercent.ResumeLayout(false);
            _groupLang.ResumeLayout(false);
            _groupName.ResumeLayout(false);
            _groupCurrency.ResumeLayout(false);
            _groupMoreInfo.ResumeLayout(false);
            _groupText.ResumeLayout(false);
            _groupCultures.ResumeLayout(false);
            _groupCultures.PerformLayout();
            _groupCurrencyInfo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        #region initialization methods

        private void InitializeCultureTree()
        {
            _treeCulture.Nodes.Clear();
            InsertCultures(CultureTypes.FrameworkCultures);
        }

        #endregion

        #region update methods

        public void UpdateCulture(CultureInfo ci)
        {
            if (null != ci)
            {
                // update name and non country-related ISO information
                _nameNative.Text = ci.NativeName;
                _nameDisplay.Text = ci.DisplayName;
                _nameEnglish.Text = ci.EnglishName;
                _isoLang2.Text = ci.TwoLetterISOLanguageName;
                _isoLang3.Text = ci.ThreeLetterISOLanguageName;
                _winLang.Text = ci.ThreeLetterWindowsLanguageName;
                _lcid.Text = ci.LCID.ToString("X08");
                _ietf.Text = ci.IetfLanguageTag;
                _neutralCulture.Text = ci.IsNeutralCulture.ToString();
                _nameNative.RightToLeft = ci.TextInfo.IsRightToLeft ? RightToLeft.Yes : RightToLeft.No;
                _keyboardLayoutId.Text = ci.KeyboardLayoutId.ToString("X04");
            }
            else
            {
                // update name and non country-related ISO information
                _nameNative.Text = string.Empty;
                _nameDisplay.Text = string.Empty;
                _nameEnglish.Text = string.Empty;
                _isoLang2.Text = string.Empty;
                _isoLang3.Text = string.Empty;
                _winLang.Text = string.Empty;
                _lcid.Text = string.Empty;
                _ietf.Text = string.Empty;
                _neutralCulture.Text = string.Empty;
                _nameNative.RightToLeft = RightToLeft.No;
                _keyboardLayoutId.Text = string.Empty;
            }

            UpdateCalendar(ci);
            UpdateRegionInformation(ci);
            UpdateDateTimeCalendar(ci);
            UpdateNumberInformation(ci);
            UpdateCurrencyPercentage(ci);
            UpdateTextInformation(ci);
        }

        private void UpdateCalendar(CultureInfo ci)
        {
            _comboCalendar.Items.Clear();

            if (null != ci && !ci.IsNeutralCulture)
            {
                var calendarList = ci.OptionalCalendars;
                _comboCalendar.SuspendLayout();

                foreach (var cal in calendarList)
                    _comboCalendar.Items.Add(new CalendarNameWrapper(cal));

                _comboCalendar.SelectedIndex = 0;
                _comboCalendar.ResumeLayout(true);
            }
        }

        private void UpdateRegionInformation(CultureInfo ci)
        {
            if (null == ci)
            {
                _iso2Reg.Text = string.Empty;
                _iso3Reg.Text = string.Empty;
                _winReg.Text = string.Empty;
                _metricReg.Text = string.Empty;
                _riName.Text = string.Empty;
                _riNativeName.Text = string.Empty;
                _geoId.Text = string.Empty;
                _currencySymbol.Text = string.Empty;
                _currencyIso.Text = string.Empty;
                _currencyEnglishName.Text = string.Empty;
                _currencyNativeName.Text = string.Empty;
            }

            // neutral cultures and invariant culture do not provide region information
            else if (ci.IsNeutralCulture || "iv" == ci.TwoLetterISOLanguageName)
            {
                // information is not available
                _iso2Reg.Text = Resources.NotAvailable;
                _iso3Reg.Text = Resources.NotAvailable;
                _winReg.Text = Resources.NotAvailable;
                _metricReg.Text = Resources.NotAvailable;
                _riName.Text = Resources.NotAvailable;
                _riNativeName.Text = Resources.NotAvailable;
                _geoId.Text = Resources.NotAvailable;
                _currencySymbol.Text = Resources.NotAvailable;
                _currencyIso.Text = Resources.NotAvailable;
                _currencyEnglishName.Text = Resources.NotAvailable;
                _currencyNativeName.Text = Resources.NotAvailable;
            }
            else
            {
                var ri = new RegionInfo(ci.Name);
                _iso2Reg.Text = ri.TwoLetterISORegionName;
                _iso3Reg.Text = ri.ThreeLetterISORegionName;
                _winReg.Text = ri.ThreeLetterWindowsRegionName;
                _metricReg.Text = ri.IsMetric ? Resources.True : Resources.False;
                _riName.Text = ri.Name;
                _riNativeName.Text = ri.NativeName;
                _geoId.Text = ri.GeoId.ToString();
                _currencySymbol.Text = ri.CurrencySymbol;
                _currencyIso.Text = ri.ISOCurrencySymbol;
                _currencyEnglishName.Text = ri.CurrencyEnglishName;
                _currencyNativeName.Text = ri.CurrencyNativeName;
            }
        }

        private void UpdateDateTimeCalendar(CultureInfo ci)
        {
            if (null == ci)
            {
                _dateTimeText.Text = string.Empty;
                _comboDateTime.Enabled = false;
                _comboCalendar.Enabled = false;
            }

            else if (ci.IsNeutralCulture)
            {
                _dateTimeText.Text = Resources.NotAvailable;
                _comboDateTime.Enabled = false;
                _comboCalendar.Enabled = false;
            }
            else
            {
                _comboDateTime.Enabled = true;
                _comboCalendar.Enabled = true;

                var indexCal = _comboCalendar.SelectedIndex;
                var indexDtf = _comboDateTime.SelectedIndex;

                if (-1 < indexCal && -1 < indexDtf)
                {
                    ci.DateTimeFormat.Calendar = ((CalendarNameWrapper) _comboCalendar.Items[indexCal]).Calendar;
                    var str = (string) _comboDateTime.Items[indexDtf];
                    _dateTimeText.Text = DateTime.Now.ToString(str.Substring(0, 1), ci);
                }
            }
            CalendarForm.UpdateCulture(ci);
        }

        private void UpdateNumberInformation(CultureInfo ci)
        {
            if (null == ci)
            {
                _numberPositive.Text = string.Empty;
                _numberNegative.Text = string.Empty;
                _comboNumberFormat.Enabled = false;
            }
            else if (ci.IsNeutralCulture)
            {
                _numberPositive.Text = Resources.NotAvailable;
                _numberNegative.Text = Resources.NotAvailable;
                _comboNumberFormat.Enabled = false;
            }
            else
            {
                _comboNumberFormat.Enabled = true;
                var indexNum = _comboNumberFormat.SelectedIndex;
                if (-1 < indexNum)
                {
                    var posNum = 9876543.21;
                    var negNum = -1234567.89;
                    var str = ((string) _comboNumberFormat.Items[indexNum]).Substring(0, 1);
                    _numberPositive.Text = posNum.ToString(str, ci);
                    _numberNegative.Text = negNum.ToString(str, ci);
                }
            }
            NumberForm.UpdateCulture(ci);
        }

        private void UpdateCurrencyPercentage(CultureInfo ci)
        {
            if (null == ci)
            {
                _currencyPositive.Text = string.Empty;
                _currencyNegative.Text = string.Empty;
                _percentPositive.Text = string.Empty;
                _percentNegative.Text = string.Empty;
            }
            else if (ci.IsNeutralCulture)
            {
                _currencyPositive.Text = Resources.NotAvailable;
                _currencyNegative.Text = Resources.NotAvailable;
                _percentPositive.Text = Resources.NotAvailable;
                _percentNegative.Text = Resources.NotAvailable;
            }
            else
            {
                var posCur = 9876543.21;
                var negCur = -1234567.89;
                _currencyPositive.Text = posCur.ToString("C", ci);
                _currencyNegative.Text = negCur.ToString("C", ci);

                var posPer = 0.9876;
                var negPer = -0.1234;
                _percentPositive.Text = posPer.ToString("P", ci);
                _percentNegative.Text = negPer.ToString("P", ci);
            }
            CurrencyForm.UpdateCulture(ci);
            PercentForm.UpdateCulture(ci);
        }

        private void UpdateTextInformation(CultureInfo ci)
        {
            if (null == ci)
            {
                _bidi.Text = string.Empty;
                _listSeparator.Text = string.Empty;
            }
            else
            {
                _bidi.Text = ci.TextInfo.IsRightToLeft ? bool.TrueString : bool.FalseString;
                _listSeparator.Text = ci.TextInfo.ListSeparator;
            }
        }

        private void UpdateCultureTree()
        {
            _treeCulture.Nodes.Clear();
            _treeCulture.SuspendLayout();

            if (_checkFrameworkCultures.Checked)
                InsertCultures(CultureTypes.FrameworkCultures);

            if (_checkNeutralCultures.Checked)
                InsertCultures(CultureTypes.NeutralCultures);

            if (_checkSpecificCultures.Checked)
                InsertCultures(CultureTypes.SpecificCultures);

            if (_checkWindowsOnlyCultures.Checked)
                InsertCultures(CultureTypes.WindowsOnlyCultures);

            if (_checkInstalledWin32Cultures.Checked)
                InsertCultures(CultureTypes.InstalledWin32Cultures);

            if (_checkUserCustomCultures.Checked)
                InsertCultures(CultureTypes.UserCustomCulture);

            if (_checkReplacementCultures.Checked)
                InsertCultures(CultureTypes.ReplacementCultures);

            if (_checkAllCultures.Checked)
                InsertCultures(CultureTypes.AllCultures);

            // if tree is empty, clear all
            if (0 == _treeCulture.Nodes.Count)
            {
                Ci = null;
                UpdateCulture(Ci);
            }

            _treeCulture.ResumeLayout();
        }

        #endregion

        #region culture tree related methods

        private void InsertCultures(CultureTypes type)
        {
            var cultures = CultureInfo.GetCultures(type);

            switch (type)
            {
                case CultureTypes.FrameworkCultures:
                    CreateFrameworkNode(Resources.FrameworkCultures, (int) CultureIcons.Framework, cultures);
                    break;

                case CultureTypes.InstalledWin32Cultures:
                    CreateNode(Resources.InstalledWin32Cultures, (int) CultureIcons.Installed, cultures);
                    break;

                case CultureTypes.NeutralCultures:
                    CreateNode(Resources.NeutralCultures, (int) CultureIcons.Neutral, cultures);
                    break;

                case CultureTypes.ReplacementCultures:
                    CreateNode(Resources.ReplacementCultures, (int) CultureIcons.Replacement, cultures);
                    break;

                case CultureTypes.SpecificCultures:
                    CreateNode(Resources.SpecificCultures, (int) CultureIcons.Specific, cultures);
                    break;

                case CultureTypes.UserCustomCulture:
                    CreateNode(Resources.CustomUserCultures, (int) CultureIcons.Custom, cultures);
                    break;

                case CultureTypes.WindowsOnlyCultures:
                    CreateNode(Resources.WindowsOnlyCultures, (int) CultureIcons.WinOnly, cultures);
                    break;

                case CultureTypes.AllCultures:
                    CreateNode(Resources.AllCultures, (int) CultureIcons.All, cultures);
                    break;
            }

            // try and select first child of first child so we have a culture selected
            try
            {
                _treeCulture.SelectedNode = _treeCulture.Nodes[0].Nodes[0];
            }
            catch
            {
            }
        }

        private void CreateNode(string title, int index, CultureInfo[] cultures)
        {
            var rootNode = _treeCulture.Nodes.Add(title, title, index, index);
            foreach (var culture in cultures)
            {
                int cultureIndex;
                var cultureTitle = string.Empty == culture.Name ? Resources.Invariant : culture.ToString();

                if (string.Empty == culture.Name)
                    cultureIndex = (int) CultureIcons.Invariant;
                else
                    cultureIndex = culture.IsNeutralCulture ? (int) CultureIcons.Neutral : (int) CultureIcons.Specific;

                rootNode.Nodes.Add(cultureTitle, cultureTitle, cultureIndex, cultureIndex);
            }
        }

        private void CreateFrameworkNode(string title, int index, CultureInfo[] cultures)
        {
            var rootNode = _treeCulture.Nodes.Add(title, title, index, index);

            // create invariant node
            var invariantNode = rootNode.Nodes.Add(Resources.Invariant, Resources.Invariant, (int) CultureIcons.Invariant, (int) CultureIcons.Invariant);

            // add neutral cultures nodes
            foreach (var culture in cultures)
                if (culture.IsNeutralCulture)
                    invariantNode.Nodes.Add(culture.Name, culture.Name, (int) CultureIcons.Neutral, (int) CultureIcons.Neutral);

            // add specific cultures nodes
            foreach (var culture in cultures)
                if (!culture.IsNeutralCulture && string.Empty != culture.Name)
                {
                    var parentNodes = invariantNode.Nodes.Find(culture.Parent.Name, false);
                    if (1 != parentNodes.Length)
                        throw new Exception("Cannot have more than one parent with the same culture name!");
                    parentNodes[0].Nodes.Add(culture.Name, culture.Name, (int) CultureIcons.Specific, (int) CultureIcons.Specific);
                }
        }

        #endregion

        #region event handlers

        private void comboDateTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDateTimeCalendar(Ci);
        }

        private void comboCalendar_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDateTimeCalendar(Ci);
        }

        private void comboNumberFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateNumberInformation(Ci);
        }

        private void treeCulture_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var strNode = e.Node.Text;

            // special case for invariant
            if (Resources.Invariant == strNode)
                strNode = "";

            try
            {
                Ci = new CultureInfo(strNode);
            }
            catch
            {
                Ci = null;
            }

            UpdateCulture(Ci);
        }

        private void NumberDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (NumberForm.Visible)
                NumberForm.Hide();
            else
                NumberForm.Show();
        }

        private void CurrencyDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CurrencyForm.Visible)
                CurrencyForm.Hide();
            else
                CurrencyForm.Show();
        }

        private void PercentDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (PercentForm.Visible)
                PercentForm.Hide();
            else
                PercentForm.Show();
        }

        private void DateTimeDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (CalendarForm.Visible)
                CalendarForm.Hide();
            else
                CalendarForm.Show();
        }

        private void ClassDetails_Click(object sender, EventArgs e)
        {
            if (ClassForm.Visible)
                ClassForm.Hide();
            else
                ClassForm.Show();
        }

        private void OnAboutClick(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkFrameworkCultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        private void checkNeutralCultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        private void checkSpecificCultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        private void checkInstalledWin32Cultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        private void checkWindowsOnlyCultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        private void checkUserCustomCultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        private void checkReplacementCultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        private void checkAllCultures_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCultureTree();
        }

        #endregion

        #region class coloring methods

        public void NotifyClassColorChange(ProgramSettings.ClassColor cc)
        {
            ClassColor(cc);
            NumberForm.ClassColor(cc);
            CurrencyForm.ClassColor(cc);
            PercentForm.ClassColor(cc);
            CalendarForm.ClassColor(cc);
        }

        public void ClassColor(ProgramSettings.ClassColor cc)
        {
            switch (cc)
            {
                case ProgramSettings.ClassColor.ApplyCultureInfo:
                    ColorCi(ProgramSettings.ColorCultureInfo);
                    break;

                case ProgramSettings.ClassColor.ClearCultureInfo:
                    ColorCi(ProgramSettings.ColorNone);
                    break;

                case ProgramSettings.ClassColor.ApplyRegionInfo:
                    ColorRi(ProgramSettings.ColorRegionInfo);
                    break;

                case ProgramSettings.ClassColor.ClearRegionInfo:
                    ColorRi(ProgramSettings.ColorNone);
                    break;

                case ProgramSettings.ClassColor.ApplyDateTimeFormatInfo:
                    _dateTimeText.BackColor = ProgramSettings.ColorDateTimeFormatInfo;
                    break;

                case ProgramSettings.ClassColor.ClearDateTimeFormatInfo:
                    _dateTimeText.BackColor = ProgramSettings.ColorNone;
                    break;

                case ProgramSettings.ClassColor.ApplyNumberFormatInfo:
                    ColorNfi(ProgramSettings.ColorNumberFormatInfo);
                    break;

                case ProgramSettings.ClassColor.ClearNumberFormatInfo:
                    ColorNfi(ProgramSettings.ColorNone);
                    break;

                case ProgramSettings.ClassColor.ApplyTextInfo:
                    ColorTi(ProgramSettings.ColorTextInfo);
                    break;

                case ProgramSettings.ClassColor.ClearTextInfo:
                    ColorTi(ProgramSettings.ColorNone);
                    break;

                case ProgramSettings.ClassColor.ApplyCalendar:
                    ColorCalendar(ProgramSettings.ColorCalendar);
                    break;

                case ProgramSettings.ClassColor.ClearCalendar:
                    ColorCalendar(ProgramSettings.ColorNone);
                    break;
            }
        }

        private void ColorCi(Color color)
        {
            _nameNative.BackColor = color;
            _nameDisplay.BackColor = color;
            _nameEnglish.BackColor = color;
            _isoLang2.BackColor = color;
            _isoLang3.BackColor = color;
            _winLang.BackColor = color;
            _lcid.BackColor = color;
            _ietf.BackColor = color;
            _neutralCulture.BackColor = color;
            _keyboardLayoutId.BackColor = color;
        }

        private void ColorRi(Color color)
        {
            _iso2Reg.BackColor = color;
            _iso3Reg.BackColor = color;
            _winReg.BackColor = color;
            _metricReg.BackColor = color;
            _riName.BackColor = color;
            _riNativeName.BackColor = color;
            _geoId.BackColor = color;
            _currencySymbol.BackColor = color;
            _currencyIso.BackColor = color;
            _currencyEnglishName.BackColor = color;
            _currencyNativeName.BackColor = color;
        }

        private void ColorNfi(Color color)
        {
            _numberPositive.BackColor = color;
            _numberNegative.BackColor = color;
            _currencyPositive.BackColor = color;
            _currencyNegative.BackColor = color;
            _percentPositive.BackColor = color;
            _percentNegative.BackColor = color;
        }

        private void ColorTi(Color color)
        {
            _bidi.BackColor = color;
            _listSeparator.BackColor = color;
        }

        private void ColorCalendar(Color color)
        {
            // do nothing as no calendar-class based information is displayed within this form
        }

        #endregion
    }
}