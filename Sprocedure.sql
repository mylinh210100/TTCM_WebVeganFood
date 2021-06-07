--1
CREATE PROCEDURE sp_Select_Food
AS
BEGIN
	SELECT * FROM Food
END
--2
CREATE PROCEDURE sp_Select_DrinkAll
AS
BEGIN
	SELECT * FROM Drink
END
--3
CREATE PROCEDURE sp_View_DetailComboFood
AS
BEGIN
	SELECT * FROM ComboFoodDetail
END
--4
CREATE PROCEDURE sp_View_DetailComboDrink
AS
BEGIN
	SELECT * FROM ComboDrinkDetail
END
--5
CREATE PROCEDURE sp_Select_ComboAll
AS
BEGIN
	SELECT * FROM Combo
END
--6

--7
CREATE PROCEDURE sp_Select_Foundation
AS
BEGIN
	SELECT * FROM Foundation
END
--8
CREATE PROCEDURE sp_View_Cmt
AS
BEGIN
	SELECT * FROM Comment
END
--9
CREATE PROCEDURE sp_View_Customer
AS
BEGIN
	SELECT * FROM Customer
END
--10
CREATE PROCEDURE sp_View_Order
AS
BEGIN
	SELECT * FROM [Order]
END
--11
CREATE PROCEDURE sp_Food_Insert
	@id varchar(50),
	@name nvarchar(50),
	@price float,
	@material nvarchar(500),
	@src varchar(500)
AS
BEGIN
	insert into Food(IdFood, FoodName, FoodPrice, Foodmaterial, ImgFood)
	values (@id, @name, @price, @material, @src) 
END
--12
CREATE PROCEDURE sp_Drink_Insert
	@id varchar(50),
	@name nvarchar(50),
	@price float,
	@material nvarchar(50),
	@src varchar(500)
AS
BEGIN
	insert into Drink(IdDrink, DrinkName, DrinkPrice, Drinkmaterial, ImgDrink)
	values (@id, @name, @price, @material, @src) 
END
--13
CREATE PROCEDURE sp_Combo_Insert
	@id char(10),
	@name nvarchar(50),
	@price float,
	@numoffood int,
	@numofdrink int,
	@numofperson int,
	@src varchar(500)
AS
BEGIN
	insert into Combo(IdCombo, ComboName, ComboPrice, NumberOfFoods, NumberOfDinks, NumberOfPerson, ImgCombo)
	values (@id, @name, @price, @numoffood, @numofdrink, @numofperson, @src) 
END

