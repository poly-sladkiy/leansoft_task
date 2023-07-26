using Newtonsoft.Json;
using PersonSerialization.Models;

namespace PersonSerialization.Service;

/// <summary>
/// Json serializer
/// </summary>
public class JsonSerializerService
{
	private static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
	{
		DateFormatString = "yyyy-MM-ddTHH:mm:ssZ",
		ContractResolver = new Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver()
	};

	/// <summary>
	/// Serialize object
	/// </summary>
	/// <param name="value"></param>
	/// <returns></returns>
	public static string SerializeToJson(object? value)
	{
		return JsonConvert.SerializeObject(value, Settings);
	}
	
	/// <summary>
	/// 
	/// </summary>
	/// <param name="json"></param>
	/// <returns></returns>
	public static T? DeserializeFromJson<T>(string json)
	{
		return JsonConvert.DeserializeObject<T>(json, Settings);
	}
}