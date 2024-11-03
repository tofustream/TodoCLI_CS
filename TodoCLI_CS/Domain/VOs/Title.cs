namespace TodoCLI_CS.Domain.VOs
{
    public class Title
    {
        private readonly string _value;

        public Title(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("title must not be empty");
            }

            if (value.Length > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(value), "please keep the title under 100 characters");
            }

            _value = value;
        }

        public string Value => _value;

        public override string ToString()
        {
            return _value;
        }
    }
}
