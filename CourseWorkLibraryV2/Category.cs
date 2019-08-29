using System;
using System.Collections.Generic;
using System.Linq;
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
        public void toString()
        {
            string aDesc;

            aDesc = "Class Assigment has 3 Member Variables" +
                "name, description & categoryName that are all strings";

            Console.WriteLine(aDesc);
        }

        #endregion
    }
}

