using System;

public class Cycling : Activity
{
    private double speedInMph;

    public Cycling(DateTime date, int durationInMinutes, double speedInMph)
        : base(date, durationInMinutes)
    {
        this.speedInMph = speedInMph;
    }

    public override double GetDistance() => (speedInMph * GetDuration()) / 60;
    public override double GetSpeed() => speedInMph;
    public override double GetPace() => 60 / speedInMph;
}
