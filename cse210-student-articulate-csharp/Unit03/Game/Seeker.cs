using System;


namespace Unit03.Game
{
    public class Seeker {
        private int location;
        public Seeker() {
            location = 0;
        }

        public int GetLocation() {
            return location;
        }

        public void MoveLocation(int location) {
            this.location = location;
        }
    }
}