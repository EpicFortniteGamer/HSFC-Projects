using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneArmedBandits
{
    public class WheelOfFruit
    {
        static Random rand = new Random(); //Generates random

        public enum People { will_smith, xxx, kirby, kante, black_kid, mrs_obama, obama, steve_harvey, bill_cosby, morgan_freeman}

        private People[] theWheel = new People[10];

        const int viewPos = 5;

        public WheelOfFruit()
        {
            for (int i=0; 1<theWheel.Length; i++)
            {
                theWheel[i] = (People)i;
            }

            this.shuffle();
        }

        private void shuffle()
        {
            int first, second;

            People temp;

            for(first = 0; first < theWheel.Length; first++)
            {
                second = rand.Next(0, theWheel.Length);

                temp = theWheel[first];
                theWheel[first] = theWheel[second];
                theWheel[second] = temp;
            }
        }
        public void spin(int num)
        {

            People front; 

            for (int notch = 0; notch < num; notch++)
            {
                front = theWheel[0];
                for (int i = 0; i < theWheel.Length-1; i++)
                {
                    theWheel[i] = theWheel[i + 1];
                }
                theWheel[theWheel.Length - 1] = front;
            }
        }
        
        public People getCurrentPerson()
        {
            return theWheel[viewPos];
        }
    }
}
