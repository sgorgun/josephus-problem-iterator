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
                yield return new TestCaseData(
                    5,
                    3,
                    new int[] { 3, 1, 5, 2 });
                yield return new TestCaseData(
                    5,
                    4,
                    new int[] { 4, 3, 5, 2 });
                yield return new TestCaseData(
                    7,
                    2,
                    new int[] { 2, 4, 6, 1, 5, 3 });
                yield return new TestCaseData(
                    10,
                    2,
                    new[] { 2, 4, 6, 8, 10, 3, 7, 1, 9 });
                yield return new TestCaseData(
                    30,
                    6,
                    new[] { 6, 12, 18, 24, 30, 7, 14, 21, 28, 5, 15, 23, 2, 11, 22, 3, 16, 27, 10, 26, 13, 1, 20, 17, 9, 19, 29, 25, 8 });
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
            Assert.Throws<ArgumentException>(() => GetCrossedOutPersons(count, 1), "Count must be greater than 0.");

        [TestCase(1, 0)]
        [TestCase(1, -1)]
        [TestCase(10, 11)]
        public void GetCrossedOutPersons_Step_NotInRange_ThrowArgumentOutOfRangeException(int count, int step) =>
            Assert.Throws<ArgumentOutOfRangeException>(
                () => GetCrossedOutPersons(count, step), $"Step[ must int range [1, {count}].");
    }
}
