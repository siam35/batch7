CREATE TABLE Customer(
Id INT IDENTITY(1,1),
Name VARCHAR(30) UNIQUE,
Address VARCHAR(30),
Contact VARCHAR(11)
)

DROP TABLE Customer

SELECT * FROM Customer WHERE Name = 'Siam'

SELECT * FROM Customer

UPDATE Customer SET Name = 'Shamul', Address = 'Banasree', Contact='01521230822' WHERE Customer_ID = 1

INSERT INTO Customer(Name,Address,Contact) VALUES ('Siam','Rampura','01919302888')
INSERT INTO Customer(Name,Address,Contact) VALUES ('Sakib','Rampura','01919302888')

CREATE TABLE Orders(
Order_ID INT IDENTITY(1,1),
Customer_ID INT,
Items_ID INT,
Quantity INT,
TotalPrice FLOAT
)
DROP TABLE Orders

SELECT * FROM Orders

UPDATE _Order SET Customer_ID = 21, Items_id=3, Quantity=4 WHERE Order_ID = 1

CREATE TABLE Items(
Id INT IDENTITY(1,1),
Name VARCHAR(50) UNIQUE,
Price FLOAT
)
DROP TABLE Items
SELECT * FROM Items

UPDATE Items SET Name='Black',Price=120 WHERE Items_ID=2 

SELECT _Order.Order_ID, Customer.Name,Items.Name FROM _Order  JOIN Customer ON _Order.Customer_ID=Customer.Customer_ID JOIN Items ON _Order.Items_ID=Items.Items_ID WHERE Customer.Name='nazmul';
INSERT INTO Orders(Customer_ID,Items_ID,Quantity,TotalPrice) VALUES (22,3,5,(SELECT Price FROM Items WHERE Items_ID = Items_ID ))
INSERT INTO Orders (Customer_ID,Items_ID,Quantity,TotalPrice) VALUES (21,2,3,2*4)
INSERT INTO Orders (Customer_ID,Items_ID,Quantity,TotalPrice) VALUES (21,2,3,(SELECT Price FROM Items WHERE Id = 2)*2)


/*INSERT INTO Orders (Customer_ID,Items_ID,Quantity,TotalPrice) 
SELECT Customer.Customer_ID,Items.Items_ID,Orders.Quantity,(Orders.Quantity*Items.Price) 
FROM Orders LEFT JOIN Items ON Orders.Items_ID=Items.Items_ID LEFT JOIN Customer ON Orders.Customer_ID=Customer.Customer_ID WHERE Customer.Customer_ID=21 AND Items.Items_ID =2
*/






    INSERT INTO (Customer_ID,Items_ID,Quantity,TotalPrice) VALUES (NEW.Customer_ID,NEW.Items_ID.NEW_Quantity)
    ON DUPLICATE KEY UPDATE
    SET something_else = CONCAT('new thing ',NOW());
;



INSERT INTO Orders (Customer_ID,Items_ID,Quantity,TotalPrice) VALUES (21,1,3,0)

 create trigger Calc_TotalPrice AFTER INSERT(Customer_ID,Items_ID,Quantity,TotalPrice) ON Orders
    for each row
    begin
     UPDATE Orders SET TotalPrice = Orders.Quantity*Items.Price FROM Orders LEFT JOIN Items ON Orders.Items_ID=Items.Items_ID 
    end



SELECT * FROM Orders
SELECT * FROM Items
SELECT * FROM Customer

SELECT _Order.Order_ID,_Order.Quantity,Items.price, (_Order.Quantity*Items.price) AS Total,Items.Items_Name FROM _Order 
LEFT JOIN Items ON _Order.Items_ID = Items.Items_ID  


