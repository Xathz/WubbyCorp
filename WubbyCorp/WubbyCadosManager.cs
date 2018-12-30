using System.ComponentModel;
using WubbyCorp.Extensions;

namespace WubbyCorp {

    internal static class WubbyCadosManager {

        private static readonly object _WubbyCadosLock = new object();

        public static event PropertyChangedEventHandler TotalChanged;
        private static void OnTotalChanged(string propertyName) => TotalChanged?.Invoke(TotalChanged, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Total WubbyCados.
        /// </summary>
        private static double _Total;
        public static double Total {
            get => _Total;
            private set {
                if (!(_Total == value)) {
                    _Total = value;
                    OnTotalChanged(nameof(Total));
                }
            }
        }

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

        /// <summary>
        /// 
        /// </summary>
        public static string TotalFormatted() {
            (double value, string dictionaryWord) = Total.ToDictionaryWord();
            return $"{((Total > 999D) ? value.ToString("N2") : value.ToString("N0"))} {((string.IsNullOrEmpty(dictionaryWord)) ? "" : $"{dictionaryWord} ")}WubbyCado{((Total == 1D) ? "" : "s")}";
        }

    }

}

