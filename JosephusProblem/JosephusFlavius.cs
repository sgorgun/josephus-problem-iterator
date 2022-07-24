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
        /// Returns the iterator that generates a list of persons that are crossed out.
        /// </summary>
        /// <param name="count">Count of the persons in circle.</param>
        /// <param name="crossedOut">The number of the person to be crossed out.</param>
        /// <returns>Returns the iterator that generates a list of persons that are crossed out.</returns>
        /// <exception cref="ArgumentException"><paramref name="count"/>is less than 1.</exception>
        /// <exception cref="ArgumentException"><paramref name="crossedOut"/> is less than 1.</exception>
        public static IEnumerable<int> GetCrossedOutPersons(int count, int crossedOut)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns order number of survivor.
        /// </summary>
        /// <param name="count">Count of the persons in circle.</param>
        /// <param name="crossedOut">The number of the person to be crossed out.</param>
        /// <returns>The order number of the last survivor.</returns>
        /// <exception cref="ArgumentException"><paramref name="count"/>is less than 1.</exception>
        /// <exception cref="ArgumentException"><paramref name="crossedOut"/> is less than 1.</exception>
        public static int GetSurvivor(int count, int crossedOut)
        {
            throw new NotImplementedException();
        }
    }
}
