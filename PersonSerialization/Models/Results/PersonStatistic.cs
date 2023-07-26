namespace PersonSerialization.Models.Results;

/// <summary>
/// Persons statistic
/// </summary>
/// <param name="personsCount"></param>
/// <param name="creditCardCount"></param>
/// <param name="averageChildAge"></param>
public record PersonStatistic(
	int personsCount,
	int creditCardCount,
	double averageChildAge
);