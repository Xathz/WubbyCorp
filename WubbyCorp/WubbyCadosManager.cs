namespace WubbyCorp {

    internal static class WubbyCadosManager {

        private static readonly object _WubbyCadosLock = new object();

        /// <summary>
        /// Total WubbyCados.
        /// </summary>
        public static double Total { get; private set; }

        /// <summary>
        /// Add WubbyCados to the <see cref="Total"/>.
        /// </summary>
        /// <param name="amount">Amount of WubbyCados to add.</param>
        public static void Add(double amount) {
            lock (_WubbyCadosLock) {
                double tempTotal;
                try {
                    tempTotal = checked(Total + amount);
                } catch {
                    tempTotal = double.MaxValue;
                }
                Total = tempTotal;
            }
        }

        /// <summary>
        /// Subtract WubbyCados from the <see cref="Total"/>.
        /// </summary>
        /// <param name="amount">Amount of WubbyCados to subtract.</param>
        public static void Subtract(double amount) {
            lock (_WubbyCadosLock) {
                double tempTotal = (Total - amount);

                if (tempTotal <= 0D) {
                    Total = 0D;
                } else {
                    Total = tempTotal;
                }
            }
        }

    }

}

