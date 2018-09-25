using System.Collections.Generic;

namespace PayrollSystem.Model
{
    public class CommissionedClassification : IPaymentClassification
    {
        private IEnumerable<SalesReceipt> _salesReceipts;
        private decimal _commissionRate;
        private decimal _salary;
    }
}
