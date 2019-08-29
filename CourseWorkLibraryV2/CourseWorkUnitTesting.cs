using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/////////////////////////////////////////////////////////////////////////
// File: CourseWorkUnitTesting.cs                                      //
//                                                                     //
// Purpose: Contains the class definitions for CourseWorkUnitTesting   //
//                                                                     //
// Written By: Earl Platt III                                          //
//                                                                     //
// Compiler: Visual Studio 2019                                        //
//                                                                     //
/////////////////////////////////////////////////////////////////////////

namespace CourseWorkLibraryV2
{
    //Class Created for testing
    public class CourseWorkUnitTesting
    {
        #region Methods
        public void UnitTestCategory()
        {
            string result;         

            Category c = new Category();

            c.Name = "Billy";
            c.Percentage = 100;

            if(c.Name != "Billy")
            {
                result = "Fail";
            }

            if (c.Percentage != 100)
            {
                result = "Fail";
            }
            else
                result = "Pass";
        }

        public void UnitTestAssignment()
        {
            //TO DO: declare instance of assigment
            //       perform testing on the properties
            //       print pass/fail message
        }
        #endregion
    }
}
