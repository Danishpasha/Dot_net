--Write a Procedure supplying name information from the Person.Person table and accepting a filter for the first name. Alter the above 
--Store Procedure to supply Default Values if user does not enter any value.( Use AdventureWorks).

use AdventureWorks2008R2;

GO
Create procedure person.up_getnamesbytypes 
          @Type nchar(2)
as
Select firstname from person.person where persontype=@Type
Go

EXEC Person.up_getnamesbytype 'SP';
GO

ALTER PROCEDURE Person.up_getnamesbytype
	@Type nchar(2)='EM'
AS
Select Firstname From Person.Person WHERE PersonType=@Type
GO

EXEC Person.up_getnamesbytype;
GO