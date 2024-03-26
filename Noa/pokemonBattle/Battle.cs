﻿using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Battle
{
    //make pokemonFromBall a var in here
    public List<Trainer> createTrainerClass(List<string> trainerNames)
    {
        //Give trainers their class
        Trainer trainer = new Trainer("name", new List<Pokeball>());
        Trainer trainer1 = new Trainer(trainerNames[0], new List<Pokeball>());
        Trainer trainer2 = new Trainer(trainerNames[1], new List<Pokeball>());
        List<Trainer> trainersClass = new List<Trainer> {trainer1, trainer2};
        return trainersClass;
    }

    public Trainer round(List<Trainer> trainersClass)
    {
        List<int> rounds = new List<int> { 0, 1, 2, 3, 4, 5, 6 };
        Trainer trainer = new Trainer("name", new List<Pokeball>());
        Charmander charmander = new Charmander("Charmander", "fire", "water");
        Squirtle squirtle = new Squirtle("Squirtle", "water", "leaf");
        Bulbasaur bulbasaur = new Bulbasaur("Bulbasaur", "grass", "fire");
        Pokeball pokeball = new Pokeball(charmander);
        Arena arena = new Arena();
        Pokemon prevWinner = null;
        Trainer winnerTrainer = null;

        //Round
        List<Trainer> winnerList = new List<Trainer>();
        Pokemon pokemonOutBall1 = null;
        Pokemon pokemonOutBall2 = null;
        int round = 1;

        //------DECIDE WHO THROWS------------------------------------------------------//
        while (trainersClass[0].belt.Count > 0 && trainersClass[1].belt.Count > 0)
        {
            arena.startRound(round);
            round++;
            if (winnerTrainer == trainersClass[0] && winnerTrainer == trainersClass[1])
            {
                if (prevWinner == pokemonOutBall1)
                {
                    Console.WriteLine(trainersClass[0].name + " throws a pokeball");
                    pokemonOutBall1 = trainersClass[0].throwPokeball();
                    pokemonOutBall1.battleCry();
                }
                else if (prevWinner == pokemonOutBall2)
                {
                    Console.WriteLine(trainersClass[1].name + " throws a pokeball");
                    pokemonOutBall2 = trainersClass[1].throwPokeball();
                    pokemonOutBall2.battleCry();
                }
            }
            else if (winnerTrainer == trainersClass[0])
            {
                Console.WriteLine(trainersClass[1].name + " throws a pokeball");
                pokemonOutBall2 = trainersClass[1].throwPokeball();
                pokemonOutBall2.battleCry();
            }
            else if (winnerTrainer == trainersClass[1])
            {
                Console.WriteLine(trainersClass[0].name + " throws a pokeball");
                pokemonOutBall1 = trainersClass[0].throwPokeball();
                pokemonOutBall1.battleCry();
            }
            else
            {
                Console.WriteLine(trainersClass[0].name + " throws a pokeball");
                pokemonOutBall1 = trainersClass[0].throwPokeball();
                pokemonOutBall1.battleCry();
                Console.WriteLine(trainersClass[1].name + " throws a pokeball");
                pokemonOutBall2 = trainersClass[1].throwPokeball();
                pokemonOutBall2.battleCry();
            }

            Pokemon winnerPokemon = decideWinner(pokemonOutBall1, pokemonOutBall2);

            //------WINNER ANNOUNCEMENT-----------------------------------------------------//
            if (winnerPokemon.nickName == pokemonOutBall1.nickName & winnerPokemon.nickName == pokemonOutBall2.nickName)
            {
                Console.WriteLine("Round is a draw");
                if (prevWinner == pokemonOutBall1)
                {
                    trainersClass[0].returnPokemon(pokemonOutBall1);
                    Console.WriteLine(trainersClass[0].name + " returns their pokeball");
                    winnerTrainer = trainersClass[1];
                }
                else if (prevWinner == pokemonOutBall2)
                {
                    trainersClass[1].returnPokemon(pokemonOutBall2);
                    Console.WriteLine(trainersClass[1].name + " returns their pokeball");
                    winnerTrainer = trainersClass[0];
                }
                else
                {
                    trainersClass[0].returnPokemon(pokemonOutBall1);
                    Console.WriteLine(trainersClass[0].name + " returns their pokeball");
                    trainersClass[1].returnPokemon(pokemonOutBall2);
                    Console.WriteLine(trainersClass[1].name + " returns their pokeball");
                }

            }
            else if (winnerPokemon == pokemonOutBall1)
            {
                Console.WriteLine(winnerPokemon.nickName + " wins!");
                trainersClass[1].returnPokemon(pokemonOutBall2);
                Console.WriteLine(trainersClass[1].name + " returns their pokeball");
                winnerTrainer = trainersClass[0];
            }
            else if (winnerPokemon == pokemonOutBall2)
            {
                Console.WriteLine(winnerPokemon.nickName + " wins!");
                trainersClass[0].returnPokemon(pokemonOutBall1);
                Console.WriteLine(trainersClass[0].name + " returns their pokeball");
                winnerTrainer = trainersClass[1];
            }
            prevWinner = winnerPokemon;
            winnerList.Add(winnerTrainer);
        }
        return winnerTrainer;
    }

    public Pokemon decideWinner(Pokemon pokemonOutBall1, Pokemon pokemonOutBall2)
    {
        if (pokemonOutBall1.strength == "fire" && pokemonOutBall2.strength == "grass" || pokemonOutBall1.strength == "grass" && pokemonOutBall2.strength == "fire")
        {
            if (pokemonOutBall1.strength == "fire")
            {
                Pokemon winner = pokemonOutBall1;
                return winner;
            }
            else
            {
                Pokemon winner = pokemonOutBall2;
                return winner;
            }
        }
        else if (pokemonOutBall1.strength == "grass" && pokemonOutBall2.strength == "water" || pokemonOutBall1.strength == "water" && pokemonOutBall2.strength == "grass")
        {
            if (pokemonOutBall1.strength == "grass")
            {
                Pokemon winner = pokemonOutBall1;
                return winner;
            }
            else
            {
                Pokemon winner = pokemonOutBall2;
                return winner;
            }
        }
        else if (pokemonOutBall1.strength == "fire" && pokemonOutBall2.strength == "water" || pokemonOutBall1.strength == "water" && pokemonOutBall2.strength == "fire")
        {
            if (pokemonOutBall1.strength == "water")
            {
                Pokemon winner = pokemonOutBall1;
                return winner;
            }
            else
            {
                Pokemon winner = pokemonOutBall2;
                return winner;
            }
        }
        else
        {
            Pokemon winner = pokemonOutBall1;
            return winner;
        }
    }
}