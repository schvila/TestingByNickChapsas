﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Utils;

public class CopyLib
{
    public static T DeepCloneJson<T>(object obj)
    {
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            DateFormatHandling = DateFormatHandling.IsoDateFormat,
            //DateFormatString = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fff'Z'"
        };
        var data = JsonConvert.SerializeObject(obj, settings);

        settings.Converters.Add(new StringEnumConverter());
        return JsonConvert.DeserializeObject<T>(data, settings);

    }
}
