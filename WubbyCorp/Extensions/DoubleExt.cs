using System.Collections.Generic;

namespace WubbyCorp.Extensions {

    internal static class DoubleExt {

        private static readonly List<string> _DictionaryWords;

        static DoubleExt() => _DictionaryWords = new List<string> {
                "",
                "Thousand",
                "Million",
                "Billion",
                "Trillion",
                "Quadrillion",
                "Quintillion",
                "Sextillion",
                "Septillion",
                "Octillion",
                "Nonillion",
                "Decillion",
                "Undecillion",
                "Duodecillion",
                "Tredecillion",
                "Quattuordecillion",
                "Quindecillion",
                "Sexdecillion",
                "Septendecillion",
                "Octodecillion",
                "Novemdecillion",
                "Vigintillion",
                "Unvigintillion",
                "Duovigintillion",
                "Trevigintillion",
                "Quattuorvigintillion",
                "Quinvigintillion",
                "Sexvigintillion",
                "Septenvigintillion",
                "Octovigintillion",
                "Novemvigintillion",
                "Trigintillion",
                "Untrigintillion",
                "Duotrigintillion",
                "Tretrigintillion",
                "Quattuortrigintillion",
                "Quintrigintillion",
                "Sextrigintillion",
                "Septentrigintillion",
                "Octotrigintillion",
                "Novemtrigintillion",
                "Quadragintillion",
                "Unquadragintillion",
                "Duoquadragintillion",
                "Trequadragintillion",
                "Quattuorquadragintillion",
                "Quinquadragintillion",
                "Sexquadragintillion",
                "Septenquadragintillion",
                "Octoquadragintillion",
                "Novemquadragintillion",
                "Quinquagintillion",
                "Unquinquagintillion",
                "Duoquinquagintillion"
        };

        /// <summary>
        /// Get the dictionary word and value for the double.
        /// </summary>
        public static (double value, string dictionaryWord) ToDictionaryWord(this double value) {
            int numberIndex = 0;
            while (value >= 1000D) {
                numberIndex++;
                value /= 1000D;
            }

            return (value, _DictionaryWords[numberIndex]);
        }

    }

}
