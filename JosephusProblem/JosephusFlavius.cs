using System;
using System.Collections.Generic;

namespace JosephusProblem
{
    /// <summary>
    /// Providing functionality for the Josephus Flavius problem.
    /// <see>You can find more details on this problem in Wikipedia - https://en.wikipedia.org/wiki/Josephus_problem</see>.
    /// </summary>
    public static class JosephusFlavius
    {
        /// <summary>
        /// Simulates the process of crossing out persons.
        /// </summary>
        /// <param name="count">Count of the persons in circle.</param>
        /// <param name="skipped">Count of skipped persons before one of them will be crossed.</param>
        /// <returns>A sequence of ordinal numbers of crossed out persons.</returns>
        /// <exception cref="ArgumentException">Thrown when <paramref name="count"/> is less than 1.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="skipped"/> is less than 1 or greater or equal to <paramref name="count"/>.</exception>
        public static IEnumerable<int> GetCrossedOutPersons(int count, int skipped)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns order number of survivor.
        /// </summary>
        /// <returns>The order number of survivor in Josephus Flavius problem.</returns>
        public static int GetSurvivor(int count, int skipped)
        {
            throw new NotImplementedException();
        }
    }
}
