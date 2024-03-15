//Name: Varsan Jeyakkumar
//Date: 2024-03-26
//Title: Date Gap
//Purpose: Determine the distance between two days
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q6DateGapVarsanJ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            string strUser; //struser string
            int intFirstYear, intFirstMonth = 0, intFirstDay; //first day
            int intSecondYear, intSecondMonth = 0, intSecondDay; //second day
            string strFirstMonth, strSecondMonth; //month string for input
            int intFirstDate = 0, intSecondDate = 0; //overall two dates
            int intDifferenceDays = 0, intDifferenceMonths = 0, intDifferenceYears = 0, intDifferenceTotal = 0; //output
            bool isSameDay = false; //If same day
    
            int intBeforeDay = 0, intBeforeMonth = 0, intBeforeYear = 0, intAfterDay = 0, intAfterMonth = 0, intAfterYear = 0;
            int intAfterDayOne = 0;

            int intNumberLeaps = 0, intLeapBottom = 0, intLeapTop = 0; //for leap year calculation

            //Input
            Console.WriteLine("This program will let you know about the difference in days between two dates\n"); //input instructions

            Console.WriteLine("What is the year of the FIRST DATE (integr, eg. 2023)"); //first date yr
            strUser = Console.ReadLine(); //read line
            intFirstYear = Int32.Parse(strUser); //convert yr to int

            Console.WriteLine("What is the month of the FIRST DATE (word, eg. September)"); //first date month
            strUser = Console.ReadLine(); //read line
            strFirstMonth = strUser;

            Console.WriteLine("What is the day of the FIRST DATE (integer, eg. 4)"); //first date day
            strUser = Console.ReadLine(); //read line
            intFirstDay = Int32.Parse(strUser); //convert yr to int


            Console.WriteLine("What is the year of the SECOND DATE (integer, eg. 2024)"); //first date yr
            strUser = Console.ReadLine(); //read line
            intSecondYear = Int32.Parse(strUser); //convert yr to int

            Console.WriteLine("What is the month of the SECOND DATE (word, eg. March)"); //first date month
            strUser = Console.ReadLine(); //read line
            strSecondMonth = strUser;

            Console.WriteLine("What is the day of the SECOND DATE (integer, eg. 05)"); //first date day
            strUser = Console.ReadLine(); //read line
            intSecondDay = Int32.Parse(strUser); //convert yr to int

            //Process
            //first month
            if (strFirstMonth == "January") //jan
            {
                intFirstMonth = 1;
            }
            else if (strFirstMonth == "February") //feb
            {
                intFirstMonth = 2;
            }
            else if (strFirstMonth == "March") //march
            {
                intFirstMonth = 3;
            }
            else if (strFirstMonth == "April") //april
            {
                intFirstMonth = 4;
            }
            else if (strFirstMonth == "May") //may
            {
                intFirstMonth = 5;
            }
            else if (strFirstMonth == "June") //june
            {
                intFirstMonth = 6;
            }
            else if (strFirstMonth == "July") //july
            {
                intFirstMonth = 7;
            }
            else if (strFirstMonth == "August") //august
            {
                intFirstMonth = 8;
            }
            else if (strFirstMonth == "September") //sept
            {
                intFirstMonth = 9;
            }
            else if (strFirstMonth == "October") //oct
            {
                intFirstMonth = 10;
            }
            else if (strFirstMonth == "November") //nov
            {
                intFirstMonth = 11;
            }
            else if (strFirstMonth == "December") //dec
            {
                intFirstMonth = 12;
            }

            //second month
            if (strSecondMonth == "January") //jan
            {
                intFirstMonth = 1;
            }
            else if (strSecondMonth == "February") //feb
            {
                intSecondMonth = 2;
            }
            else if (strSecondMonth == "March") //march
            {
                intSecondMonth = 3;
            }
            else if (strSecondMonth == "April") //april
            {
                intSecondMonth = 4;
            }
            else if (strSecondMonth == "May") //may
            {
                intSecondMonth = 5;
            }
            else if (strSecondMonth == "June") //june
            {
                intSecondMonth = 6;
            }
            else if (strSecondMonth == "July") //july
            {
                intSecondMonth = 7;
            }
            else if (strSecondMonth == "August") //august
            {
                intSecondMonth = 8;
            }
            else if (strSecondMonth == "September") //sept
            {
                intSecondMonth = 9;
            }
            else if (strSecondMonth == "October") //oct
            {
                intSecondMonth = 10;
            }
            else if (strSecondMonth == "November") //nov
            {
                intSecondMonth = 11;
            }
            else if (strSecondMonth == "December") //dec
            {
                intSecondMonth = 12;
            }

            //date comparator
            if (intFirstYear > intSecondYear) //compare yr
            {
                intAfterYear = intFirstYear;
                intAfterMonth = intFirstMonth;
                intAfterDay = intFirstDay;

                intBeforeDay = intSecondDay;
                intBeforeMonth = intSecondMonth;
                intBeforeYear = intSecondYear;
            }
            else if (intFirstYear < intSecondYear) //compare yr
            {
                intBeforeYear = intFirstYear;
                intBeforeMonth = intFirstMonth;
                intBeforeDay = intFirstDay;

                intAfterDay = intSecondDay;
                intAfterMonth = intSecondMonth;
                intAfterYear = intSecondYear;
            }
            else
            {
                if (intFirstMonth > intSecondMonth) //compare month
                {
                    intAfterYear = intFirstYear;
                    intAfterMonth = intFirstMonth;
                    intAfterDay = intFirstDay;

                    intBeforeDay = intSecondDay;
                    intBeforeMonth = intSecondMonth;
                    intBeforeYear = intSecondYear;
                }

                else if (intFirstMonth < intSecondMonth) //compare month
                {
                    intBeforeYear = intFirstYear;
                    intBeforeMonth = intFirstMonth;
                    intBeforeDay = intFirstDay;

                    intAfterDay = intSecondDay;
                    intAfterMonth = intSecondMonth;
                    intAfterYear = intSecondYear;
                }

                else
                {
                    if (intFirstDay > intSecondDay) //compare day
                    {
                        intAfterYear = intFirstYear;
                        intAfterMonth = intFirstMonth;
                        intAfterDay = intFirstDay;

                        intBeforeDay = intSecondDay;
                        intBeforeMonth = intSecondMonth;
                        intBeforeYear = intSecondYear;
                    }

                    else if (intFirstDay < intSecondDay)  //compare day
                    {
                        intBeforeYear = intFirstYear;
                        intBeforeMonth = intFirstMonth;
                        intBeforeDay = intFirstDay;

                        intAfterDay = intSecondDay;
                        intAfterMonth = intSecondMonth;
                        intAfterYear = intSecondYear;
                    }

                    else //same day
                    {
                        isSameDay = true;
                    }
                }
            }

            if (isSameDay == true) //same date (no difference)
            {
                isSameDay = true;
            }
            else //proceed with operation
            {
                isSameDay = false;
                //special  cases
                if ((intBeforeYear==intAfterYear) && (intAfterMonth==intBeforeMonth)) //same month and year
                {
                    intDifferenceDays = intAfterDay - intBeforeDay;
                    intDifferenceTotal = intDifferenceDays;
                }
                else //normal cases
                {
                    //before month
                    if (intBeforeMonth == 1)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365);
                    }
                    else if (intBeforeMonth == 2)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 31; //running total starts to consider previous month
                    }
                    else if (intBeforeMonth == 3)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 59;
                    }
                    else if (intBeforeMonth == 4)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 90;
                    }
                    else if (intBeforeMonth == 5)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 120;
                    }
                    else if (intBeforeMonth == 6)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 151;
                    }
                    else if (intBeforeMonth == 7)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 181;
                    }
                    else if (intBeforeMonth == 8)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 212;
                    }
                    else if (intBeforeMonth == 9)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 243;
                    }
                    else if (intBeforeMonth == 10)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 273;
                    }
                    else if (intBeforeMonth == 11)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 304;
                    }
                    else if (intBeforeMonth == 12)
                    {
                        intFirstDate = (intBeforeDay) + (intBeforeYear * 365) + 334;
                    }

                    //leap year considerating before
                    if (((intBeforeMonth == 2) || (intBeforeMonth == 1))&&(intBeforeYear==0))
                    {
                        intLeapBottom = 0;
                    }
                    else if (((intBeforeMonth == 2)||(intBeforeMonth == 1))&&(intBeforeYear!=0))
                    {
                        intLeapBottom = ((intBeforeYear - 1) / 4) + 1;
                    }
                    else
                    {
                        intLeapBottom = ((intBeforeYear + 1) / 4) + 1;  
                    }
                    intFirstDate += intLeapBottom; //adds leap year
                    
                    //after month
                    if (intAfterMonth == 1)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365);
                    }
                    else if (intAfterMonth == 2)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 31; //running total starts to consider previous month
                    }
                    else if (intAfterMonth == 3)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 59;
                    }
                    else if (intAfterMonth == 4)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 90;
                    }
                    else if (intAfterMonth == 5)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 120;
                    }
                    else if (intAfterMonth == 6)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 151;
                    }
                    else if (intAfterMonth == 7)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 181;
                    }
                    else if (intAfterMonth == 8)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 212;
                    }
                    else if (intAfterMonth == 9)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 243;
                    }
                    else if (intAfterMonth == 10)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 273;
                    }
                    else if (intAfterMonth == 11)
                    {
                        intSecondDate = (intAfterDay) + (intAfterYear * 365) + 304;
                    }
                    else if (intAfterMonth == 12)
                    {
                        intSecondDate = (intBeforeDay) + (intAfterYear * 365) + 334;
                    }

                    //leap year considerating after
                    if (((intAfterMonth == 2) || (intAfterMonth == 1)) && (intAfterYear == 0))
                    {
                        intLeapTop = 0;
                    }
                    else if (((intAfterMonth == 2) || (intAfterMonth == 1)) && (intAfterYear != 0))
                    {
                        intLeapTop = ((intAfterYear - 1) / 4) + 1;
                    }
                    else
                    {
                        intLeapTop = ((intAfterYear + 1) / 4) + 1;
                    }
                    intSecondDate += intLeapTop; //adds leap year
                    
                    //Difference
                    intDifferenceTotal = intSecondDate - intFirstDate; //calculate difference total.
                }
            }

            //Output
            if (isSameDay == true)
            {
                Console.WriteLine("Both days are same, so there is no difference in days. (0 days)");
            }
            else
            {
                Console.WriteLine("The difference of days is " + intDifferenceTotal + " days."); //state diff days
            }

            Console.ReadKey();//wait for user to terminate program
        }
    }
}
