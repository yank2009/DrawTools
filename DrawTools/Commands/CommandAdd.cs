using DrawTools.DrawObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace DrawTools.Commands
{
    /// <summary>
    /// Add new object command
    /// </summary>
    public class CommandAdd : Command
    {
        DrawObject drawObject;

        // Create this command with DrawObject instance added to the list
        public CommandAdd(DrawObject drawObject) : base()
        {
            // Keep copy of added object
            this.drawObject = drawObject.Clone();
        }

        public override void Undo(GraphicsList list)
        {
            list.DeleteLastAddedObject();
        }

        public override void Redo(GraphicsList list)
        {
            list.UnselectAll();
            list.Add(drawObject);
        }
    }
}
