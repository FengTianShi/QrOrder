DROP TABLE IF EXISTS t_restaurant;
CREATE TABLE t_restaurant(
    restaurant_id bigserial PRIMARY KEY,
    restaurant_tel varchar(20),
    -- FOREIGN KEY (owner_id) REFERENCES t_owner(owner_id)
);
INSERT INTO t_restaurant(restaurant_tel)
VALUES('010-1234-5678');
INSERT INTO t_restaurant(restaurant_tel)
VALUES('010-1234-5679');
INSERT INTO t_restaurant(restaurant_tel)
VALUES('010-1234-5680');
INSERT INTO t_restaurant(restaurant_tel)
VALUES('010-1234-5681');
INSERT INTO t_restaurant(restaurant_tel)
VALUES('010-1234-5682');