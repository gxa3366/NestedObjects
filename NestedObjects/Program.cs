using Newtonsoft.Json.Linq;
using System;
using System.Reflection;

namespace NestedObjects
{
   public class Program
    {
        static void Main(string[] args)
        {
            
            /*Tests*/
            JObject obj = JObject.Parse("{\"a\":{\"b\":{\"c\":\"d\"}}}");
             GetNestedValueByKey(obj, "a/b/c");
           // Console.WriteLine(value); // Output: "d"
            obj = JObject.Parse("{\"x\":{\"y\":{\"z\":\"a\"}}}");
            GetNestedValueByKey(obj, "x/y");
            //Console.WriteLine(value); // Output: { "z": "a" }
            obj = JObject.Parse("{\"x\":{\"y\":{\"z\":\"a\"}}}");
            GetNestedValueByKey(obj, "x");
            //Console.WriteLine(value); // Output: { "y": { "z": "a" } }
            obj = JObject.Parse("{\"x\":{\"y\":{\"z\":\"a\"}}}");
            GetNestedValueByKey(obj, "k"); // key not exists in json
           // Console.WriteLine(value); // Output: Key k not exists
        }


        public static void GetNestedValueByKey(JObject obj, string key)
        {
            var keys = key.Split('/');
            JToken current = obj;
            foreach (var k in keys)
            {
                current = current[k];
                if (current == null)
                {
                    current= $"Key {key} not exists";
                }
            }
            //return current;
            Console.WriteLine(current);
        }
    }
}
