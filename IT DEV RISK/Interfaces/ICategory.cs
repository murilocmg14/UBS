namespace IT_DEV_RISK.Interfaces
{
    public interface ICategory
    {
        string Validate(DateTime referenceDate, ITrade trade);
    }
}
