using System;
using System.Collections.Generic;
using System.Text;

namespace CarManager.Core.Utilities
{
    public static class UnitConverter
    {
        private const double PsPerKw = 1.359621617;
        private const double HpPerKw = 1.34102209;

        public static int KwToPs(int kw)
            => (int)Math.Round(kw * PsPerKw);

        public static int KwToHp(int kw)
            => (int)Math.Round(kw * HpPerKw);
    }
}
