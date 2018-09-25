using System.Collections.Generic;

namespace PayrollSystem.Model
{
    public class HourlyClassification : IPaymentClassification
    {
        private IEnumerable<TimeCard> _timeCards;
        private decimal _hourlyRate;
    }
}
