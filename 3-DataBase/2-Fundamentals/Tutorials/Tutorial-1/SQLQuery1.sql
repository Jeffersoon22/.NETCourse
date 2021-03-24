/*
INSERT INTO Customer(Age, FirstName, LastName, Email, Phone)
VALUES(20, 'Nato', 'Japharidze', 'nato.japaridze.1@btu.edu.ge', 599321299) 

INSERT INTO Customer(Age, FirstName, LastName, Email, Phone)
VALUES( 22, 'Andrii', 'Turianskii', 'Andrii.Turianski@gmail.com' , 303467788) */

UPDATE Customer
SET FirstName = 'Vasya', LastName = 'Pupkin'
WHERE ID = 3;
