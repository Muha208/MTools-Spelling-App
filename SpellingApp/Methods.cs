using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;

namespace SpellingMethod
{
    public class Methods
    {
        #region Enums
        private enum NumberStat
        {
            FirstNumber,
            SecondNumber,
        }
        /// <summary>
        /// this help the Converts Methods to includ in convert last 2 letter method
        /// According the count of numbers in number
        /// EX: 20 - TowNumbers, 300 -ThreeNumbers,....etc
        /// </summary>
        private enum TypeOfConvert
        {
            TwoNumbers,
            ThreeNumbers,
            FourNumbers,
            FiveNumbers,
            NumberIsTwo,
        }
        #endregion
        #region Helper Methods
        //_______This methods to help other method________//
        /// <summary>
        /// Checking If the All Items in Array is Number Or Not
        /// If it's number then it will return True And List Of int
        /// </summary>
        /// <param name="listNo">Input List Of String</param>
        /// <returns>True And List Of int Or False And List Of Zero</returns>
        private static (bool isNumber, List<int> listToNumbers) IsNumber(List<string> listNo)
        {
            List<int> listToNumbersOld = new List<int>();
            //checking the input list<string> is not null
            if (listNo != null)
            {
                foreach (var Number in listNo)
                {
                    //checking that the all items is number and make new list<int> 
                    if (int.TryParse(Number, out int NewNo))
                    {
                        listToNumbersOld.Add(NewNo);
                    }

                }
                //checking the New list<int> if it's includ numbers or it's Empty
                if (listToNumbersOld.Sum() != 0)
                {
                    return (isNumber: true, listToNumbers: listToNumbersOld);
                }
                else
                {
                    return (isNumber: false, listToNumbers: listToNumbersOld);
                }
            }
            else
            {
                listToNumbersOld.Add(0);
                return (isNumber: false, listToNumbers: listToNumbersOld);
            }
        }
        /// <summary>
        /// Checking the Number If it is includ 1 and zeros only or not EX (100000)
        /// Ith's Useing IsNumber Method To convert the LIst of string to list of int
        /// </summary>
        /// <param name="listNo">Input List Of String</param>
        /// <returns>True Or False</returns>
        private static bool CheckIfItsOneAndZerosOnly(List<string> listNo)
        {
            //convert list<String> to List<int> after checking that the all items is a number
            var listToNumbers = IsNumber(listNo).listToNumbers;
            //Get the first number in the list and checking if it = 1 or not
            int FirstNumber = listToNumbers.First();
            if (FirstNumber == 1)
            {
                //Cheking the rest of numbers that = 0
                for (int i = 1; i < listToNumbers.Count(); i++)
                {
                    if (listToNumbers[i] != 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Removing the first Number and return the rest of other
        /// </summary>
        /// <param name="No">Input Number As int</param>
        /// <returns>the rest of number after removing the first one</returns>
        private static int ReturnNumberAfterSpiltingFirstNumber(int No)
        {
            //convert number to list<String>
            var listOfNumber = ConvertIntNumberToStringList(No);
            //Remove the first item
            listOfNumber.RemoveAt(0);
            var StringNumber = new StringBuilder();
            foreach (var item in listOfNumber)
            {
                StringNumber.Append(item);
            }
            if (int.TryParse(StringNumber.ToString(), out int NewNo))
            {
                return NewNo;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Removing any count of Numbers and return the rest of other
        /// </summary>
        /// <param name="No">Input Number As int</param>
        /// <param name="countOfSplitNumbers">How many numbers that you need to split</param>
        /// <returns>int rest number after spliting</returns>
        private static int ReturnNumberAfterSpiltingFirstCountOfNumbers(int No,int countOfSplitNumbers)
        {
            //convert number to list<String>
            var listOfNumber = ConvertIntNumberToStringList(No);
            //Range of spliting
            listOfNumber.RemoveRange(0, countOfSplitNumbers);
            var StringNumber = new StringBuilder();
            foreach (var item in listOfNumber)
            {
                StringNumber.Append(item);
            }
            if (int.TryParse(StringNumber.ToString(), out int NewNo))
            {
                return NewNo;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Return the first count of numbers 
        /// </summary>
        /// <param name="No">Input Number As int</param>
        /// <param name="countNumberFromFirst">How many numbers that you need to get</param>
        /// <returns>first count of numbers</returns>
        private static int ReturnFirstCountOfNumbers(int No, int countNumberFromFirst)
        {
            //convert number to list<String>
            var listOfNumber = ConvertIntNumberToStringList(No);
            var FirstNumberList = new List<string>();  
            for (int i = 0; i < countNumberFromFirst; i++)
            {
                FirstNumberList.Add(listOfNumber[i]);
            }
            var StringNumber = new StringBuilder();
            foreach (var item in FirstNumberList)
            {
                StringNumber.Append(item);
            }
            if (int.TryParse(StringNumber.ToString(), out int NewNo))
            {
                return NewNo;
            }
            else
            {
                return 0;
            }
        }
        #endregion
        #region Convert Methods
        /// <summary>
        /// Converting int Number to List<string>
        /// </summary>
        /// <param name="Number">Input int Number</param>
        /// <returns> List<string></returns>
        private static List<string> ConvertIntNumberToStringList(int Number)
        {
            //convert the number to string then to array of char
            var CharArray = Number.ToString().ToCharArray();
            var NumberSeparated = new List<string>();
            for (int i = 0; i < CharArray.Length; i++)
            {
                //add every Char into the list<string> as string
                NumberSeparated.Add($"{CharArray[i]}");
            }
            return NumberSeparated;
        }
        private static string ConvertLastTwoLetter(int No, TypeOfConvert typeOfConvert)
        {
            switch (typeOfConvert)
            {
                case TypeOfConvert.TwoNumbers:
                    return ConvertOneNumberToString(No).Replace("ة", "ون");
                case TypeOfConvert.ThreeNumbers:
                    return ConvertOneNumberToString(No).Replace("ة", "مائة");
                case TypeOfConvert.FourNumbers:
                    return ConvertOneNumberToString(No) + " آلاف";
                case TypeOfConvert.FiveNumbers:
                    return SpellingTwoNumbers(No) + " ألفاً";
                case TypeOfConvert.NumberIsTwo:
                    return ConvertOneNumberToString(No).Replace("ين", "ى");
                default:
                    return "";
            }
        }
        private static string ConvertOneAndZeroNumbersToString(int CountOfZero)
        {
            switch (CountOfZero)
            {
                case 1: return "عشرة";
                case 2: return "مائة";
                case 3: return "ألف";
                case 4: return "عشرة الآف";
                case 5: return "مائة ألف";
                case 6: return "مليون";
                case 7: return "عشرة ملايين";
                case 8: return "مائة مليون";
                case 9: return "مليار";
                default:
                    return "";
            }
        }
        private static string ConvertOneNumberToString(int No)
        {
            switch (No)
            {
                case 0: return "صفر";
                case 1: return "واحد";
                case 2: return "إثنين";
                case 3: return "ثلاثة";
                case 4: return "أربعة";
                case 5: return "خمسة";
                case 6: return "ستة";
                case 7: return "سبعة";
                case 8: return "ثمانية";
                case 9: return "تسعة";
                default:
                    return "";
            }
        }
        private static string ConvertTwoNumbersToString(int No, NumberStat numberStat)
        {
            switch (numberStat)
            {
                case NumberStat.FirstNumber:
                    switch (No)
                    {
                        case 1: return "عشر";
                        case 2: return "عشرون";
                        case int x when (x > 2 && x < 10):
                            return ConvertLastTwoLetter(No, TypeOfConvert.TwoNumbers);
                        default:
                            return "";
                    }
                case NumberStat.SecondNumber:
                    switch (No)
                    {
                        case 1: return "أحد";
                        case 2: return ConvertLastTwoLetter(No,TypeOfConvert.NumberIsTwo);
                        case int x when (x > 2 && x < 10):
                            return ConvertOneNumberToString(No);
                        default:
                            return "";
                    }
                default:
                    return "";
            }
        }
        private static string ConvertThreeNumbersToString(int No)
        {
            switch (No)
            {
                case 1: return ConvertOneAndZeroNumbersToString(2);
                case 2: return "مأتين";
                case int x when (x > 2 && x < 10):
                    return ConvertLastTwoLetter(No, TypeOfConvert.ThreeNumbers);
                default:
                    return "";
            }

        }
        private static string ConvertFourNumbersToString(int No)
        {
            switch (No)
            {
                case 1: return ConvertOneAndZeroNumbersToString(3);
                case 2: return "ألفين";
                case int x when (x > 2 && x < 10):
                    return ConvertLastTwoLetter(No, TypeOfConvert.FourNumbers); ;
                default:
                    return "";
            }
        }
        private static string ConvertFiveNumbersToString(int No)
        {
            switch (No)
            {
                case 10: return ConvertOneAndZeroNumbersToString(4);
                case int x when (x > 10 && x < 100):
                    return ConvertLastTwoLetter(No, TypeOfConvert.FiveNumbers);
                default:
                    return " ";
            }
        }

       
        #endregion
        #region Spelling Methods
        private static StringBuilder SpellingOneNumber(int No)
        {
            return new StringBuilder(ConvertOneNumberToString(No));
        }
        private static StringBuilder SpellingTwoNumbers(int No,int Count = 2)
        {
            var ReturnString = new StringBuilder();
            //Check If it All Of List Is Number
            var ListOfStringNumbers = ConvertIntNumberToStringList(No);
            var listOfNumbers = IsNumber(ListOfStringNumbers).listToNumbers;
            //Check for Zeros in Array
            if (CheckIfItsOneAndZerosOnly(ListOfStringNumbers))
            {
                return ReturnString.Append(ConvertOneAndZeroNumbersToString(Count- 1));
            }
            else
            {
                int FirstNo = listOfNumbers.FirstOrDefault();
                int LastNo = listOfNumbers.Last();
                if (FirstNo != 1 && LastNo == 0)
                {
                    ReturnString.Append(ConvertTwoNumbersToString(FirstNo, NumberStat.FirstNumber));
                }
                else
                {
                    if (FirstNo == 1)
                    {
                        ReturnString.Append(ConvertTwoNumbersToString(LastNo, NumberStat.SecondNumber) + " ");
                    }
                    else
                    {
                        ReturnString.Append(ConvertOneNumberToString(LastNo) + " ");
                        ReturnString.Append(" و");
                    }
                    ReturnString.Append(ConvertTwoNumbersToString(FirstNo, NumberStat.FirstNumber));
                }
            }
            return ReturnString;
        }
        private static StringBuilder SpellingThreeNumbers(int No, int Count = 3)
        {
            var ReturnString = new StringBuilder();
            //Check If it All Of List Is Number
            var ListOfStringNumbers = ConvertIntNumberToStringList(No);
            var listOfNumbers = IsNumber(ListOfStringNumbers).listToNumbers;
            //Check for Zeros in Array
            if (CheckIfItsOneAndZerosOnly(ListOfStringNumbers))
            {
                return ReturnString.Append(ConvertOneAndZeroNumbersToString(Count - 1));
            }
            else
            {
                var FirstNumber = listOfNumbers.FirstOrDefault();   
                ReturnString.Append(ConvertThreeNumbersToString(FirstNumber));
                string RestOfNumbersString = SpellingTwoNumbers(ReturnNumberAfterSpiltingFirstNumber(No)).ToString();
                if (RestOfNumbersString != " ")
                {
                    ReturnString.Append(" و");
                }

                ReturnString.Append(RestOfNumbersString);
            }
            return ReturnString;
        }
        private static StringBuilder SpellingFourNumbers(int No, int Count = 4)
        {
            var ReturnString = new StringBuilder();
            //Check If it All Of List Is Number
            var ListOfStringNumbers = ConvertIntNumberToStringList(No);
            var listOfNumbers = IsNumber(ListOfStringNumbers).listToNumbers;
            //Check for Zeros in Array
            if (CheckIfItsOneAndZerosOnly(ListOfStringNumbers))
            {
                return ReturnString.Append(ConvertOneAndZeroNumbersToString(Count - 1));
            }
            else
            {
                var FirstNumber = listOfNumbers.FirstOrDefault();
                ReturnString.Append(ConvertFourNumbersToString(FirstNumber));
                string RestOfNumbersString = SpellingThreeNumbers(ReturnNumberAfterSpiltingFirstNumber(No)).ToString();
                if (RestOfNumbersString != " ")
                {
                    ReturnString.Append(" و");
                }
                ReturnString.Append(RestOfNumbersString);
            }
            return ReturnString;
        }
        private static StringBuilder SpellingFiveNumbers(int No, int Count = 5)
        {
            var ReturnString = new StringBuilder();
            //Check If it All Of List Is Number
            var ListOfStringNumbers = ConvertIntNumberToStringList(No);
            var listOfNumbers = IsNumber(ListOfStringNumbers).listToNumbers;
            //Check for Zeros in Array
            if (CheckIfItsOneAndZerosOnly(ListOfStringNumbers))
            {
                return ReturnString.Append(ConvertOneAndZeroNumbersToString(Count - 1));
            }
            else
            {
                var FirstCountOfNumbers = ReturnFirstCountOfNumbers(No,2);
                ReturnString.Append(ConvertFiveNumbersToString(FirstCountOfNumbers));
                int RestOfNumbers = ReturnNumberAfterSpiltingFirstCountOfNumbers(No, 2);
                string RestOfNumbersString = SpellingThreeNumbers(RestOfNumbers).ToString();
                if (RestOfNumbersString != " ")
                {
                    ReturnString.Append(" و");
                }
                ReturnString.Append(RestOfNumbersString);
            }
            return ReturnString;
        }
        #endregion
        #region Main Method
        public static StringBuilder SpellingNumber(int Number)
        {
            var NumberSeparated = ConvertIntNumberToStringList(Number);
            int TotalNumber = NumberSeparated.Count();

            switch (TotalNumber)
            {
                case int x when (x == 1):
                    return SpellingOneNumber(Number);
                case int x when (x == 2):
                    return SpellingTwoNumbers(Number);
                case int x when (x == 3):
                    return SpellingThreeNumbers(Number);
                case int x when (x == 4):
                    return SpellingFourNumbers(Number);
                case int x when (x == 5):
                    return SpellingFiveNumbers(Number);
                default:
                    return new StringBuilder("");
            }
        }
        #endregion
    }
}