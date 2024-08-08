-----고객 주문 정보 테이블
CREATE TABLE Customer(
	CustomerID NUMBER(5) PRIMARY KEY,
	Model VARCHAR2(20) ,
	Engine VARCHAR2(20) ,
	Color VARCHAR2(20) ,
	Options VARCHAR2(20)
);
-----시퀀스
CREATE SEQUENCE CUSTOMERID_SEQ
START WITH 1
INCREMENT BY 1
NOCACHE;
---------가격표
select*FROM CARPRICE;
DROP TABLE CarPrice;
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k3', '1.6 가솔린', '스탠다드', '18,250,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k3', '1.6 가솔린', '노블레스', '21,510,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k3', '1.6 가솔린', '시그니처', '25,070,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k5', '2.0 가솔린', '스탠다드', '27,840,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k5', '2.0 가솔린', '노블레스', '31,350,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k5', '2.0 가솔린', '시그니처', '34,470,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k5', '2.0 LPi', '스탠다드', '28,530,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k5', '2.0 LPi', '노블레스', '32,140,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k5', '2.0 LPi', '시그니처', '34,620,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k8', '3.5 가솔린', '스탠다드', '36,990,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k8', '3.5 가솔린', '노블레스', '39,660,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k8', '3.5 가솔린', '시그니처', '42,980,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k8', '3.5 LPi ', '스탠다드', '32,990,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k8', '3.5 LPi ', '노블레스', '37,510,000');
INSERT INTO CarPrice (CARMODEL, Carengine, caroptions, price) VALUES ('k8', '3.5 LPi ', '시그니처', '45,370,000');
