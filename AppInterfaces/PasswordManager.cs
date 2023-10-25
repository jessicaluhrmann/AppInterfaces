namespace AppInterfaces
{
    class PasswordManager : IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            if (Hidden == false)
            {
                foreach (char character in Password)
                {
                    Console.WriteLine(character);
                }
            }
            else
            {
                Console.WriteLine("**************");
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }
    }
}