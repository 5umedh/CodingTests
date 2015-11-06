using System;
using System.Globalization;
using System.Linq;

namespace CSharpTest.Solution
{
	//Referred this class name from the provided PDF file.
	public class Solution
	{

		/// <summary>
		/// Reverses the input string
		/// </summary>
		/// <param name="inputString">Input string to reverse between 1 to 2000 length</param>
		/// <returns>Input string in reversed format</returns>
		public string ReverseString(string inputString)
		{
			if (string.IsNullOrEmpty(inputString) || inputString.Length > Constants.UpperLimitForStringLength)
				throw new Exception(
				    $@"Length of the Input String must be between {Constants.LowerLimitForStringLength} and {Constants.UpperLimitForStringLength}"); //TODO: the error string should come from resources file
			if (inputString.Length == 1) //to avoid the String.Reverse call in case the length of the input String is 1
				return inputString;
			//returns the input string in reverse order
			return new string(inputString.Reverse().ToArray());
		}




		/// <summary>
		/// Reverses the input string using Primitive Data Types
		/// </summary>
		/// <param name="inputString">Input string to reverse between 1 to 2000 length</param>
		/// <returns>Input string in reversed format</returns>
		public string ReverseStringPrimitive(string inputString)
		{
			if (string.IsNullOrEmpty(inputString) || inputString.Length > Constants.UpperLimitForStringLength)
				throw new Exception(
				    $@"Length of the Input String must be between {Constants.LowerLimitForStringLength} and {Constants.UpperLimitForStringLength}"); //TODO: the error string should come from resources file
			if (inputString.Length == 1) //to avoid the String.Reverse call in case the length of the input String is 1
				return inputString;

			char[] outputChars = new char[inputString.Length];

			//loop to traverse the character array to the mid point for swapping the characters
			for (int startIndex = 0, endIndex = inputString.Length - 1; startIndex <= endIndex; startIndex++, endIndex--)
			{
				//copy the source to destination array in reverse order
				outputChars[startIndex] = inputString[endIndex];
				outputChars[endIndex] = inputString[startIndex];
			}

			//returns the input string in reverse order
			return new string(outputChars);
		}



		/// <summary>
		/// Function that returns the 0 based index of first occurrence of a in b
		/// </summary>
		/// <param name="numberToSearch">integer value which ranges between 0 to 999,999,999</param>
		/// <param name="sourceNumber">integer value which ranges between 0 to 999,999,999</param>
		/// <returns>returns the 0 based index of first occurrence of a in b</returns>
		public int GetIntegerDecimalOccurrence(int numberToSearch, int sourceNumber)
		{
			//both destination and souce integers should be between 1 to 999999999
			if ((numberToSearch >= Constants.LowerLimitForSearchInteger && numberToSearch <= Constants.UpperLimitForSearchInteger) == false)
				throw new ArgumentOutOfRangeException(nameof(numberToSearch));

			//both destination and souce integers should be between 1 to 999999999
			if ((sourceNumber >= Constants.LowerLimitForSearchInteger && sourceNumber <= Constants.UpperLimitForSearchInteger) == false)
				throw new ArgumentOutOfRangeException(nameof(sourceNumber));

			//returns the 0 based index of first occurrence of a in b
			return sourceNumber.ToString(CultureInfo.InvariantCulture).IndexOf(numberToSearch.ToString(CultureInfo.InvariantCulture), StringComparison.Ordinal);
		}


		/// <summary>
		/// Function that returns the 0 based index of first occurrence of a in b using primitive data types
		/// </summary>
		/// <param name="numberToSearch">integer value which ranges between 0 to 999,999,999</param>
		/// <param name="sourceNumber">integer value which ranges between 0 to 999,999,999</param>
		/// <returns>returns the 0 based index of first occurrence of numberToSearch in source</returns>
		public int GetIntegerDecimalOccurrencePrimitive(Int32 numberToSearch, Int32 sourceNumber)
		{
			//both destination and souce integers should be between 1 to 999999999
			if ((numberToSearch >= Constants.LowerLimitForSearchInteger && numberToSearch <= Constants.UpperLimitForSearchInteger) == false)
				throw new ArgumentOutOfRangeException(nameof(numberToSearch));

			//both destination and souce integers should be between 1 to 999999999
			if ((sourceNumber >= Constants.LowerLimitForSearchInteger && sourceNumber <= Constants.UpperLimitForSearchInteger) == false)
				throw new ArgumentOutOfRangeException(nameof(sourceNumber));

			//if number to be searched for is greater than the source number, return -1 (NOT FOUND)
			if (numberToSearch > sourceNumber)
				return Constants.NotFound;
			//if number to be searched for is equal to the source number, return 0 (Found at 0th position)
			if (numberToSearch == sourceNumber)
				return Constants.EqualNumbers;

			//convert the aruguments to character array as we need to use PRIMITIVE DATATYPES to build an algorithm
			char[] sourceDigits = sourceNumber.ToString(CultureInfo.InvariantCulture).ToCharArray();
			char[] digitsToSearch = numberToSearch.ToString(CultureInfo.InvariantCulture).ToCharArray();


			int outIndex = -1; //the value to be returned which will hold the index of the number to be searched if matched

			for (int sourceDigitIndex = 0; sourceDigitIndex < sourceDigits.Count(); sourceDigitIndex++)
			{
				bool isEqual = true; //flag which will check if the digits are matching. Assuming they match initially.
				for (int searchDigitIndex = 0; searchDigitIndex < digitsToSearch.Count(); searchDigitIndex++)
				{
					//if the search index (sourceDigitIndex + searchDigitIndex) goes out of the bounds of the "sourceDigits"
					//OR if digits do not match with each other
					if (((sourceDigitIndex + searchDigitIndex) >= sourceDigits.Count()) ||
						(sourceDigits[sourceDigitIndex + searchDigitIndex] != digitsToSearch[searchDigitIndex]))
					{
						isEqual = false; //the digits do not match hence move forward with next digit on sourceDigits
						break;
					}
				}

				//if number to search for is matched; the outIndex will hold the index of the matching integer
				if (isEqual)
				{
					outIndex = sourceDigitIndex; //copy the sourceDigitIndex to the output value to be returened.
					break;
				}
			}

			return outIndex;

		}

	}
}
