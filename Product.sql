USE DemoShop;

CREATE TABLE Product (
	id int PRIMARY KEY,
	name varchar(255) NOT NULL,
);

INSERT INTO Product
VALUES  (1, 'Ïטסעמכוע'),
		(2, 'Êףךכא'),
		(3, 'ÊÀÐÒÎØÊÀ');

SELECT * FROM Product ORDER BY id;
