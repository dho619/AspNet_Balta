namespace Blog{

    public static class Configuration
    {
        public static string JwtKey = "8d9bb593950b49fcb67e15bdd9870d45";
        public static string ApiKeyName = "api_key";
        public static string ApiKey = "curso_api_IFJASDAASJDIASJDAISJ/-*";
        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }
    }
}