namespace PluralsightNunit
{
    public class AirlineMembershipNumberValidator
    {
        public bool ValidityOf(string membershipNumber)
        {
            var isIncorrectLength = membershipNumber == "" || membershipNumber.Length != 8;

            if (isIncorrectLength)
            {
                return false;
            }

            if (StartsWithALetterFollowBy7Numbers(membershipNumber))
            {
                return true;
            }

            return false;
        }

        private static bool StartsWithALetterFollowBy7Numbers(string membershipNumber)
        {
            int dummy;

            return char.IsLetter(membershipNumber[0]) &&
                int.TryParse(membershipNumber.Substring(1), out dummy);
        }
    }
}
