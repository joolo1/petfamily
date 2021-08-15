using System;
using System.Collections.Generic;
using System.Text;

namespace JoppesDjurfamilj
{
    class Ball : PetOwner
    {
        private string colour;
        private int quality;

        public Ball(string colour = "red")
        {
            
        }

        public void LowerQuality(int tal)
        {
            quality -= tal;
        }
    }
}
