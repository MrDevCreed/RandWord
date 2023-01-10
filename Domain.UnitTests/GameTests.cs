using FluentAssertions;
using RandWord;
using RandWord.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Domain.UnitTests
{
    public class GameTests
    {
        [Fact]
        public void GetNextCompeteterName_WithStartedGame_ShouldReturnNextName()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            { 
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            //Act
            string nextName = game.NextCompetitorName();

            //Assert
            nextName.Should().Be(competitotors.ElementAt(1).Name);
        }

        [Fact]
        public void GetNextCompeteterName_WithLastCompeteterTurn_ShouldReturnNextName()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();
            game.NextTurn();

            //Act
            string nextName = game.NextCompetitorName();

            //Assert
            nextName.Should().Be(competitotors.ElementAt(0).Name);
        }

        [Fact]
        public void GetNextCompeteterName_WithoutStatedGame_ShouldReturnNextName()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);

            //Act
            Action action = () => game.NextCompetitorName();

            //Assert
            action.Should().Throw<Exception>();
        }

        [Fact]
        public void NextTurn_WithStatedGame_ShouldReturnNextTurn()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            //Act
            Turn t = game.NextTurn();

            t.Competitotor.Should().Be(competitotors.ElementAt(1));
        }
        [Fact]
        public void NextTurn_WithoutStatedGame_ShouldThrowException()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);

            //Act
            Action act = () => game.NextTurn();

            act.Should().Throw<InvalidOperationException>();
        }
        [Fact]
        public void NextTurn_WithStartedGame_ShouldReturnNextRound()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            //Act
            game.NextTurn();
            game.NextTurn();
            game.NextTurn();
            game.NextTurn();
            Turn turn = game.NextTurn();

            turn.RoundNmber.Should().Be(2);
        }
        [Fact]
        public void AddCompetoitors_WithDuplicateInput_ShouldThrowException()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Amir", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            Action act = () => game.AddCompetitors(competitotors);
            

            act.Should().Throw<ArgumentException>();
        }
        [Fact]
        public void AddCompetoitors_WithDuplicateNameAlreadyExistsinGame_ShouldThrowException()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            Action act = () => game.AddCompetitors(competitotors);


            act.Should().Throw<ArgumentException>();
        }
        [Fact]
        public void AddCompetoitors_WithoutStarted_ShouldThrowException()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();
            Action act = () => game.AddCompetitors(competitotors);


            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void FindCompetitord_WithoutofList_ShouldReturnNull()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            var competitor = game.FindCompetitor("Amiryan");

            competitor.Should().BeNull();
        }

        [Fact]
        public void ChangeScore_ShouldChangeScoreAmirCompetitor()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            game.ChangeCompetitorScore("Amir",5);

            game.FindCompetitor("Amir").Score.Should().Be(5);
        }
        [Fact]
        public void FinishTurn_WithoutStarted_ShouldThrowException()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);

            Action act = () => game.FinishTurn(23,true);

            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void FinishTurn_WithFinishedAlready_ShouldThrowException()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            game.FinishTurn(23,true);
            Action act = () => game.FinishTurn(23, true);

            act.Should().Throw<InvalidOperationException>();
        }

        [Fact]
        public void FinishTurn_WithWrongSay_ShouldFinishTurn()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            game.FinishTurn(23, false);

            game.CurrentTurn.IsFinished.Should().Be(true);
        }

        [Fact]
        public void FinishTurn_WithCorrectSay_ShouldFinishTurn()
        {
            //Arrange
            Game game = new Game();
            List<Competitotor> competitotors = new List<Competitotor>()
            {
                new Competitotor("Hasan", true),
                new Competitotor("Amir", false),
                new Competitotor("Yaser", false)
            };
            game.AddCompetitors(competitotors);
            game.Start();

            game.FinishTurn(23, true);

            game.CurrentTurn.IsFinished.Should().Be(true);
        }
    }
}
