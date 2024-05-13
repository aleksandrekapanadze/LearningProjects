namespace DemoCode.Tests
{
    public class AnnotationDemos
    {
        [Fact]
        public void BasicString()
        {
            // arrange
            var fixture = new Fixture();

            var player = fixture.Create<PlayerCharacter>();

            // act and assert phases...
        }
    }
}
