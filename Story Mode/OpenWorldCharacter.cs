using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Story_Mode
{
    public class OpenWorldCharacter
    {
        public int Scene { get; private set; }
        public int Character { get; private set; }

        public OpenWorldCharacter(int scene, int character)
        {
            Scene = scene;
            Character = character;
        }
    }
}
