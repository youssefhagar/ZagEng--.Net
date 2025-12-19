use ZagEngTasks;



create table Products(
	product_id int primary key,
	product_name varchar(20),
	supplier_id int
)

create table Suppliers(
	supplier_id int primary key,
	supplier_name varchar(20),
	country varchar(20)
)

alter table Products 
add constraint FK_Supp_Prod
foreign key (supplier_id)
References Suppliers(supplier_id)


INSERT INTO Suppliers (supplier_id, supplier_name, country)
VALUES
(1, 'Samsung', 'Korea'),
(2, 'Apple', 'USA'),
(3, 'Huawei', 'China');
INSERT INTO Products (product_id, product_name, supplier_id)
VALUES
(101, 'Galaxy S23', 1),
(102, 'iPhone 14', 2),
(103, 'Mate 50', 3);


-- =====================================

select P.product_name ,S.supplier_name
from Products P join Suppliers S
on P.product_id= S.supplier_id ;