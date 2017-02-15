using System;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using CultureExplorer.Properties;

namespace CultureExplorer
{
    /// <summary>
    ///     Summary description for NumberFormat.
    /// </summary>
    public class NumberFormatForm : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Button _buttonClose;

        private CultureExplorerLabel _decimalDigits;
        private CultureExplorerLabel _decimalSeparator;
        private CultureExplorerLabel _digitSubstitution;
        private GroupBox _groupDigits;
        private CultureExplorerLabel _groupSeparator;
        private CultureExplorerLabel _groupSizes;
        private GroupBox _groupSymbols;
        private Label _labelDecimalDigits;
        private Label _labelDecimalSeparator;
        private Label _labelDigitSubstitution;
        private Label _labelGroupSeparator;
        private Label _labelGroupSizes;
        private Label _labelNan;
        private Label _labelNegativeInfinity;
        private Label _labelNegativePattern;
        private Label _labelNegativeSign;
        private Label _labelPositiveInfinity;
        private Label _labelPositiveSign;
        private CultureExplorerLabel _nan;
        private CultureExplorerLabel _negativeInfinity;
        private CultureExplorerLabel _negativePattern;
        private CultureExplorerLabel _negativeSign;
        private CultureExplorerLabel _positiveInfinity;
        private CultureExplorerLabel _positiveSign;

