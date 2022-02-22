using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class StringManipulators : IStringManipulators
    {
        public (string sanitized, string reversed) Reverse(string stringInConsideration, bool allowOnlyAlphabets = true)
        {
            var result = string.Empty;
            var characters = stringInConsideration.ToCharArray();
            var charactersToUse = allowOnlyAlphabets == false ? characters.ToList() : characters.ToList().Where(c => char.IsLetter(c)).ToList();

            for(var i = (charactersToUse.Count() - 1); i >= 0; i--)
            {
                result += charactersToUse[i];
            }
            return (new String(charactersToUse.ToArray()), result);
        }
    }
}
