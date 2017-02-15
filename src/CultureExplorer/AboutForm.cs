using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using CultureExplorer.Properties;

namespace CultureExplorer
{
    /// <summary>
    ///     Summary description for AboutForm.
    /// </summary>
    public class AboutForm : Form
    {
        /// <summary>
        ///     Required designer variable.
        /// </summary>
        private readonly Container _components = null;

        private Button _buttonOk;

        private Label _labelCopyright;
        private Label _labelDesign;
        private Label _labelTitle;
        private LinkLabel _linkAuthor;

        public AboutForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
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
            var resources = new ComponentResourceManager(typeof(AboutForm));
            _labelTitle = new Label();
            _labelCopyright = new Label();
            _buttonOk = new Button();
            _labelDesign = new Label();
            _linkAuthor = new LinkLabel();
            SuspendLayout();
            // 
            // labelTitle
            // 
            resources.ApplyResources(_labelTitle, "_labelTitle");
            _labelTitle.BackColor = System.Drawing.Color.Transparent;
            _labelTitle.ForeColor = System.Drawing.Color.White;
            _labelTitle.Name = "_labelTitle";
            // 
            // labelCopyright
            // 
            resources.ApplyResources(_labelCopyright, "_labelCopyright");
            _labelCopyright.BackColor = System.Drawing.Color.Transparent;
            _labelCopyright.ForeColor = System.Drawing.Color.White;
            _labelCopyright.Name = "_labelCopyright";
            // 
            // buttonOK
            // 
            resources.ApplyResources(_buttonOk, "_buttonOk");
            _buttonOk.Name = "_buttonOk";
            _buttonOk.Click += new System.EventHandler(buttonOK_Click);
            // 
            // labelDesign
            // 
            resources.ApplyResources(_labelDesign, "_labelDesign");
            _labelDesign.BackColor = System.Drawing.Color.Transparent;
            _labelDesign.ForeColor = System.Drawing.Color.White;
            _labelDesign.Name = "_labelDesign";
            // 
            // linkAuthor
            // 
            resources.ApplyResources(_linkAuthor, "_linkAuthor");
            _linkAuthor.BackColor = System.Drawing.Color.Transparent;
            _linkAuthor.ForeColor = System.Drawing.Color.White;
            _linkAuthor.LinkColor = System.Drawing.Color.Blue;
            _linkAuthor.Name = "_linkAuthor";
            _linkAuthor.TabStop = true;
            _linkAuthor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkAuthor_LinkClicked);
            // 
            // AboutForm
            // 
            resources.ApplyResources(this, "$this");
            Controls.Add(_linkAuthor);
            Controls.Add(_labelDesign);
            Controls.Add(_buttonOk);
            Controls.Add(_labelCopyright);
            Controls.Add(_labelTitle);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            ShowInTaskbar = false;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void linkAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var p = new Process();
            p.StartInfo.FileName = Resources.EmailInfo;
            p.Start();
        }
    }
}