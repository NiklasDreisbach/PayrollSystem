using System.Collections.Generic;

namespace PayrollSystem.Model
{
    public class UnionAffiliation : IAffiliation
    {
        private IEnumerable<ServiceCharge> _serviceCharges;
    }
}
