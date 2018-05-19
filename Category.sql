CREATE TABLE Category (
	id INT PRIMARY KEY,
	name NVARCHAR(255) NOT NULL
);

INSERT INTO Category 
VALUES  (1, N'Игрушки'),
		(2, N'Книги');

SELECT * FROM Category ORDER BY id;