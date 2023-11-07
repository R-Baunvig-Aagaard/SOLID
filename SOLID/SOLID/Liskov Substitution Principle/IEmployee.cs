namespace Liskov_Substitution_Principle
{
    public interface IEmployee
    {
        string Firstname { get; set; }
        string Lastname { get; set; }
        decimal Salary { get; set; }

        void CalculateHourRate(int rank);
    }
}