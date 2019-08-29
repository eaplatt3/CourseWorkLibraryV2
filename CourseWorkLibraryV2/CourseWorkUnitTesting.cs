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

            Category c = new Category();
            c.Name = "Pass";
            Console.WriteLine(c.Name);
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
