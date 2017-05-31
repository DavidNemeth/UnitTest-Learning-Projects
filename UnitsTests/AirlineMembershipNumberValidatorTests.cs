using NUnit.Framework;
using PluralsightNunit;

namespace UnitsTests
{
    [TestFixture]
    public class AirlineMembershipNumberValidatorTests
    {
        [Test]
        public void ShouldValidateCorrectNumber()
        {
            var sut = new AirlineMembershipNumberValidator();

            var isValid = sut.ValidityOf("A1234567");

            Assert.That(isValid, Is.True);
        }
    }
}
