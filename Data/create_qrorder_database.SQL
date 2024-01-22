\c postgres;
SELECT pg_terminate_backend (pg_stat_activity.pid)
FROM pg_stat_activity
WHERE pg_stat_activity.datname = 'qrorder' AND pid <> pg_backend_pid();

DROP DATABASE IF EXISTS qrorder;
CREATE DATABASE qrorder;
\c qrorder;

CREATE TABLE t_owner (
    owner_id SERIAL PRIMARY KEY,
    owner_name VARCHAR(50),
    email VARCHAR(100)
);