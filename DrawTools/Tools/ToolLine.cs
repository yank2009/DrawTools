using System;
using System.Windows.Forms;
using System.Drawing;
using DrawTools.DrawObjects;

namespace DrawTools.Tools
{
	/// <summary>
	/// Line tool
	/// </summary>
	class ToolLine : ToolObject
	{
        public ToolLine()
        {
            var type = typeof(DrawArea);
            Cursor = new Cursor(type, "Cursors.Line.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new DrawLine(e.X, e.Y, e.X + 1, e.Y + 1));
        }

        public override void OnMouseMove(DrawArea drawArea, MouseEventArgs e)
        {
            drawArea.Cursor = Cursor;

            if ( e.Button == MouseButtons.Left )
            {
                Point point = new Point(e.X, e.Y);
                drawArea.GraphicsList[0].MoveHandleTo(point, 2);
                drawArea.Refresh();
            }
        }
    }
}
