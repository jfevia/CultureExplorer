using System;
using System.Drawing;
using System.Windows.Forms;
using CultureExplorer.Properties;

namespace CultureExplorer
{
    public class CultureExplorerLabel : Label
    {
        private ZoomForm _zoomForm;

        public CultureExplorerLabel()
        {
            Cursor = Cursors.Hand;
            _zoomForm = null;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (MouseButtons.Left == e.Button)
            {
                try
                {
                    _zoomForm = new ZoomForm(this, Text);
                    _zoomForm.Show(this);
                    _zoomForm.Location = ComputeZoomLocation(_zoomForm.Size);
                }
                catch
                {
                    _zoomForm = null;
                }
            }
            else if (MouseButtons.Right == e.Button)
            {
                var menuStrip = new ContextMenuStrip();
                menuStrip.Items.Add(Resources.CopyMenu, null, OnCopyMenuClick);
                ContextMenuStrip = menuStrip;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (null != _zoomForm)
            {
                _zoomForm.Close();
                _zoomForm = null;
            }
        }

        private void OnCopyMenuClick(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(Text);
        }

        private Point ComputeZoomLocation(Size zoomSize)
        {
            var basePoint = Parent.PointToScreen(Location);
            var widthAdjustment = (zoomSize.Width - Width) / 2;
            var heightAdjustment = (zoomSize.Height - Height) / 2;
            var adjustedPoint = new Point(basePoint.X - widthAdjustment, basePoint.Y - heightAdjustment);

            // TODO: make sure this stays within screen bounds (if possible)
            return adjustedPoint;
        }
    }
}