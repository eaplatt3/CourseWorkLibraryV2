using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//////////////////////////////////////////////////////////////
// File: Assignment.cs                                      //
//                                                          //
// Purpose: Contains the class definitions for Assignment   //
//                                                          //
// Written By: Earl Platt III                               //
//                                                          //
// Compiler: Visual Studio 2019                             //
//                                                          //
//////////////////////////////////////////////////////////////

namespace CourseWorkLibraryV2
{
    public class Assignment
    {
        #region Member Variables 
        //Member Variables 
        private string name;
        private string description;
        private string categoryName;
        #endregion

        //Constructor
        public Assignment()
        {

        }

        #region C# Properties
        //Get & Set using C# properties 
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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }

        }

        public string CategoryName
        {
            get
            {
                return categoryName;
            }

            set
            {
                categoryName = value;
            }
        }
        #endregion

        #region Methods
        //*****************************************************
        // Method: Overrided ToString
        //
        // Purpose: To return Name, Description & Percentage.
        //*****************************************************
        public override string ToString()
        {
            return Name.ToString() + "," + Name + "," + Description + "," + CategoryName;
        }
        #endregion
    }
}
