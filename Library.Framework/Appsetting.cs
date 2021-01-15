using Library.Contract.Framework;
using System;

namespace Library.Framework
{
    public class Appsetting : IAppsetting
    {
        public string Connection_string { get; set; }
    }
}
