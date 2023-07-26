namespace PersonSerialization.Repository;

/// <summary>
/// Contains various data generators 
/// </summary>
public class RandomDataGeneratorRepository
{
	/// <summary>
	/// Generate random credit card number
	/// </summary>
	/// <returns></returns>
	public static string GenerateRandomCreditCard()
	{
		var cardNumber = "****-****-****-" + GenerateRandomDigits(4);
		return cardNumber;
	}
	
	/// <summary>
	/// Generate random digits string with specific length
	/// </summary>
	/// <param name="length"></param>
	/// <returns></returns>
	private static string GenerateRandomDigits(int length)
	{
		var random = new Random();
		const string chars = "0123456789";
		return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
	}
}