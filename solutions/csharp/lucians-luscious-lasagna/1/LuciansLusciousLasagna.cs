// The Lasagna class contains all the methods needed
// to calculate preparation and cooking times
class Lasagna
{
    // Returns the total expected time the lasagna should stay in the oven (in minutes)
    // No parameters are needed because this value is fixed according to the recipe
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // Calculates how many minutes the lasagna still needs to stay in the oven
    // minutesInOven = the number of minutes the lasagna has already been in the oven
    public int RemainingMinutesInOven(int minutesInOven)
    {
        // Reuses ExpectedMinutesInOven to avoid hard-coding the value
        return ExpectedMinutesInOven() - minutesInOven;
    }

    // Calculates the preparation time based on the number of layers
    // layers = number of layers added to the lasagna
    // Each layer takes 2 minutes to prepare
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // Calculates the total elapsed time spent cooking the lasagna
    // layers = number of layers prepared
    // minutesInOven = minutes the lasagna has already spent in the oven
    // The total time is the sum of preparation time and oven time
    public int ElapsedTimeInMinutes(int layers, int minutesInOven)
    {
        return PreparationTimeInMinutes(layers) + minutesInOven;
    }
}
