using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;
using Moq;

namespace DemoCode.Tests
{
    public class EmailMessageBufferShould
    {
        [Fact]
        public void SendEmailToGateway_Manual_Moq()
        {
            // arrange
            var fixture = new Fixture();

            var mockGateway = new Mock<IEmailGateway>();

            var sut = new EmailMessageBuffer(mockGateway.Object);

            sut.Add(fixture.Create<EmailMessage>());

            // act
            sut.SendAll();

            // assert
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());
        }

        [Theory]
        [AutoMoqData]
        public void SendEmailToGatewaye_AutoMoq(
            EmailMessage message,
            [Frozen] Mock<IEmailGateway> mockGateway,
            EmailMessageBuffer sut)
        {
            // arrange
            sut.Add(message);

            // act
            sut.SendAll();

            // assert
            // no reference to the mock IEmailGateway that was automatically provided
            mockGateway.Verify(x => x.Send(It.IsAny<EmailMessage>()), Times.Once());
        }
    }
}
