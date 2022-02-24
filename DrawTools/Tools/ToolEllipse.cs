using DrawTools.DrawObjects;
using System;
using System.Windows.Forms;

namespace DrawTools.Tools
{
	/// <summary>
	/// Ellipse tool
	/// </summary>
	class ToolEllipse : ToolRectangle
	{
		public ToolEllipse()
		{
			var type = typeof(DrawArea);
			Cursor = new Cursor(type, "Cursors.Ellipse.cur");
		}

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new DrawEllipse(e.X, e.Y, 1, 1));
        }
	}
}
