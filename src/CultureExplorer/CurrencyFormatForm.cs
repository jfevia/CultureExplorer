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
    ///     Summary description for CurrencyFormatForm.
    /// </summary>
    public class CurrencyFormatForm : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Button _buttonClose;

        private CultureExplorerLabel _decimalDigits;
        private CultureExplorerLabel _decimalSeparator;
        private GroupBox _groupCurrency;
        private CultureExplorerLabel _groupSeparator;
        private CultureExplorerLabel _groupSizes;
        private Label _labelDecimalDigits;
        private Label _labelDecimalSeparator;
        private Label _labelGroupSeparator;
        private Label _labelGroupSizes;
        private Label _labelNegativePattern;
        private Label _labelPositivePattern;
        private Label _labelSymbol;
        private CultureExplorerLabel _negativePattern;
        private CultureExplorerLabel _positivePattern;
        private CultureExplorerLabel _symbol;

        public CurrencyFormatForm(CultureInfo ci)
        {
            InitializeComponent();
            UpdateCulture(ci);
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
            var resources = new ComponentResourceManager(typeof(CurrencyFormatForm));
            _buttonClose = new Button();
            _groupCurrency = new System.Windows.Forms.GroupBox();
            _labelPositivePattern = new Label();
            _labelNegativePattern = new Label();
            _labelGroupSeparator = new Label();
            _labelGroupSizes = new Label();
            _labelDecimalSeparator = new Label();
            _labelDecimalDigits = new Label();
            _labelSymbol = new Label();
            _negativePattern = new CultureExplorerLabel();
            _positivePattern = new CultureExplorerLabel();
            _groupSeparator = new CultureExplorerLabel();
            _groupSizes = new CultureExplorerLabel();
            _decimalSeparator = new CultureExplorerLabel();
            _decimalDigits = new CultureExplorerLabel();
            _symbol = new CultureExplorerLabel();
            _groupCurrency.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            resources.ApplyResources(_buttonClose, "_buttonClose");
            _buttonClose.Name = "_buttonClose";
            _buttonClose.Click += new System.EventHandler(buttonClose_Click);
            // 
            // groupCurrency
            // 
            _groupCurrency.Controls.Add(_negativePattern);
            _groupCurrency.Controls.Add(_positivePattern);
            _groupCurrency.Controls.Add(_groupSeparator);
            _groupCurrency.Controls.Add(_groupSizes);
            _groupCurrency.Controls.Add(_decimalSeparator);
            _groupCurrency.Controls.Add(_decimalDigits);
            _groupCurrency.Controls.Add(_symbol);
            _groupCurrency.Controls.Add(_labelPositivePattern);
            _groupCurrency.Controls.Add(_labelNegativePattern);
            _groupCurrency.Controls.Add(_labelGroupSeparator);
            _groupCurrency.Controls.Add(_labelGroupSizes);
            _groupCurrency.Controls.Add(_labelDecimalSeparator);
            _groupCurrency.Controls.Add(_labelDecimalDigits);
            _groupCurrency.Controls.Add(_labelSymbol);
            _groupCurrency.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupCurrency, "_groupCurrency");
            _groupCurrency.Name = "_groupCurrency";
            _groupCurrency.TabStop = false;
            // 
            // labelPositivePattern
            // 
            _labelPositivePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelPositivePattern, "_labelPositivePattern");
            _labelPositivePattern.Name = "_labelPositivePattern";
            // 
            // labelNegativePattern
            // 
            _labelNegativePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelNegativePattern, "_labelNegativePattern");
            _labelNegativePattern.Name = "_labelNegativePattern";
            // 
            // labelGroupSeparator
            // 
            _labelGroupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelGroupSeparator, "_labelGroupSeparator");
            _labelGroupSeparator.Name = "_labelGroupSeparator";
            // 
            // labelGroupSizes
            // 
            _labelGroupSizes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelGroupSizes, "_labelGroupSizes");
            _labelGroupSizes.Name = "_labelGroupSizes";
            // 
            // labelDecimalSeparator
            // 
            _labelDecimalSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelDecimalSeparator, "_labelDecimalSeparator");
            _labelDecimalSeparator.Name = "_labelDecimalSeparator";
            // 
            // labelDecimalDigits
            // 
            _labelDecimalDigits.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelDecimalDigits, "_labelDecimalDigits");
            _labelDecimalDigits.Name = "_labelDecimalDigits";
            // 
            // labelSymbol
            // 
            _labelSymbol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelSymbol, "_labelSymbol");
            _labelSymbol.Name = "_labelSymbol";
            // 
            // NegativePattern
            // 
            _negativePattern.BackColor = System.Drawing.SystemColors.Info;
            _negativePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _negativePattern.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_negativePattern, "_negativePattern");
            _negativePattern.Name = "_negativePattern";
            // 
            // PositivePattern
            // 
            _positivePattern.BackColor = System.Drawing.SystemColors.Info;
            _positivePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _positivePattern.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_positivePattern, "_positivePattern");
            _positivePattern.Name = "_positivePattern";
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
            // DecimalSeparator
            // 
            _decimalSeparator.BackColor = System.Drawing.SystemColors.Info;
            _decimalSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _decimalSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_decimalSeparator, "_decimalSeparator");
            _decimalSeparator.Name = "_decimalSeparator";
            // 
            // DecimalDigits
            // 
            _decimalDigits.BackColor = System.Drawing.SystemColors.Info;
            _decimalDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _decimalDigits.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_decimalDigits, "_decimalDigits");
            _decimalDigits.Name = "_decimalDigits";
            // 
            // Symbol
            // 
            _symbol.BackColor = System.Drawing.SystemColors.Info;
            _symbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _symbol.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(_symbol, "_symbol");
            _symbol.Name = "_symbol";
            // 
            // CurrencyFormatForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(_groupCurrency);
            Controls.Add(_buttonClose);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            Name = "CurrencyFormatForm";
            ShowInTaskbar = false;
            Closing += new System.ComponentModel.CancelEventHandler(OnClosing);
            _groupCurrency.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public void UpdateCulture(CultureInfo ci)
        {
            if (null == ci)
            {
                _symbol.Text = string.Empty;
                _decimalDigits.Text = string.Empty;
                _decimalSeparator.Text = string.Empty;
                _groupSeparator.Text = string.Empty;
                _positivePattern.Text = string.Empty;
                _negativePattern.Text = string.Empty;
                _groupSizes.Text = string.Empty;
            }
            else if (ci.IsNeutralCulture)
            {
                _symbol.Text = Resources.NotAvailable;
                _decimalDigits.Text = Resources.NotAvailable;
                _decimalSeparator.Text = Resources.NotAvailable;
                _groupSeparator.Text = Resources.NotAvailable;
                _positivePattern.Text = Resources.NotAvailable;
                _negativePattern.Text = Resources.NotAvailable;
                _groupSizes.Text = Resources.NotAvailable;
            }
            else
            {
                _symbol.Text = ci.NumberFormat.CurrencySymbol;
                _decimalDigits.Text = ci.NumberFormat.CurrencyDecimalDigits.ToString(ci);
                _decimalSeparator.Text = ci.NumberFormat.CurrencyDecimalSeparator.ToString(ci);
                _groupSeparator.Text = ci.NumberFormat.CurrencyGroupSeparator.ToString(ci);
                _positivePattern.Text = ci.NumberFormat.CurrencyPositivePattern.ToString(ci);
                _negativePattern.Text = ci.NumberFormat.CurrencyNegativePattern.ToString(ci);

                // parse group sizes
                var sb = new StringBuilder();
                int i;
                for (i = 0; i < ci.NumberFormat.CurrencyGroupSizes.GetLength(0) - 1; i++)
                {
                    sb.Append(ci.NumberFormat.CurrencyGroupSizes[i].ToString(ci));
                    sb.Append(ci.TextInfo.ListSeparator);
                }
                sb.Append(ci.NumberFormat.CurrencyGroupSizes[i].ToString(ci));
                _groupSizes.Text = sb.ToString();
            }
        }

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
            _symbol.BackColor = color;
            _decimalDigits.BackColor = color;
            _decimalSeparator.BackColor = color;
            _groupSeparator.BackColor = color;
            _positivePattern.BackColor = color;
            _negativePattern.BackColor = color;
            _groupSizes.BackColor = color;
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
    }
}