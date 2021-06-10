--1
CREATE PROCEDURE sp_Select_idFood
AS
BEGIN
	SELECT IdFood
	FROM Food
END
--2 // update so luong mon an khi them moi trong detail food
CREATE TRIGGER trg_numofFoodCombo ON ComboFoodDetail
AFTER INSERT AS
BEGIN
	UPDATE Combo
	SET NumberOfFoods = NumberOfFoods + (SELECT COUNT(a.IdCombo) FROM inserted a
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
END

--3 update so luong do uong khi them moi trong detail drink
CREATE TRIGGER trg_numofDrink On ComboDrinkDetail
AFTER INSERT AS
BEGIN
	UPDATE Combo
	SET NumberOfDinks = NumberOfDinks + (SELECT COUNT(a.IdCombo) FROM inserted a 
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
END
--4 update gia combo sau khi insert new food
ALTER TRIGGER trg_PriceCombo ON ComboFoodDetail
AFTER INSERT AS
BEGIN
	UPDATE Combo
	SET ComboPrice = ComboPrice + (SELECT SUM(a.Price) FROM inserted a
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
	JOIN inserted ON Combo.IdCombo = inserted.IdCombo
END
-- sau khi insert drink
CREATE TRIGGER trg_Price2Combo ON ComboDrinkDetail
AFTER INSERT AS
BEGIN
	UPDATE Combo
	SET ComboPrice = ComboPrice + (SELECT SUM(a.Price) FROM inserted a
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
	JOIN inserted ON Combo.IdCombo = inserted.IdCombo
END
--5 update so luong thuc an bang combo sau khi xoa Food
CREATE TRIGGER trg_deletefoodc ON  ComboFoodDetail
AFTER DELETE AS
BEGIN	
	UPDATE Combo
	SET NumberOfFoods = NumberOfFoods - (SELECT COUNT(a.IdCombo) FROM deleted a
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
	JOIN deleted ON Combo.IdCombo = deleted.IdCombo
END
-- update so luong do uong sau khi xoa drink	
ALTER TRIGGER trg_deletedrinkc ON  ComboDrinkDetail
AFTER DELETE AS
BEGIN	
	UPDATE Combo
	SET NumberOfDinks = NumberOfDinks - (SELECT COUNT(a.IdCombo) FROM deleted a
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
	JOIN deleted ON Combo.IdCombo = deleted.IdCombo
END

--6 Update gia Combo
-- sau khi xoa Food
CREATE TRIGGER trg_priceAfterDelete1 ON  ComboFoodDetail
AFTER DELETE AS
BEGIN	
	UPDATE Combo
	SET ComboPrice = ComboPrice - (SELECT SUM(a.Price) FROM deleted a
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
	JOIN deleted ON Combo.IdCombo = deleted.IdCombo
END
-- sau khi xoa drink
CREATE TRIGGER trg_priceAfterDelete2 ON  ComboDrinkDetail
AFTER DELETE AS
BEGIN	
	UPDATE Combo
	SET ComboPrice = ComboPrice - (SELECT SUM(a.Price) FROM deleted a
						WHERE a.IdCombo = Combo.IdCombo)
	FROM Combo
	JOIN deleted ON Combo.IdCombo = deleted.IdCombo
END




--8
--9

--10

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
ALTER PROCEDURE sp_Combo_Insert
	@id char(10),
	@name nvarchar(50),
	@numofperson int,
	@src varchar(500)
AS
BEGIN
	insert into Combo(IdCombo, ComboName, NumberOfPerson, ImgCombo)
	values (@id, @name, @numofperson, @src) 
END

