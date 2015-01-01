using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorWeightControlApp
{
    class Weight
    {
        private double maximumWeightCapasity ;
        private double currentWeight;
        private double remainWeight;

       
        public double MaximumWeightCapasity
        {
            get
            {
                return maximumWeightCapasity;
            }
            set
            {
                maximumWeightCapasity = value;
                remainWeight = value;
            }
        }

        public double RemainWeight
        {
            get
            {
                return remainWeight;
            }
            set
            {
                
                remainWeight = value;
            }
        }
       
       
        public double CurrentWeight
        {
            get
            {
                return currentWeight;
            }
            set
            {
                if ((currentWeight+value)<=maximumWeightCapasity)
                {
                    currentWeight += value;  
                }
                else
                {
                    MessageBox.Show("sorry. weight is over.");
                }
               
            }
        }
    }
}
