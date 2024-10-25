using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises01
    {
        [Test]
        public void GivenANewCheckingAccount_WhenIDeposit200_ThenBalanceShouldBe200()
        {
            var account = new Account(AccountType.Checking);

            account.Deposit(200);

            // assertion that verifies that the resulting balance is 200.
            Assert.That(account.Balance, Is.EqualTo(200));

           // assertion that verifies that the resulting balance is greater than 199.
            Assert.That(account.Balance, Is.GreaterThan(199));
        }

        [Test]
        public void GivenANewSavingsAccount_WhenIDeposit200AndWithdraw100_ThenBalanceShouldBe100()
        {
            // initialize a new back account
            Account account = new Account(AccountType.Savings);

            // deposit 200 into the new account
            account.Deposit(200);

            // widthdraw 100 from the account
            account.Withdraw(100);

            // Assert that we have 100 left in the account
            Assert.That(account.Balance, Is.EqualTo(100));
        }

        [Test]
        public void Test_WidthdrawlOverAccountBalance()
        {
            // create new checking account
            Account account = new Account(AccountType.Checking);

            // deposit 100 into the account
            account.Deposit(100);

            // widthdraw 200 from the account
            account.Withdraw(200);

            // assert that the resulting balance is -100
            Assert.That(account.Balance, Is.EqualTo(-100));
        }
    }
}
