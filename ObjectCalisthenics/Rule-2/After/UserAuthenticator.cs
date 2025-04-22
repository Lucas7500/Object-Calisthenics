namespace ObjectCalisthenics.Rule_2.After
{
    internal class UserAuthenticator
    {
        // Using 'Fail Fast' Technique
        public string CheckAccess(User user)
        {
            if (!user.IsAuthenticated)
            {
                return "Access denied: not authenticated.";
            }

            if (user.IsSuspended)
            {
                return "Access denied: user suspended.";
            }
            
            return "Access granted.";
        }

        public class User
        {
            public bool IsAuthenticated { get; set; }
            public bool IsSuspended { get; set; }
        }
    }
}
