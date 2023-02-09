
namespace DataAccess.util
{
    internal class DataEncryption
    {
        internal string Encrypt(string Value)
        {
            string result = "";
            char[] _Value = Value.ToCharArray();

            foreach (char item in _Value)
            {
                result += Convert.ToChar(item + 3).ToString();
            }
            foreach (char item in _Value)
            {
                result += Convert.ToChar(item - 8).ToString();
            }
            foreach (char item in _Value)
            {
                result += Convert.ToChar(item +6).ToString();
            }
            return result;
        }
    }
}
