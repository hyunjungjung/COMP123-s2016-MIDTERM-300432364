using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author : Joanne Jung
 * Student # : 300432364
 * Date : June 24th, 2016
 * Description : Lotto649 Class for Midterm s2016
 * Version : 0.0.1 : Initial commit with class diagram
 */ 
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

        public void GenerateLottoNumbers()
        {
            throw new System.NotImplementedException();
        }

        // CREATE the public GenerateLottoNumbers method here ----------------
    }
}
