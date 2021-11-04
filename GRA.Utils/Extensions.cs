using Newtonsoft.Json;

namespace GRA.Utils
{

    public static class Extensions
    {
        public static string ToJason(this object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T StringJsonToObject<T>(this string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}
