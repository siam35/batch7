CREATE DATABASE CustomersDB

CREATE TABLE Customer(
Id INT IDENTITY(1,1) PRIMARY KEY,
Code VARCHAR(4) UNIQUE NOT NULL,
Name VARCHAR(255) NOT NULL,
Address VARCHAR(255),
Contact VARCHAR(11) UNIQUE,
District_Id INT
FOREIGN KEY (District_Id) REFERENCES District(Id)
)

INSERT INTO Customer(Code,Name,Address,Contact,District_Id) VALUES ('1111','Siam','Banasree','01919333000',1)
INSERT INTO Customer(Code,Name,Address,Contact,District_Id) VALUES ('1131','Sakib','Banasree','01917335000',1)

SELECT * FROM Customer;

CREATE TABLE District(
Id INT IDENTITY(1,1) PRIMARY KEY,
Name VARCHAR(255) UNIQUE NOT NULL,

)

INSERT INTO District(Name) VALUES ('Dhaka')
INSERT INTO District(Name) VALUES ('Comilla')
INSERT INTO District(Name) VALUES ('Sylhet')
INSERT INTO District(Name) VALUES ('Barishal')

SELECT * FROM District

CREATE VIEW CustomerDetailsView
AS
SELECT c.Id,c.Code,c.Name,c.Address,c.Contact,c.District_Id, d.Name as District_Name FROM Customer as c LEFT JOIN District as d ON c.District_Id = d.Id

SELECT * FROM CustomerDetailsView

UPDATE Customer SET
Code ='2121', Name = 'Hasan',Address='Rampura', Contact = '11009977665', District_Id = 3 WHERE Id = 1

DELETE FROM Customer