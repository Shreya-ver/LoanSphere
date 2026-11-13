namespace LoanSphere.Infrastructure.Repositories;
using LoanSphere.Application.Interface;
using LoanSphere.Domain.Entities;

public class LoanApplicationRepository : ILoanApplicationRepository
{
    public async Task SaveApplication(LoanApplication application)
    {
        // Implementation for adding the loan application to the database
    }
}