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
            var fakeGateway = new Mock<ICreditCheckerGateway>();
            var sut = new CreditCardApplicationScorer(fakeGateway.Object);

            var application = new CreditCardApplication
            {
                ApplicantAgeInYears = 30,
                ApplicantName = "David"
            };
            sut.ScoreApplication(application);

            fakeGateway.Verify(x => x.HasGoodCreditHistory("David"), Times.Once());
        }

        [Test]
        public void ShouldAcceptCorrectAgedApplicantWithGoodCreditHistory()
        {

        }
    }
}
