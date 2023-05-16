using Newtonsoft.Json.Linq;
using System;
using Xunit;


namespace NestedObjects
{
    public class UnitTest1
    {       

        [Fact]
        public static void Test1()
        {
            JObject obj = JObject.Parse("{\"a\":{\"b\":{\"c\":\"d\"}}}");
             Program.GetNestedValueByKey(obj, "a/b/c");
        }

        [Fact]
        public static void Test2()
        {
            JObject obj = JObject.Parse("{\"x\":{\"y\":{\"z\":\"a\"}}}");
            Program.GetNestedValueByKey(obj, "x/y");
        }

        [Fact]
        public static void Test3()
        {
            JObject obj = JObject.Parse("{\"x\":{\"y\":{\"z\":\"a\"}}}");
             Program.GetNestedValueByKey(obj, "x");
        }
    }
}
