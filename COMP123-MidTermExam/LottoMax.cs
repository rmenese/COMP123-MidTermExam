//Remedios Meneses
//300691712
//2020-07-17(6:45 PM)
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace COMP123_MidTermExam
{
    /**
    * <summary>
    * This class is a subclass of the LottoGame abstract superclass
    * </summary>
    * 
    * @class LottoMax
    */
    public class LottoMax : LottoGame, IGenerateLottoNumbers
    {
        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public LottoMax()
            : base(7, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {
            //for (int i = 1; i <= ElementNumber; i++)
            //{
            //    PickElements();
            //    Console.WriteLine($"Ticket {i}: {ToString()}");
            //}
            int i = 0;
            while (i < 7)
            {
                PickElements();
                Console.Write($" Ticket {i + 1}: {ToString()}");
                Console.WriteLine();
                i++;
            }

        }
    }
}