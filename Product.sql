USE DemoShop;

CREATE TABLE Product (
	id int PRIMARY KEY,
	name varchar(255) NOT NULL,
);

INSERT INTO Product
VALUES  (1, '��������'),
		(2, '�����'),
		(3, '��������');

SELECT * FROM Product ORDER BY id;
