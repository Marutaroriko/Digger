using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digger
{
    //Напишите здесь классы Player, Terrain и другие.
    public class Terrain : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            return new CreatureCommand() { DeltaX = 0, DeltaY = 0, TransformTo = null};
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            if (conflictedObject is Player)
                return true;
            else
                return false;
        }

        public string GetImageFileName()
        {
            return "Terrain.png";
        }

        public int GetDrawingPriority()
        {
            return 1;
        }
    }

    public class Player : ICreature
    {
        public CreatureCommand Act(int x, int y)
        {
            if (Game.KeyPressed == System.Windows.Forms.Keys.Up)
                return new CreatureCommand() { DeltaX = 0, DeltaY = -1, TransformTo = null };
            else if (Game.KeyPressed == System.Windows.Forms.Keys.Right)
                return new CreatureCommand() {DeltaX = 1, DeltaY = 0, TransformTo = null };
            else if (Game.KeyPressed == System.Windows.Forms.Keys.Down)
                return new CreatureCommand() { DeltaX = 0, DeltaY = 1, TransformTo = null };
            else if (Game.KeyPressed == System.Windows.Forms.Keys.Left)
                return new CreatureCommand() { DeltaX = -1, DeltaY = 0, TransformTo = null };
            else
                return new CreatureCommand() { DeltaX = 0, DeltaY = 0, TransformTo = null };
        }

        public string GetImageFileName()
        {
            return "Digger.png";
        }

        public bool DeadInConflict(ICreature conflictedObject)
        {
            return true;
        }

        public int GetDrawingPriority()
        {
            return 0;
        }
    }

   
}
