using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Microsoft.Win32;

namespace JsonParsing
{
    internal static class MyJsonParser
    {

        public static string Parse(string RawJson)
        {
            
            try
            {
                string json = RawJson;

                JsonDocument doc = JsonDocument.Parse(json);
                JsonElement root = doc.RootElement;

                
                string name = root.GetProperty("name").GetString();
                int age = root.GetProperty("age").GetInt32();
                string email = root.GetProperty("email").GetString();

                return $"Jméno: {name}, Věk: {age}, Email: {email}";
                

            }
            catch (JsonException je)
            {
                throw je;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static User ParseToClass(string RawJson)
        {
            User u = JsonSerializer.Deserialize<User>(RawJson);

            return u;
        }
    }
}
