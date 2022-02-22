namespace Palindrome
{
    public interface IStringManipulators
    {
        (string sanitized, string reversed) Reverse(string stringInConsideration, bool allowOnlyAlphabets);
    }
}