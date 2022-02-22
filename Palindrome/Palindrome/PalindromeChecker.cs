using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class PalindromeChecker
    {
        private readonly IStringManipulators _stringManipulators;

        public PalindromeChecker(IStringManipulators stringManipulators)
        {
            _stringManipulators = stringManipulators;
        }

        public bool IsPalindrome(string stringInConsideration, bool shouldAllowOnlyAlphabets)
        {
            var result = _stringManipulators.Reverse(stringInConsideration, shouldAllowOnlyAlphabets);
            return result.reversed == result.sanitized;
        }
    }
}
