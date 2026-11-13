namespace LoanSphere.Application.Interface;
using LoanSphere.Domain.Entities;
public interface ILoanApplicationRepository
{
    Task SaveApplication(LoanApplication application);
}