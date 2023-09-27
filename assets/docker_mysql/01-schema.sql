USE sysacad_db;
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    us_name VARCHAR(255) NOT NULL,
    us_password VARCHAR(255) NOT NULL,
    us_role VARCHAR(50) NOT NULL,
    us_entity_id INT NOT NULL
);