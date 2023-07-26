﻿using PersonSerialization.Models;

namespace PersonSerialization.Repository;

public static class PersonRepository
{
	public static List<Person> GenerateRandomPersons(int count)
	{
		var random = new Random();
		var persons = new List<Person>(capacity: count);

		for (var i = 0; i < count; i++)
		{
			Person person = new Person
			{
				Id = i + 1,
				TransportId = Guid.NewGuid(),
				FirstName = "FirstName_" + i,
				LastName = "LastName_" + i,
				SequenceId = random.Next(1000),
				CreditCardNumbers = Enumerable.Range(0, random.Next(1, 6)).Select(_ => RandomDataGeneratorRepository.GenerateRandomCreditCard()).ToArray(),
				Age = random.Next(18, 65),
				Phones = Enumerable.Range(0, random.Next(1, 4)).Select(_ => "Phone_" + RandomDataGeneratorRepository.GenerateRandomDigits(10)).ToArray(),
				BirthDate = DateTimeOffset.FromUnixTimeSeconds(random.Next(0, (int)DateTimeOffset.UtcNow.ToUnixTimeSeconds())).ToUnixTimeSeconds(),
				Salary = random.Next(50000, 150000),
				IsMarried = random.Next(2) == 0,
				Gender = random.Next(2) == 0 ? Gender.Male : Gender.Female,
				Children = Enumerable.Range(0, random.Next(0, 4)).Select(_ => ChildRepository.GenerateRandomChild()).ToArray()
			};

			persons.Add(person);
		}

		return persons;
	}

}