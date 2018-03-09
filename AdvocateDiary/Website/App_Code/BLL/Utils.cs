using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// Summary description for Utils
/// </summary>
public class Utils
{
    #region Constructor
    public Utils()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    #endregion

    #region Methods
    /// <summary>
        /// Get the first several words from the summary
        /// </summary>
        /// <param name="s"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public string StringExtensions(string s, int length)
        {
            try
            {
                // Number of words we still want to display.
                int words = length;
                // Loop through entire summary.
                for (int i = 0; i < s.Length; i++)
                {
                    // Increment words on a space.
                    if (s[i] == ' ')
                    {
                        words--;
                    }
                    // If we have no more words to display, return the substring.
                    if (words == 0)
                    {
                        return s.Substring(0, i);
                    }
                }
            }
            catch (Exception)
            {
                // Log the error.
            }
            return string.Empty;
        }
        #endregion
    }