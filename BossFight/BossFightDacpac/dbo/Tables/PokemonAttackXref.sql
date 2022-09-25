CREATE TABLE [dbo].[PokemonAttackXref]
(
  [PokemonAttackXredID] INT NOT NULL PRIMARY KEY, 
    [PokemonID] INT NOT NULL FOREIGN KEY REFERENCES Pokemon(Id),
    [AttackID] INT NOT NULL FOREIGN KEY REFERENCES Attacks(Id)
)
