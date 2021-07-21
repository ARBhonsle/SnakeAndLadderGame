using System;
using System.Collections.Generic;
using System.Text;

namespace snakeAndLadderGame
{
    interface ISnakeAndLadder
    {
        public abstract void ShowPosition();
        public abstract void DiceValue();
        public abstract void PlayOption();
        public abstract void Play();
        public abstract void PlayExact();
    }
}
