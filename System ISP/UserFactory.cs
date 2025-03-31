namespace System_ISP
{
    public static class UserFactory
    {
        public static Form CreateFormForRole(string role)
        {
            return role.ToLower() switch
            {
                "admin" => new Adminmenu(),
                "serwisant" => new Serwisant(),
                "konsultant" => new Konsultant(),
                "ksiegowy" => new Ksiegowy(),
                "user" => new user(),
                _ => null
            };
        }
    }
}
