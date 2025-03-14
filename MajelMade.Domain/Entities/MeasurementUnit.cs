namespace MajelMade.Domain.Entities
{
    public class MeasurementUnit(int measurementUnitID, string unitName)
    {
        public int MeasurementUnitID { get; set; } = measurementUnitID;
        public string UnitName { get; set; } = unitName;
    }
}
