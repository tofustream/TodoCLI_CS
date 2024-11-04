namespace TodoCLI_CS.Domain.VOs
{
    public class Deadline
    {
        private readonly DateTime _value;

        public Deadline(DateTime value)
        {
            if (value < DateTime.UtcNow)
            {
                throw new ArgumentException("Deadline cannot be set in the past.");
            }

            _value = value;
        }

        public DateTime Value => _value;

        public override string ToString() => _value.ToString("yyyy-MM-dd HH:mm:ss");
    }
}
