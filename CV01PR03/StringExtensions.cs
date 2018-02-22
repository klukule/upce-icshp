namespace CV01PR03
{
    public enum Gender
    {
        Male,
        Female,
        None
    }

    public static class StringExtensions
    {
        public static bool TryParseGender(this string raw, out Gender gender)
        {
            gender = Gender.None;

            if (raw.Contains("/"))
            {
                raw = raw.Split('/')[0];
            }

            if (raw.Length == 6 && ushort.TryParse(raw.Substring(2, 2), out ushort month))
            {
                gender = month >= 50 ? Gender.Female : Gender.Male;
                return true;
            }
            return false;
        }
    }
}