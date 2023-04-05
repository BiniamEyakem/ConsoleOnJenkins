using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ConsoleOnJenkins.Extensions
{
    public static class StringExtension
    {
        public static T ToTypeOfT<T>(this String t) => JsonConvert.DeserializeObject<T>(t);
    }
}
