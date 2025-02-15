﻿using System.Text.Json;

namespace CleanArchitecture.ISP.DeviceSync;
internal static class Serializer
{
    private static JsonSerializerOptions Options => new()
    {
        WriteIndented = true
    };

    public static string Serialize<T>(T value)
    {
        string result = $"{typeof(T).Name}: {Environment.NewLine}";
        return result + JsonSerializer.Serialize(value, Options);
    }
}