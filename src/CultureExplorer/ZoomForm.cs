using System.Drawing;
using System.Windows.Forms;

namespace CultureExplorer
{
    public partial class ZoomForm : Form
    {
        public ZoomForm(Control parentControl, string text)
        {
            InitializeComponent();
            BackColor = parentControl.BackColor;
            ForeColor = parentControl.ForeColor;
            ZoomText.Text = text;
            ZoomText.RightToLeft = null == parentControl ? RightToLeft.No : parentControl.RightToLeft;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            // paint 1 pixel width border around the control
            e.Graphics.DrawRectangle(SystemPens.ActiveBorder, new Rectangle(ClientRectangle.X, ClientRectangle.Y, ClientRectangle.Width - 1, ClientRectangle.Height - 1));
        }
    }
}