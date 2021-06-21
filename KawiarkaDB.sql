CREATE database KawiarkaDB;

use KawiarkaDB;
CREATE TABLE transakcje (
    transakcjaid int IDENTITY(1,1) PRIMARY KEY,
    coffeetype varchar(25) NOT NULL,
    price int
);

use KawiarkaDB;	
INSERT INTO KawiarkaDB.transakcje (coffeetype, price)
VALUES ('Duża kawa', 7);
INSERT INTO KawiarkaDB.transakcje (coffeetype, price)
VALUES ('Mała kawa', 3);
INSERT INTO KawiarkaDB.transakcje (coffeetype, price)
VALUES ('Średnia kawa', 5);

use KawiarkaDB;
select * from transakcje;