CREATE PROCEDURE [dbo].[spPokemon_Get]
  @Id int
AS
begin
  select *
  from dbo.[Pokemon]
  WHERE Id = @Id;
end