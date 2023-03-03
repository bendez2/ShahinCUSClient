namespace Nastol
{
    internal class CurrentUser
    {
        private static User _user = new User();
        public static User user
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
            }
        }
    }
}