        public NumberFormatForm(CultureInfo ci)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            UpdateCulture(ci);
        }

        public void UpdateCulture(CultureInfo ci)
        {
            if (null == ci)
            {
                _decimalDigits.Text = string.Empty;
                _decimalSeparator.Text = string.Empty;
                _groupSeparator.Text = string.Empty;
                _negativePattern.Text = string.Empty;
                _positiveSign.Text = string.Empty;
                _positiveInfinity.Text = string.Empty;
                _negativeSign.Text = string.Empty;
                _negativeInfinity.Text = string.Empty;
                _nan.Text = string.Empty;
                _groupSizes.Text = string.Empty;
                _digitSubstitution.Text = string.Empty;
            }
            else if (ci.IsNeutralCulture)
            {
                // Set values for information labels
                _decimalDigits.Text = Resources.NotAvailable;
                _decimalSeparator.Text = Resources.NotAvailable;
                _groupSeparator.Text = Resources.NotAvailable;
                _negativePattern.Text = Resources.NotAvailable;
                _positiveSign.Text = Resources.NotAvailable;
                _positiveInfinity.Text = Resources.NotAvailable;
                _negativeSign.Text = Resources.NotAvailable;
                _negativeInfinity.Text = Resources.NotAvailable;
                _nan.Text = Resources.NotAvailable;
                _groupSizes.Text = Resources.NotAvailable;
                _digitSubstitution.Text = Resources.NotAvailable;
            }
            else
            {
                _decimalDigits.Text = ci.NumberFormat.NumberDecimalDigits.ToString(ci);
                _decimalSeparator.Text = ci.NumberFormat.NumberDecimalSeparator.ToString(ci);
                _groupSeparator.Text = ci.NumberFormat.NumberGroupSeparator.ToString(ci);
                _negativePattern.Text = ci.NumberFormat.NumberNegativePattern.ToString(ci);
                _positiveSign.Text = ci.NumberFormat.PositiveSign;
                _positiveInfinity.Text = ci.NumberFormat.PositiveInfinitySymbol;
                _negativeSign.Text = ci.NumberFormat.NegativeSign;
                _negativeInfinity.Text = ci.NumberFormat.NegativeInfinitySymbol;
                _nan.Text = ci.NumberFormat.NaNSymbol;

                // get digit substitution information
                switch (ci.NumberFormat.DigitSubstitution)
                {
                    case DigitShapes.Context:
                        _digitSubstitution.Text = Resources.DigitShapesContext;
                        break;

                    case DigitShapes.NativeNational:
                        _digitSubstitution.Text = Resources.DigitShapesNativeNational;
                        break;

                    case DigitShapes.None:
                        _digitSubstitution.Text = Resources.DigitShapesNone;
                        break;
                }

                // parse group sizes
                var sb = new StringBuilder();
                int i;
                for (i = 0; i < ci.NumberFormat.NumberGroupSizes.GetLength(0) - 1; i++)
                {
                    sb.Append(ci.NumberFormat.NumberGroupSizes[i].ToString(ci));
                    sb.Append(ci.TextInfo.ListSeparator);
                }
                sb.Append(ci.NumberFormat.NumberGroupSizes[i].ToString(ci));
                _groupSizes.Text = sb.ToString();
            }
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
            var resources = new ComponentResourceManager(typeof(NumberFormatForm));
            _labelPositiveInfinity = new Label();
            _labelGroupSizes = new Label();
            _decimalDigits = new CultureExplorerLabel();
            _positiveSign = new CultureExplorerLabel();
            _decimalSeparator = new CultureExplorerLabel();
            _labelNegativePattern = new Label();
            _labelPositiveSign = new Label();
            _labelNan = new Label();
            _labelGroupSeparator = new Label();
            _nan = new CultureExplorerLabel();
            _labelDecimalDigits = new Label();
            _groupDigits = new System.Windows.Forms.GroupBox();
            _negativePattern = new CultureExplorerLabel();
            _groupSeparator = new CultureExplorerLabel();
            _groupSizes = new CultureExplorerLabel();
            _labelDecimalSeparator = new Label();
            _groupSymbols = new System.Windows.Forms.GroupBox();
            _negativeInfinity = new CultureExplorerLabel();
            _negativeSign = new CultureExplorerLabel();
            _positiveInfinity = new CultureExplorerLabel();
            _labelNegativeSign = new Label();
            _labelNegativeInfinity = new Label();
            _buttonClose = new Button();
            _labelDigitSubstitution = new Label();
            _digitSubstitution = new CultureExplorerLabel();
            _groupDigits.SuspendLayout();
            _groupSymbols.SuspendLayout();
            SuspendLayout();
            // 
            // labelPositiveInfinity
            // 
            _labelPositiveInfinity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelPositiveInfinity, "_labelPositiveInfinity");
            _labelPositiveInfinity.Name = "_labelPositiveInfinity";
            // 
            // labelGroupSizes
            // 
            _labelGroupSizes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelGroupSizes, "_labelGroupSizes");
            _labelGroupSizes.Name = "_labelGroupSizes";
            // 
            // DecimalDigits
            // 
            _decimalDigits.BackColor = System.Drawing.SystemColors.Info;
            _decimalDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _decimalDigits.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_decimalDigits, "_decimalDigits");
            _decimalDigits.Name = "_decimalDigits";
            // 
            // PositiveSign
            // 
            _positiveSign.BackColor = System.Drawing.SystemColors.Info;
            _positiveSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _positiveSign.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_positiveSign, "_positiveSign");
            _positiveSign.Name = "_positiveSign";
            // 
            // DecimalSeparator
            // 
            _decimalSeparator.BackColor = System.Drawing.SystemColors.Info;
            _decimalSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _decimalSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_decimalSeparator, "_decimalSeparator");
            _decimalSeparator.Name = "_decimalSeparator";
            // 
            // labelNegativePattern
            // 
            _labelNegativePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelNegativePattern, "_labelNegativePattern");
            _labelNegativePattern.Name = "_labelNegativePattern";
            // 
            // labelPositiveSign
            // 
            _labelPositiveSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelPositiveSign, "_labelPositiveSign");
            _labelPositiveSign.Name = "_labelPositiveSign";
            // 
            // labelNAN
            // 
            _labelNan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelNan, "_labelNan");
            _labelNan.Name = "_labelNan";
            // 
            // labelGroupSeparator
            // 
            _labelGroupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelGroupSeparator, "_labelGroupSeparator");
            _labelGroupSeparator.Name = "_labelGroupSeparator";
            // 
            // NAN
            // 
            _nan.BackColor = System.Drawing.SystemColors.Info;
            _nan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _nan.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_nan, "_nan");
            _nan.Name = "_nan";
            // 
            // labelDecimalDigits
            // 
            _labelDecimalDigits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelDecimalDigits, "_labelDecimalDigits");
            _labelDecimalDigits.Name = "_labelDecimalDigits";
            // 
            // groupDigits
            // 
            _groupDigits.Controls.Add(_digitSubstitution);
            _groupDigits.Controls.Add(_labelDigitSubstitution);
            _groupDigits.Controls.Add(_negativePattern);
            _groupDigits.Controls.Add(_labelNegativePattern);
            _groupDigits.Controls.Add(_groupSeparator);
            _groupDigits.Controls.Add(_groupSizes);
            _groupDigits.Controls.Add(_labelGroupSizes);
            _groupDigits.Controls.Add(_labelGroupSeparator);
            _groupDigits.Controls.Add(_decimalSeparator);
            _groupDigits.Controls.Add(_labelDecimalSeparator);
            _groupDigits.Controls.Add(_decimalDigits);
            _groupDigits.Controls.Add(_labelDecimalDigits);
            _groupDigits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupDigits, "_groupDigits");
            _groupDigits.Name = "_groupDigits";
            _groupDigits.TabStop = false;
            // 
            // NegativePattern
            // 
            _negativePattern.BackColor = System.Drawing.SystemColors.Info;
            _negativePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _negativePattern.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_negativePattern, "_negativePattern");
            _negativePattern.Name = "_negativePattern";
            // 
            // GroupSeparator
            // 
            _groupSeparator.BackColor = System.Drawing.SystemColors.Info;
            _groupSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _groupSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_groupSeparator, "_groupSeparator");
            _groupSeparator.Name = "_groupSeparator";
            // 
            // GroupSizes
            // 
            _groupSizes.BackColor = System.Drawing.SystemColors.Info;
            _groupSizes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _groupSizes.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_groupSizes, "_groupSizes");
            _groupSizes.Name = "_groupSizes";
            // 
            // labelDecimalSeparator
            // 
            _labelDecimalSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelDecimalSeparator, "_labelDecimalSeparator");
            _labelDecimalSeparator.Name = "_labelDecimalSeparator";
            // 
            // groupSymbols
            // 
            _groupSymbols.Controls.Add(_nan);
            _groupSymbols.Controls.Add(_negativeInfinity);
            _groupSymbols.Controls.Add(_negativeSign);
            _groupSymbols.Controls.Add(_positiveInfinity);
            _groupSymbols.Controls.Add(_positiveSign);
            _groupSymbols.Controls.Add(_labelNan);
            _groupSymbols.Controls.Add(_labelPositiveSign);
            _groupSymbols.Controls.Add(_labelPositiveInfinity);
            _groupSymbols.Controls.Add(_labelNegativeSign);
            _groupSymbols.Controls.Add(_labelNegativeInfinity);
            _groupSymbols.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupSymbols, "_groupSymbols");
            _groupSymbols.Name = "_groupSymbols";
            _groupSymbols.TabStop = false;
            // 
            // NegativeInfinity
            // 
            _negativeInfinity.BackColor = System.Drawing.SystemColors.Info;
            _negativeInfinity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _negativeInfinity.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_negativeInfinity, "_negativeInfinity");
            _negativeInfinity.Name = "_negativeInfinity";
            // 
            // NegativeSign
            // 
            _negativeSign.BackColor = System.Drawing.SystemColors.Info;
            _negativeSign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _negativeSign.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_negativeSign, "_negativeSign");
            _negativeSign.Name = "_negativeSign";
            // 
            // PositiveInfinity
            // 
            _positiveInfinity.BackColor = System.Drawing.SystemColors.Info;
            _positiveInfinity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _positiveInfinity.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_positiveInfinity, "_positiveInfinity");
            _positiveInfinity.Name = "_positiveInfinity";
            // 
            // labelNegativeSign
            // 
            _labelNegativeSign.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelNegativeSign, "_labelNegativeSign");
            _labelNegativeSign.Name = "_labelNegativeSign";
            // 
            // labelNegativeInfinity
            // 
            _labelNegativeInfinity.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelNegativeInfinity, "_labelNegativeInfinity");
            _labelNegativeInfinity.Name = "_labelNegativeInfinity";
            // 
            // buttonClose
            // 
            resources.ApplyResources(_buttonClose, "_buttonClose");
            _buttonClose.Name = "_buttonClose";
            _buttonClose.Click += new System.EventHandler(buttonClose_Click);
            // 
            // labelDigitSubstitution
            // 
            resources.ApplyResources(_labelDigitSubstitution, "_labelDigitSubstitution");
            _labelDigitSubstitution.Name = "_labelDigitSubstitution";
            // 
            // DigitSubstitution
            // 
            _digitSubstitution.BackColor = System.Drawing.SystemColors.Info;
            _digitSubstitution.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _digitSubstitution.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_digitSubstitution, "_digitSubstitution");
            _digitSubstitution.Name = "_digitSubstitution";
            // 
            // NumberFormatForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(_buttonClose);
            Controls.Add(_groupSymbols);
            Controls.Add(_groupDigits);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NumberFormatForm";
            ShowInTaskbar = false;
            Closing += new System.ComponentModel.CancelEventHandler(OnClosing);
            _groupDigits.ResumeLayout(false);
            _groupDigits.PerformLayout();
            _groupSymbols.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public void ClassColor(ProgramSettings.ClassColor cc)
        {
            switch (cc)
            {
                case ProgramSettings.ClassColor.ApplyNumberFormatInfo:
                    ColorNfi(ProgramSettings.ColorNumberFormatInfo);
                    break;

                case ProgramSettings.ClassColor.ClearNumberFormatInfo:
                    ColorNfi(ProgramSettings.ColorNone);
                    break;
            }
        }

        private void ColorNfi(Color color)
        {
            _decimalDigits.BackColor = color;
            _decimalSeparator.BackColor = color;
            _groupSeparator.BackColor = color;
            _negativePattern.BackColor = color;
            _positiveSign.BackColor = color;
            _positiveInfinity.BackColor = color;
            _negativeSign.BackColor = color;
            _negativeInfinity.BackColor = color;
            _nan.BackColor = color;
            _groupSizes.BackColor = color;
            _digitSubstitution.BackColor = color;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}