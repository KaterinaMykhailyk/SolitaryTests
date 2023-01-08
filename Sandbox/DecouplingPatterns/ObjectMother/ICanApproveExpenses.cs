namespace Unit_Tests.DecouplingPatterns.ObjectMother;

public interface ICanApproveExpenses
{
    bool CanApprove(decimal amountToApprove);
}