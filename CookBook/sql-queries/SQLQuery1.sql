create database CookBookDB

use CookBookDB

create table Ingredients(

	Id int identity(1,1) primary key,
	Name nvarchar(50) not null,
	Weight decimal(18,2) not null,
	KcalPer100g decimal (18,2) not null,
	PricePer100g decimal (18,2) not null,
	Type nvarchar(50) not null
	
);

insert into Ingredients(Name, Weight, KcalPer100g, PricePer100g, Type)
values 
('mango', 1000, 80, 50, 'fruit'),
('peanut', 100, 90, 12, 'dried fruit'),
('pumpkin seed', 100, 70, 35, 'seed'),
('almond', 100, 73, 30, 'dried fruit'),
('sesame', 100, 70, 35, 'seed'),
('cashew nut', 100, 70, 35, 'dried fruit')

select * from Ingredients

create procedure InsertIngredientProcedure
	(@Name nvarchar(50), @Weight decimal(18,2), @KcalPer100g decimal (18,2), 
	@PricePer100g decimal (18,2), @Type nvarchar(50))
as 
begin
	insert into Ingredients(Name, Weight, KcalPer100g, PricePer100g, Type)
	values (@Name, @Weight, @KcalPer100g, @PricePer100g, @Type)
end

exec InsertIngredientProcedure 'milk', 1000, 100, 2.8, 'liquid'