namespace Validation
{
    public class Validator
    {
        public bool IsNumber(object textInput)
        {
            if (textInput is int)
                return true;
            else if (textInput is string)
                return int.TryParse((string)textInput, out _);
            else
                return false;
        }
    }
}
