using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        /**
         * TODO: rewrite these three tests into a single, parameterized test.
         * You decide if you want to use [TestCase] or [TestCaseSource], but
         * I would like to know why you chose the option you chose afterwards.
         */
        [TestCase(100, 50, 50, TestName = "Deposit 100, Widthdraw 50, have 50 remaining")]
        [TestCase(1000, 1000, 0, TestName = "Deposit 1000, Widthdraw 1000, have 0 remaining")]
        [TestCase(250, 1, 249, TestName = "Deposit 250, Widthdraw 1, have 249 remaining")]


        [Test, TestCaseSource("AccountDepositWidthdrawlTestData")]
        public void Test_BalanceAfterDepositAndWidthdrawl (int first, int second, int expectedTotal)
        {
            Account account = new Account(AccountType.Checking);

            account.Deposit(first);
            account.Withdraw(second);

            Assert.That(account.Balance, Is.EqualTo(expectedTotal));
        }
        private static IEnumerable<TestCaseData> AccountDepositWidthdrawlTestData()
        {
            yield return new TestCaseData(100, 50, 50).
                SetName("Deposit 100, Widthdraw 50, have 50 remaining");
            yield return new TestCaseData(1000, 1000, 0).
                SetName("Deposit 1000, Widthdraw 1000, have 0 remaining");
            yield return new TestCaseData(250, 1, 249).
                SetName("Deposit 250, Widthdraw 1, have 249 remaining");
        }
    }
}
