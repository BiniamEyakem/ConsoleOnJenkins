using System;
using System.Collections.Generic;
using System.Text;
using ConsoleOnJenkins.Models;
using Newtonsoft.Json;

namespace ConsoleOnJenkins.Extensions
{
public static    class PersonExtension
    {
        public static string ToJsonString(this Person person) => JsonConvert.SerializeObject(person);
    }
}
