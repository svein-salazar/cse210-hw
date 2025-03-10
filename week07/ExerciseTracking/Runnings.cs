using System;

public class Running : Activity
{
    private double distanceInMiles;

    public Running(DateTime date, int durationInMinutes, double distanceInMiles)
        : base(date, durationInMinutes)
    {
        this.distanceInMiles = distanceInMiles;
    }

    public override double GetDistance() => distanceInMiles;
    public override double GetSpeed() => (distanceInMiles / GetDuration()) * 60;
    public override double GetPace() => GetDuration() / distanceInMiles;
}
