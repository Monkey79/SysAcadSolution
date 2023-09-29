USE sysacad_db;
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    us_name VARCHAR(255),
    us_password VARCHAR(255),
    us_role VARCHAR(50)
);

CREATE TABLE students (
    id INT AUTO_INCREMENT PRIMARY KEY,
    st_name VARCHAR(255),
    st_surname VARCHAR(255),
    st_file_number INT UNIQUE,
    st_address VARCHAR(255),
    st_phone_number VARCHAR(20),
    st_email_account VARCHAR(255),
    st_change_password BOOLEAN
);

CREATE TABLE payments (
    id INT AUTO_INCREMENT PRIMARY KEY,
    py_st_file_number INT,
    py_concept VARCHAR(255),
    py_amount INT,
    py_settled BOOLEAN,
    FOREIGN KEY (py_st_file_number) REFERENCES students(st_file_number)
);

CREATE TABLE courses (
    id INT AUTO_INCREMENT PRIMARY KEY,
    cr_name VARCHAR(255),
    cr_code INT UNIQUE,
    cr_description VARCHAR(255),
    cr_maximum_quota INT,
    cr_from TIMESTAMP,
    cr_until TIMESTAMP,
    cr_shift VARCHAR(2) 
);

CREATE TABLE registrations (
    id INT AUTO_INCREMENT PRIMARY KEY,
    rg_st_file_number INT,
    rg_cr_code INT,
    rg_subject VARCHAR(255),
    rg_creation_date DATE,
    rg_from TIMESTAMP,
    rg_until TIMESTAMP,
    rg_shift VARCHAR(2),
    FOREIGN KEY (rg_st_file_number) REFERENCES students(st_file_number),
    FOREIGN KEY (rg_cr_code) REFERENCES courses(cr_code)
);
