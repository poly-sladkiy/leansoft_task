using PersonSerialization.Models;

namespace PersonSerialization.Repository;

public static class ChildRepository
{
	public static Child GenerateRandomChild()
	{
		var random = new Random();
		var child = new Child
		{
			Id = random.Next(1000),
			FirstName = "ChildFirstName_" + random.Next(10),
			LastName = "ChildLastName_" + random.Next(10),
			BirthDate = DateTimeOffset.FromUnixTimeSeconds(random.Next(0, (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds())).ToUnixTimeSeconds(),
			Gender = random.Next(2) == 0 ? Gender.Male : Gender.Female
		};

		return child;
	}
}