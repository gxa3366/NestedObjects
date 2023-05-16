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
            var value = Program.GetNestedValueByKey(obj, "a/b/c");
            Assert.Equal("d",value.ToString());
        }

        [Fact]
        public static void Test2()
        {
            JObject obj = JObject.Parse("{\"a\":{\"b\":{\"c\":\"d\"}}}");
            var value = Program.GetNestedValueByKey(obj, "k");
            Assert.Equal("Key k not exists", value.ToString());
        }


        [Fact]
        public static void Test3()
        {
            JObject obj = JObject.Parse("{\"a\":{\"b\":{\"c\":\"d\"}}}");
            var value = Program.GetNestedValueByKey(obj, "k");
            Assert.Equal("Key k", value.ToString());
        }


    }
}
