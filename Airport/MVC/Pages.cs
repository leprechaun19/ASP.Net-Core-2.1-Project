using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.MVC
{
    public static class Account
    {
        public static class Login
        {
            public const string FullUrl = "/Account/Login";
        }
        public static class Index
        {
            public const string FullUrl = "/Account/Index";
        }
    }

    public static class Home
    {
        public static class Index
        {
            public const string FullUrl = "/Home/Index";
            public const string Controller = "Home";
            public const string Action = "Index";
        }
    }

    public static class Airline
    {
        public static class Index
        {
            public const string FullUrl = "/Airline/Index";
            public const string Controller = "Airline";
            public const string Action = "Index";
        }
    }

    public static class Airplane
    {
        public static class Index
        {
            public const string FullUrl = "/Airplane/Index";
            public const string Controller = "Airplane";
            public const string Action = "Index";
        }
    }

}
