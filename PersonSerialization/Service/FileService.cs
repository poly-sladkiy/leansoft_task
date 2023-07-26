namespace PersonSerialization.Service;

/// <summary>
/// File repository
/// </summary>
public class FileService
{
	/// <summary>
	/// Write data to file
	/// </summary>
	/// <param name="filePath"></param>
	/// <param name="content"></param>
	public static void WriteToFile(string filePath, string content)
	{
		File.WriteAllText(filePath, content);
	}

	/// <summary>
	/// Get data from file
	/// </summary>
	/// <param name="filePath"></param>
	/// <returns></returns>
	public static string ReadFromFile(string filePath)
	{
		return File.ReadAllText(filePath);
	}
}