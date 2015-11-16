using NUnit.Framework;
using TicTacToe.Core;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class EngineTests
    {
        private GameEngine _gameEngine;

        [SetUp]
        public void SetupTest()
        {
            _gameEngine = new GameEngine();
        }

        [Test]
        public void WhenTheBoardIsEmptyTheGameIsATie()
        {
            //Arrainge
            var board = new string[3, 3] {{" ", " ", " "}, {" ", " ", " "}, {" ", " ", " "}};
            var expectedResult = " ";

            //Act
            var result = _gameEngine.GetWinner(board);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void IfIHaveThreeXAcrossTopRowThenXWins()
        {
            //Arrainge
            var board = new string[3, 3] { { "X", "X", "X" }, { " ", " ", " " }, { " ", " ", " " } };
            var expectedResult = "X";

            //Act
            var result = _gameEngine.GetWinner(board);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}