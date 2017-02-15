using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CultureExplorer.Properties;

namespace CultureExplorer
{
    public class CultureExplorerListView : ListView
    {
        private string _copyString;
        private ZoomForm _zoomForm;

        public CultureExplorerListView()
        {
            Cursor = Cursors.Hand;
            _zoomForm = null;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            var item = GetItemAt(e.X, e.Y);
            if (null != item)
            {
                var itemString = GetItemStringList(item);

                if (MouseButtons.Left == e.Button)
                {
                    _zoomForm = new ZoomForm(this, itemString);
                    _zoomForm.Show(this);
                    _zoomForm.Location = ComputeZoomLocation(_zoomForm.Size, item.Bounds);
                }
                else if (MouseButtons.Right == e.Button)
                {
                    _copyString = itemString;
                    var menuStrip = new ContextMenuStrip();
                    menuStrip.Items.Add(Resources.CopyMenu, null, OnCopyMenuClick);
                    ContextMenuStrip = menuStrip;
                }
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
            Clipboard.SetText(_copyString);
        }

        private Point ComputeZoomLocation(Size zoomSize, Rectangle itemBounds)
        {
            var basePoint = Parent.PointToScreen(new Point(itemBounds.X, itemBounds.Y));
            var widthAdjustment = (zoomSize.Width - Width) / 2;
            var heightAdjustment = (zoomSize.Height - Height) / 2;
            var adjustedPoint = new Point(basePoint.X - widthAdjustment, basePoint.Y - heightAdjustment);

            // TODO: make sure this stays within screen bounds (if possible)
            return adjustedPoint;
        }

        private string GetItemStringList(ListViewItem item)
        {
            var sb = new StringBuilder(item.Text);
            for (var i = 1; i < item.SubItems.Count; i++)
            {
                sb.Append(" | ");
                sb.Append(item.SubItems[i].Text);
            }

            return sb.ToString();
        }
    }
}