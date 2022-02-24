using DrawTools.DrawObjects;
using System;
using System.Windows.Forms;

namespace DrawTools.Tools
{
    /// <summary>
    /// Triangle tool
    /// </summary>
    class ToolTriangle : ToolRectangle
    {
        public ToolTriangle()
        {
            var type = typeof(DrawArea);
            Cursor = new Cursor(type, "Cursors.Triangle.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new DrawTriangle(e.X, e.Y, 1, 1));
        }
    }
}
