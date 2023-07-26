namespace PersonSerialization.Models.Results;

/// <summary>
/// Persons statistic
/// </summary>
/// <param name="personCount"></param>
/// <param name="creditCountCount"></param>
/// <param name="avarageChildAge"></param>
public record PersonStatistic(
	int personCount,
	int creditCountCount,
	double avarageChildAge
);