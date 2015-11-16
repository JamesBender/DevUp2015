using NUnit.Framework;
using TicTacToe.Core;

namespace TicTacToe.UnitTests
{
    [TestFixture]
    public class TicTacToeEngineTests
    {
        private GameEngine _engine;

        [SetUp]
        public void SetupTest()
        {
            _engine = new GameEngine();
        }

        [Test]
        public void WhenBoardIsEmptyThenNoWinner()
        {
            //Arrange            
            var board = new string[3, 3] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
            var expectedResult = " ";

            //Act
            var result = _engine.GetWinner(board);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WhenTheBoardIsNullNoWinner()
        {
            //Arrange
            var expectedResult = " ";

            //Act
            var result = _engine.GetWinner(null);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WhenTheTopRowIsAllXTheWinnerIsX()
        {
            //Arrange
            var board = new string[3, 3] { { "X", "X", "X" }, { " ", " ", " " }, { " ", " ", " " } };
            var expectedResult = "X";

            //Act
            var result = _engine.GetWinner(board);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void WhenTheTopRowIsNotAllXTheWinnerIsX()
        {
            //Arrange
            var board = new string[3, 3] { { "X", "A", "B" }, { " ", " ", " " }, { " ", " ", " " } };
            var expectedResult = " ";

            //Act
            var result = _engine.GetWinner(board);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }
    }
}