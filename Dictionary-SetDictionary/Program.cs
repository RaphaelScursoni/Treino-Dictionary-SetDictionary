using System;
using System.Collections.Generic;

namespace Dictionary_SetDictionary {
    class Program {
        static void Main(string[] args) {

            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "333231";
            cookies["phone"] = "53452345";

            if (cookies.ContainsKey("email")) {
                Console.WriteLine(cookies["email"]);
            } else {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES:");
            foreach(KeyValuePair<string, string> item in cookies) {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
