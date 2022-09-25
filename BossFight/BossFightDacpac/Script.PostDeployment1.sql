
INSERT INTO [dbo].[Pokemon] (Name, Health, Speed)
      VALUES
      ('Francisco', 10,5),
      ('Pikachu', 11, 15),
      ('Ditto', 5, 4),
      ('Bulbasaur', 15, 8),
      ('Eevee', 11,15),
      ('Mew', 10, 5),
      ('Metapod', 5, 1);

IF not exists (select 1 from dbo.Attacks)
begin
INSERT INTO dbo.Attacks (Name, Damage, Modifier)
  VALUES
  ('Stab', 1, 1),
  ('Kick',5,2),
  ('Punch',2,2),
  ('Bite',2,1),
  ('Roll',0,10),
  ('ElectroBall', 6, 1),
  ('QuickAttack',3, 4),
  ('Spark', 4, 1),
  ('Tackle',2 ,2),
  ('Thunder',3, 4),
  ('TailPunch',2, 2),
  ('Transform',0,0);
end

IF not exists (select 1 from dbo.PokemonAttackXref)
begin
INSERT INTO dbo.PokemonAttackXref (PokemonID, AttackID)
VALUES
(1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(1,7),
(2,6),
(2,7),
(2,8),
(2,9),
(2,10),
(2,11),
(3,12),
(4,9),
(4,7),
(5,7);
end