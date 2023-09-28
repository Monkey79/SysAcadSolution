USE sysacad_db;
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    us_name VARCHAR(255) NOT NULL,
    us_password VARCHAR(255) NOT NULL,
    us_role VARCHAR(50) NOT NULL,
    us_entity_id INT NOT NULL
);

CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    st_name VARCHAR(255),
    st_surname VARCHAR(255),
    st_file INT,
    st_address VARCHAR(255),
    st_phone_number VARCHAR(20),
    st_email_account VARCHAR(255),
    st_change_password BOOLEAN
);

CREATE TABLE courses (
    id INT AUTO_INCREMENT PRIMARY KEY,
    cr_name VARCHAR(255),
    cr_code INT,
    cr_description VARCHAR(255),
    cr_maximum_quota INT
);