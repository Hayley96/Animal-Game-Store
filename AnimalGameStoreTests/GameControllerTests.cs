using AnimalGameStore.Controller;
using AnimalGameStore.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace AnimalGameStoreTests
{
    public class GameControllerTests
    {
        private GameController gameController;
        private Mock<IGameControllerService>? _mockcontrollerService;
        [SetUp]
        public void Setup()
        {
            _mockcontrollerService = new Mock<IGameControllerService>();
            gameController = new GameController(_mockcontrollerService.Object);
        }

        [Test]
        public void GetFossilByName_Returns_CorrectFossil()
        {
            string name = "amber";

            var result = gameController!.GetFossilByName(name);

            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.TypeOf(typeof(ActionResult<string>)));
        }
    }
}