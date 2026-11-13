using LoanSphere.Domain.Enums;
namespace LoanSphere.Domain.Entities;
public class LoanApplication
{
public Guid ID {get; private set;}
public string ApplicantName {get;private set;}
public string PAN {get;private set;}
public Decimal RequestedAmount {get;private set;}
public int TenureMonths {get;private set;}
public Decimal AnnualInterestRate {get;private set;}	
public InterestPaymentFrequency InterestPaymentFrequency {get;private set;}
public Status Status {get;private set;}

}