namespace Devops.Core
{
    public class Aquarium
    {
        private DateTime _createdAt;
        public DateTime CreatedAt
        {
            get
            {
                return _createdAt;
            }
            private set
            {
                _createdAt = value;
            }
        }

        public int Duration
        {
            get {
                return (int)(DateTime.Now - _createdAt).TotalSeconds;
            }
        }

        public Aquarium()
        {
            CreatedAt = DateTime.Now;
        }
    }
}
