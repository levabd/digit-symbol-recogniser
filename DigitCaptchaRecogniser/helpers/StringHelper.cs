namespace DigitCaptchaRecogniser.Helpers
{
    public static class StringHelper
    {
        public static int SafeToInt(this string s, int defaltValue)
        {
            int result;
            if (!int.TryParse(s, out result))
                result = defaltValue;
            return result;
        }
    }
}