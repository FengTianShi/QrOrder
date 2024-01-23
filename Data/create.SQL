\c postgres;
SELECT
    pg_terminate_backend(pg_stat_activity.pid)
FROM
    pg_stat_activity
WHERE
    pg_stat_activity.datname = 'qrorder'
    AND pid <> pg_backend_pid();

DROP DATABASE IF EXISTS qrorder;

CREATE DATABASE qrorder;

\c qrorder;
CREATE TABLE t_owner(
    owner_id serial PRIMARY KEY,
    owner_name varchar(50),
    email varchar(100)
);

CREATE TABLE t_restaurant(
    restaurant_id serial PRIMARY KEY,
    restaurant_name varchar(50),
    owner_id int,
    FOREIGN KEY (owner_id) REFERENCES t_owner(owner_id)
);

