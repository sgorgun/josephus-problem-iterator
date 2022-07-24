using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using static JosephusProblem.JosephusFlavius;

namespace JosephusProblem.Tests
{
    [TestFixture]
    public class JosephusFlaviusTests
    {
        private static IEnumerable<TestCaseData> CrossedOutTestCases
        {
            get
            {
                yield return new TestCaseData(5, 3, new int[] { 3, 1, 5, 2 });
                yield return new TestCaseData(5, 4, new int[] { 4, 3, 5, 2 });
                yield return new TestCaseData(7, 2, new int[] { 2, 4, 6, 1, 5, 3 });
                yield return new TestCaseData(10, 2, new[] { 2, 4, 6, 8, 10, 3, 7, 1, 9 });
                yield return new TestCaseData(30, 6, new[] { 6, 12, 18, 24, 30, 7, 14, 21, 28, 5, 15, 23, 2, 11, 22, 3, 16, 27, 10, 26, 13, 1, 20, 17, 9, 19, 29, 25, 8 });
                yield return new TestCaseData(5, 2, new int[] { 2, 4, 1, 5 });
                yield return new TestCaseData(5, 6, new int[] { 1, 3, 2, 5 });
                yield return new TestCaseData(2, 5, new int[] { 1 });
                yield return new TestCaseData(3, 5, new int[] { 2, 3 });
                yield return new TestCaseData(7, 3, new int[] { 3, 6, 2, 7, 5, 1 });
                yield return new TestCaseData(2, 4, new int[] { 2 });
                yield return new TestCaseData(21, 8, new int[] { 8, 16, 3, 12, 21, 10, 20, 11, 2, 15, 7, 4, 19, 18, 1, 6, 14, 13, 5, 17 });
            }
        }

        private static IEnumerable<TestCaseData> SurvivorTestCases
        {
            get
            {
                yield return new TestCaseData(5, 3, 4);
                yield return new TestCaseData(5, 4, 1);
                yield return new TestCaseData(7, 2, 7);
                yield return new TestCaseData(10, 2, 5);
                yield return new TestCaseData(30, 6, 4);
                yield return new TestCaseData(5, 2, 3);
                yield return new TestCaseData(5, 6, 4);
                yield return new TestCaseData(2, 5, 2);
                yield return new TestCaseData(3, 5, 1);
                yield return new TestCaseData(7, 3, 4);
                yield return new TestCaseData(2, 4, 1);
                yield return new TestCaseData(21, 8, 9);
            }
        }

        [TestCaseSource(nameof(CrossedOutTestCases))]
        public void GetCrossedOutPersons_GetExpectedSequence(int n, int k, IEnumerable<int> expected)
        {
            var actual = GetCrossedOutPersons(n, k);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestCaseSource(nameof(SurvivorTestCases))]
        public void GetSurvivor_GetExpectedValue(int n, int k, int expected)
        {
            var actual = GetSurvivor(n, k);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetCrossedOutPersons_GetExpectedSequenceLength()
        {
            int size = 1_000_000;
            Assert.AreEqual(size - 1, GetCrossedOutPersons(size, 100).Count());
        }

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void GetCrossedOutPersons_Count_LessThanOne_ThrowArgumentException(int count) =>
            Assert.Throws<ArgumentException>(() => GetCrossedOutPersons(count, 1), $"{count} must be greater than 0.");

        [TestCase(10, 0)]
        [TestCase(10, -1)]
        public void GetCrossedOutPersons_CrossesOut_LessThanOne_ThrowArgumentException(int count, int crossedOut) =>
            Assert.Throws<ArgumentException>(() => GetCrossedOutPersons(count, crossedOut), $"{crossedOut} must be greater than 0.");

        [TestCase(0)]
        [TestCase(-1)]
        [TestCase(int.MinValue)]
        public void GetSurvivor_Count_LessThanOne_ThrowArgumentException(int count) =>
            Assert.Throws<ArgumentException>(() => GetSurvivor(count, 1), $"{count} must be greater than 0.");

        [TestCase(10, 0)]
        [TestCase(10, -1)]
        public void GetSurvivor_CrossesOut_LessThanOne_ThrowArgumentException(int count, int crossedOut) =>
            Assert.Throws<ArgumentException>(() => GetSurvivor(count, crossedOut), $"{crossedOut} must be greater than 0.");
    }
}
