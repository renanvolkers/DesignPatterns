namespace Prototype.Domain
{
    public interface IEmployee
    {
        IEmployee Clone();
        IEmployee CloneDeep();
        string GetDetails();
    }
}
