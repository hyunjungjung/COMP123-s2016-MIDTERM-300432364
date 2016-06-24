using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Author : Joanne Jung
 * Student # : 300432364
 * Date : June 24th, 2016
 * Description : LottoGame class for midterm
 * Version : 0.0.4 : Final commit
 */ 
namespace COMP123_MidTermExam
{
    /**
     * <summary>
     * This abstract class is a blueprint for all Lotto Games
     * </summary>
     * 
     * @class LottoGame
     * @property {int} ElementNum;
     * @property {int} SetSize;
     */
    public abstract class LottoGame
    {

        // PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private List<int> _elementList;
        private int _elementNumber;
        private List<int> _numberList;
        private Random _random;
        private int _setSize;
        // CREATE private fields here --------------------------------------------

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public List<int> ElementList
        {
            get
            {
                return this._elementList;
            }
        }

        public int ElementNumber
        {
            get
            {
                return this._elementNumber;
            }
            set
            {
                this._elementNumber = value;
            }
        }

        public List<int> NumberList
        {
            get
            {
                return this._numberList;
            }

        }

        public Random random
        {
            get
            {
                return this._random;
            }
        }

        public int SetSize
        {
            get
            {
                return this._setSize;
            }
            set
            {
                this._setSize = value;
            }
        }
        // CREATE public properties here -----------------------------------------

        // CONSTRUCTORS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This constructor takes two parameters: elementNumber and setSize
         * The elementNumber parameter has a default value of 6
         * The setSize parameter has a default value of 49
         * </summary>
         * 
         * @constructor LottoGame
         * @param {int} elementNumber
         * @param {int} setSize
         */
        public LottoGame(int elementNumber = 6, int setSize = 49)
        {
            // assign elementNumber local variable to the ElementNumber property
            this.ElementNumber = elementNumber;

            // assign setSize local variable tot he SetSize property
            this.SetSize = setSize;

            // call the _initialize method
            this._initialize();

            // call the _build method
            this._build();
        }

        // PRIVATE METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _build()
        {


            int[] SetSize = new int[49];
            int randomIndex = this.random.Next(0, NumberList.Count);
            ElementList.Add(NumberList[randomIndex]);

            for (int index = 0; index < ElementNumber; index++)
            {
                int Number = random.Next(1, 50);
                SetSize[Number]++;
                NumberList.Add(Number);
            }
        }

        // CREATE the private _initialize method here -----------------------------
        private void _initialize()
        {
            List<int> _numberList = new List<int>();
            List<int> _elementList = new List<int>();
            Random random = new Random();

        }
        // CREATE the private _build method here -----------------------------------
        public void PickElements() 
        {
          
        }

        // OVERRIDEN METHODS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * Override the default ToString function so that it displays the current
         * ElementList
         * </summary>
         * 
         * @override
         * @method ToString
         * @returns {string}
         */
        public override string ToString()
        {
            // create a string variable named lottoNumberString and intialize it with the empty string
            string lottoNumberString = String.Empty;

            // for each lottoNumber in ElementList, loop...
            foreach (int lottoNumber in ElementList)
            {
                // add lottoNumber and appropriate spaces to the lottoNumberString variable
                lottoNumberString += lottoNumber > 9 ? (lottoNumber + " ") : (lottoNumber + "  ");
            }

            return lottoNumberString;
        }

      

        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        // CREATE the public PickElements method here ----------------------------
    }
}
