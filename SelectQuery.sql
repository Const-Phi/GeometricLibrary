USE DemoShop;

SELECT p.Name AS [��� ��������], c.Name AS [��� ���������]
FROM Product AS p
LEFT OUTER JOIN CategoryProduct AS cp
ON p.id = cp.product_id
LEFT OUTER JOIN Category as c
ON cp.category_id = c.id;