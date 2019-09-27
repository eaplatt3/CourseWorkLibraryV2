using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

//////////////////////////////////////////////////////////////
// File: Category.cs                                        //
//                                                          //
// Purpose: Contains the class definitions for Category     //
//                                                          //
// Written By: Earl Platt III                               //
//                                                          //
// Compiler: Visual Studio 2019                             //
//                                                          //
//////////////////////////////////////////////////////////////

namespace CourseWorkLibraryV2
{
    //First Class Category takes name and percent variables
    [DataContract]
    public class Category
    {
        #region Private Member Variables
        //Member Variables
        private string name;
        private double percentage;
        #endregion

        //Constructor
        public Category()
        {

        }

        #region C# Properties
        //Using C# Properties with string
        [DataMember(Name = "name")]
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        //Using C# Properties with double 
        [DataMember(Name = "percentage")]
        public double Percentage
        {
            get
            {
                return percentage;
            }

            set
            {
                percentage = value;
            }
        }

        #endregion

        #region Methods
        //********************************************
        // Method: Overrided ToString
        //
        // Purpose: To return Name & Percentage.
        //********************************************
        public override string ToString()
        {
            return Name.ToString() + "," + Name + "," + Percentage;
        }

        #endregion
    }
}

