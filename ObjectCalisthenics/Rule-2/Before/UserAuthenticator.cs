namespace ObjectCalisthenics.Rule_2.Before
{
    internal class UserAuthenticator
    {
        public string CheckAccess(User user)
        {
            if (!user.IsAuthenticated)
            {
                return "Access denied: not authenticated.";
            }
            else
            {
                if (user.IsSuspended)
                {
                    return "Access denied: user suspended.";
                }
                else
                {
                    return "Access granted.";
                }
            }
        }

        public class User
        {
            public bool IsAuthenticated { get; set; }
            public bool IsSuspended { get; set; }
        }
    }
}
