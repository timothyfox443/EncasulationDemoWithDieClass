using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncasulationDemoWithDieClass
{
    /// <summary>
    /// this will represent a single multi-sided die
    /// at this time
    /// </summary>
    class Die
    {
        static Random rand;
        byte minValue;
        byte maxValue;
  //shared across all instances of the class
        static Die()
        {
            rand = new Random();
        }
        public Die() : this(1,6)
        {
            //minValue = 1;
            //maxValue = 6;
            //Roll(); //this prevents an illegal value being stored in a die
        }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="minValue">the inclusive lower value</param>
    /// <param name="maxValue">the exclusive upper value needs +1 more than highest value desired</param>
    public Die(byte minValue, byte maxValue)
        {
            this.minValue = minValue;
            this.maxValue = maxValue;
            Roll();
        }
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        //roll method here
        /// <summary>
        /// rolls a six sided die and returns the value
        /// </summary>
        public byte Roll()
        {
            if (!IsHeld) // if this die is not held do this
            {
                Value = (byte)rand.Next(minValue,maxValue);
            }
            return Value;
        }
    }
}
