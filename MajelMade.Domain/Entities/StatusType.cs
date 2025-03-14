namespace MajelMade.Domain.Entities;

public class StatusType(int statusTypeID, string statusName)
{
    public int StatusTypeID { get; init; } = statusTypeID;
    public string StatusName { get; init; } = statusName;
}
