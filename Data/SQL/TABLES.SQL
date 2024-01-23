DROP TABLE IF EXISTS t_owner;
CREATE TABLE t_owner(
    owner_id serial PRIMARY KEY,
    owner_name varchar(50),
    email varchar(100)
);
DROP TABLE IF EXISTS t_restaurant;
CREATE TABLE t_restaurant(
    restaurant_id serial PRIMARY KEY,
    restaurant_name varchar(50),
    owner_id int,
    FOREIGN KEY (owner_id) REFERENCES t_owner(owner_id)
);