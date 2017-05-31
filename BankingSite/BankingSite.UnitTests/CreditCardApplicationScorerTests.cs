using Moq;
using NUnit.Framework;

namespace BankingSite.UnitTests
{
    [TestFixture]
    public class CreditCardApplicationScorerTests
    {
        [Test]
        public void ShouldDeclineUnderAgeApplicant()
        {
            var fakeGateway = new Mock<ICreditCheckerGateway>();
            var sut = new CreditCardApplicationScorer(fakeGateway.Object);

            var application = new CreditCardApplication { ApplicantAgeInYears = 20 };
            var result = sut.ScoreApplication(application);

            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldAskGatewayForCreditCheck()
        {

        }

        [Test]
        public void ShouldAcceptCorrectAgedApplicantWithGoodCreditHistory()
        {

        }
    }
}
