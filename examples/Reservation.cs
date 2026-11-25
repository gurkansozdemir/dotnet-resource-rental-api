public enum ReservationState { Requested, Approved, Returned, Cancelled }
public sealed record Reservation(string ItemCode, DateOnly Start, DateOnly End, ReservationState State);

public static class ReservationRules
{
    public static bool HasValidRange(Reservation value) => value.End >= value.Start;
}
