using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пример_1
{
    class Program
    {
        class Counter
        {
            public event EventHandler ThresholdReached;
            public virtual void OnThresholdReached(EventArgs e)
            {
                EventHandler handler = ThresholdReached; 
                handler?.Invoke(this, e);
            }
        }
        public class ThresholdReachedEventArgs : EventArgs 
        { 
            public int Threshold { get; set; } 
            public DateTime TimeReached { get; set; } 
        }
        static void c_ThresholdReached(object sender, EventArgs e)
        {
            Console.WriteLine("The threshold was reached.");
        }
        static void Main()
        {
            var c = new Counter();
            c.ThresholdReached += c_ThresholdReached;
            c.OnThresholdReached(new ThresholdReachedEventArgs());
            Console.ReadKey(true);
        }
        
    }
}
