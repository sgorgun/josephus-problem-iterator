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
            CheckExceptions(count, crossedOut);

            return GetCrossedOutPersons();

            IEnumerable<int> GetCrossedOutPersons()
            {
                var q = MakeQueue(count);

                while (q.Count > 1)
                {
                    for (int i = 1; i < crossedOut; i++)
                    {
                        q.Enqueue(q.Dequeue());
                    }

                    yield return q.Dequeue();
                }
            }
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
            CheckExceptions(count, crossedOut);

            var q = MakeQueue(count);

            while (q.Count > 1)
            {
                for (int i = 1; i < crossedOut; i++)
                {
                    q.Enqueue(q.Dequeue());
                }

                q.Dequeue();
            }

            return q.Dequeue();
        }

        private static Queue<int> MakeQueue(int count)
        {
            var q = new Queue<int>(count);
            for (int i = 1; i <= count; i++)
            {
                q.Enqueue(i);
            }

            return q;
        }

        private static void CheckExceptions(int count, int crossedOut)
        {
            if (count < 1)
            {
                throw new ArgumentException($"{nameof(count)} is less than 1.");
            }

            if (crossedOut < 1)
            {
                throw new ArgumentException($"{nameof(crossedOut)} is less than 1.");
            }
        }
    }
}
