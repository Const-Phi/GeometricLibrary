USE DemoShop;

CREATE TABLE CategoryProduct (
	product_id  INT FOREIGN KEY REFERENCES Product(id),
	category_id INT FOREIGN KEY REFERENCES Category(id)
);

INSERT INTO CategoryProduct
VALUES  (1, 1),
		(2, 1);

SELECT * FROM CategoryProduct;