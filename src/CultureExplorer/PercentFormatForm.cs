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
    ///     Summary description for PercentFormatForm.
    /// </summary>
    public class PercentFormatForm : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Button _buttonClose;

        private CultureExplorerLabel _decimalDigits;
        private CultureExplorerLabel _decimalSeparator;
        private GroupBox _groupPercent;
        private GroupBox _groupPerMille;
        private CultureExplorerLabel _groupSeparator;
        private CultureExplorerLabel _groupSizes;
        private Label _labelDecimalDigits;
        private Label _labelDecimalSeparator;
        private Label _labelGroupSeparator;
        private Label _labelGroupSizes;
        private Label _labelNegativePattern;
        private CultureExplorerLabel _labelPerMille;
        private Label _labelPositivePattern;
        private Label _labelSymbol;
        private CultureExplorerLabel _negativePattern;
        private CultureExplorerLabel _perMille;
        private CultureExplorerLabel _positivePattern;
        private CultureExplorerLabel _symbol;

        public PercentFormatForm(CultureInfo ci)
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
                _symbol.Text = string.Empty;
                _decimalDigits.Text = string.Empty;
                _decimalSeparator.Text = string.Empty;
                _groupSeparator.Text = string.Empty;
                _positivePattern.Text = string.Empty;
                _negativePattern.Text = string.Empty;
                _perMille.Text = string.Empty;
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
                _perMille.Text = Resources.NotAvailable;
                _groupSizes.Text = Resources.NotAvailable;
            }
            else
            {
                // Set values for information labels
                _symbol.Text = ci.NumberFormat.PercentSymbol;
                _decimalDigits.Text = ci.NumberFormat.PercentDecimalDigits.ToString(ci);
                _decimalSeparator.Text = ci.NumberFormat.PercentDecimalSeparator.ToString(ci);
                _groupSeparator.Text = ci.NumberFormat.PercentGroupSeparator.ToString(ci);
                _positivePattern.Text = ci.NumberFormat.PercentPositivePattern.ToString(ci);
                _negativePattern.Text = ci.NumberFormat.PercentNegativePattern.ToString(ci);
                _perMille.Text = ci.NumberFormat.PerMilleSymbol;

                // parse group sizes
                var sb = new StringBuilder();
                var numGroupSizes = ci.NumberFormat.PercentGroupSizes.GetLength(0);
                int i;
                for (i = 0; i < numGroupSizes - 1; i++)
                {
                    sb.Append(ci.NumberFormat.PercentGroupSizes[i].ToString(ci));
                    sb.Append(ci.TextInfo.ListSeparator);
                }
                sb.Append(ci.NumberFormat.PercentGroupSizes[i].ToString(ci));
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
            var resources = new ComponentResourceManager(typeof(PercentFormatForm));
            _labelGroupSeparator = new Label();
            _negativePattern = new CultureExplorerLabel();
            _groupPerMille = new System.Windows.Forms.GroupBox();
            _labelPerMille = new CultureExplorerLabel();
            _perMille = new CultureExplorerLabel();
            _labelDecimalSeparator = new Label();
            _labelDecimalDigits = new Label();
            _buttonClose = new Button();
            _positivePattern = new CultureExplorerLabel();
            _groupSizes = new CultureExplorerLabel();
            _labelNegativePattern = new Label();
            _decimalDigits = new CultureExplorerLabel();
            _groupSeparator = new CultureExplorerLabel();
            _symbol = new CultureExplorerLabel();
            _decimalSeparator = new CultureExplorerLabel();
            _labelSymbol = new Label();
            _labelGroupSizes = new Label();
            _groupPercent = new System.Windows.Forms.GroupBox();
            _labelPositivePattern = new Label();
            _groupPerMille.SuspendLayout();
            _groupPercent.SuspendLayout();
            SuspendLayout();
            // 
            // labelGroupSeparator
            // 
            _labelGroupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelGroupSeparator, "_labelGroupSeparator");
            _labelGroupSeparator.Name = "_labelGroupSeparator";
            // 
            // NegativePattern
            // 
            _negativePattern.BackColor = System.Drawing.SystemColors.Info;
            _negativePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _negativePattern.Cursor = System.Windows.Forms.Cursors.Hand;
            _negativePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_negativePattern, "_negativePattern");
            _negativePattern.Name = "_negativePattern";
            // 
            // groupPerMille
            // 
            _groupPerMille.BackColor = System.Drawing.SystemColors.Control;
            _groupPerMille.Controls.Add(_labelPerMille);
            _groupPerMille.Controls.Add(_perMille);
            _groupPerMille.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupPerMille, "_groupPerMille");
            _groupPerMille.Name = "_groupPerMille";
            _groupPerMille.TabStop = false;
            // 
            // labelPerMille
            // 
            _labelPerMille.Cursor = System.Windows.Forms.Cursors.Hand;
            _labelPerMille.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelPerMille, "_labelPerMille");
            _labelPerMille.Name = "_labelPerMille";
            // 
            // PerMille
            // 
            _perMille.BackColor = System.Drawing.SystemColors.Info;
            _perMille.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _perMille.Cursor = System.Windows.Forms.Cursors.Hand;
            _perMille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_perMille, "_perMille");
            _perMille.Name = "_perMille";
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
            // buttonClose
            // 
            resources.ApplyResources(_buttonClose, "_buttonClose");
            _buttonClose.Name = "_buttonClose";
            _buttonClose.Click += new System.EventHandler(buttonClose_Click);
            // 
            // PositivePattern
            // 
            _positivePattern.BackColor = System.Drawing.SystemColors.Info;
            _positivePattern.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _positivePattern.Cursor = System.Windows.Forms.Cursors.Hand;
            _positivePattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_positivePattern, "_positivePattern");
            _positivePattern.Name = "_positivePattern";
            // 
            // GroupSizes
            // 
            _groupSizes.BackColor = System.Drawing.SystemColors.Info;
            _groupSizes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _groupSizes.Cursor = System.Windows.Forms.Cursors.Hand;
            _groupSizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_groupSizes, "_groupSizes");
            _groupSizes.Name = "_groupSizes";
            // 
            // labelNegativePattern
            // 
            _labelNegativePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelNegativePattern, "_labelNegativePattern");
            _labelNegativePattern.Name = "_labelNegativePattern";
            // 
            // DecimalDigits
            // 
            _decimalDigits.BackColor = System.Drawing.SystemColors.Info;
            _decimalDigits.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _decimalDigits.Cursor = System.Windows.Forms.Cursors.Hand;
            _decimalDigits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_decimalDigits, "_decimalDigits");
            _decimalDigits.Name = "_decimalDigits";
            // 
            // GroupSeparator
            // 
            _groupSeparator.BackColor = System.Drawing.SystemColors.Info;
            _groupSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _groupSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
            _groupSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_groupSeparator, "_groupSeparator");
            _groupSeparator.Name = "_groupSeparator";
            // 
            // Symbol
            // 
            _symbol.BackColor = System.Drawing.SystemColors.Info;
            _symbol.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _symbol.Cursor = System.Windows.Forms.Cursors.Hand;
            _symbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_symbol, "_symbol");
            _symbol.Name = "_symbol";
            // 
            // DecimalSeparator
            // 
            _decimalSeparator.BackColor = System.Drawing.SystemColors.Info;
            _decimalSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            _decimalSeparator.Cursor = System.Windows.Forms.Cursors.Hand;
            _decimalSeparator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(_decimalSeparator, "_decimalSeparator");
            _decimalSeparator.Name = "_decimalSeparator";
            // 
            // labelSymbol
            // 
            _labelSymbol.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelSymbol, "_labelSymbol");
            _labelSymbol.Name = "_labelSymbol";
            // 
            // labelGroupSizes
            // 
            _labelGroupSizes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelGroupSizes, "_labelGroupSizes");
            _labelGroupSizes.Name = "_labelGroupSizes";
            // 
            // groupPercent
            // 
            _groupPercent.BackColor = System.Drawing.SystemColors.Control;
            _groupPercent.Controls.Add(_negativePattern);
            _groupPercent.Controls.Add(_positivePattern);
            _groupPercent.Controls.Add(_groupSeparator);
            _groupPercent.Controls.Add(_groupSizes);
            _groupPercent.Controls.Add(_decimalSeparator);
            _groupPercent.Controls.Add(_decimalDigits);
            _groupPercent.Controls.Add(_symbol);
            _groupPercent.Controls.Add(_labelPositivePattern);
            _groupPercent.Controls.Add(_labelNegativePattern);
            _groupPercent.Controls.Add(_labelGroupSeparator);
            _groupPercent.Controls.Add(_labelGroupSizes);
            _groupPercent.Controls.Add(_labelDecimalSeparator);
            _groupPercent.Controls.Add(_labelDecimalDigits);
            _groupPercent.Controls.Add(_labelSymbol);
            _groupPercent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_groupPercent, "_groupPercent");
            _groupPercent.Name = "_groupPercent";
            _groupPercent.TabStop = false;
            // 
            // labelPositivePattern
            // 
            _labelPositivePattern.FlatStyle = System.Windows.Forms.FlatStyle.System;
            resources.ApplyResources(_labelPositivePattern, "_labelPositivePattern");
            _labelPositivePattern.Name = "_labelPositivePattern";
            // 
            // PercentFormatForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(_groupPerMille);
            Controls.Add(_buttonClose);
            Controls.Add(_groupPercent);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PercentFormatForm";
            ShowInTaskbar = false;
            Closing += new System.ComponentModel.CancelEventHandler(OnClosing);
            _groupPerMille.ResumeLayout(false);
            _groupPercent.ResumeLayout(false);
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
            _symbol.BackColor = color;
            _decimalDigits.BackColor = color;
            _decimalSeparator.BackColor = color;
            _groupSeparator.BackColor = color;
            _positivePattern.BackColor = color;
            _negativePattern.BackColor = color;
            _perMille.BackColor = color;
            _groupSizes.BackColor = color;
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