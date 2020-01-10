using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public abstract class Game
    {
        public abstract void initialized();
        public abstract void startPlay();
        public abstract void endPlay();

        public void play()
        {
            this.initialized();
            this.startPlay();
            this.endPlay();
        }

    }
}
