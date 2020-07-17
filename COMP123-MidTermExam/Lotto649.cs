﻿//Remedios Meneses
//300691712
//2020-07-17(6:45 PM)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This class is a subclass of the LottoGame abstract superclass
     * </summary>
     * 
     * @class Lotto649
     */
    public class Lotto649 : LottoGame, IGenerateLottoNumbers
    {
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor does not take any parameters but satisfies the
         * base constructor requirements by send the elementNumber and setSize
         * </summary>
         * 
         * @constructor
         */
        public Lotto649()
            : base(6, 49)
        {

        }

        // CREATE the public GenerateLottoNumbers method here ----------------
        public void GenerateLottoNumbers()
        {

            int i = 0;
            while (i < 6)
            {
                PickElements();
                Console.Write($" Ticket {i + 1}: {ToString()}");
                Console.WriteLine();
                i++;
            }
            // for (int i = 1; i <= ElementNumber; i++)
            //{
            //    PickElements();
            //    Console.WriteLine($"Ticket {i}: {ToString()}");
            //}

        }



    }
}