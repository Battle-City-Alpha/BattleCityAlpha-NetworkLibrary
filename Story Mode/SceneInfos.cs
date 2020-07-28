using BCA.Story_Mode.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCA.Story_Mode
{
    public class SceneInfo
    {
        public int ID { get; private set; }
        public SceneState State { get; private set; }

        public SceneInfo(int id, SceneState state)
        {
            ID = id;
            State = state;
        }
    }
}
