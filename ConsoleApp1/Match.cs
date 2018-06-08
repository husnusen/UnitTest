using ConsoleApp1.Interfaces;
using ConsoleApp1.Extension;
namespace ConsoleApp1
{
    /// <summary>
    /// ----------------------
    /// **** Instructions **** 
    /// ----------------------
    /// Below is a description of a search term highlighting task. An initial attempt has been made to implement a solution (see Decorate method).
    /// There are several issues with the existing algorithm; in fact it doesn't meet all the criteria specified below (but not all problems
    /// are covered in the requirements).
    /// 
    /// You should add unit tests to cover different senarios and update the algorithm.
    /// 
    /// If there are even any available, you shouldn't use an external search highlighting library. The idea is to learn about your approach
    /// to solving problems, you should be able to solve this using .NET framework.
    /// 
    /// Imagine the solution you send back is to be code reviewed (i.e. follow best practice coding standards). 

    /// ----------------------
    /// **** Requirements **** 
    /// ----------------------
    /// The application should match some search terms (space character seperated) against a piece of text, outputting a copy of the original
    /// text where all the words in the search terms wrapped in a SPAN tag
    /// 
    /// i.e. Text= "This is a test.", Subtext= "This test", output = "<span>This</span> is a <span>test</span>."
    /// 
    /// Multiple matches are possible.
    /// Matching should be case insensitive.
    /// 
    /// </summary>

    public class Match:IDecorator
	{
        private string result = "";

		public string Decorate(string text, string subText)
		{
            if (text.IsTextEmptyOrNull()||
                subText.IsTextEmptyOrNull()) return result;

			result = text.ConvertToLower();
			//string[] subTexts = subText.Split(' ');

			foreach (string value in subText.GetDistinctItems())
			{
				string decoratedText = "<span>" + value + "</span>";
				result = result.Replace(value, decoratedText);
			}


			return result.CheckCaseSensitive(text);
		}
	}
}
