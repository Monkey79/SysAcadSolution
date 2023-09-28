USE sysacad_db;
INSERT INTO users (us_name, us_password,us_role,us_entity_id) VALUES
('admin1', 'admin1','admin',001),
('user1', 'user1','basic',100);

INSERT INTO students (st_name, st_surname, st_file, st_address, st_phone_number, st_email_account, st_change_password) VALUES
('Estudiante1', 'Apellido1', 12345, 'Dirección1', '123-456-7890', 'estudiante1@example.com', 1),
('Estudiante2', 'Apellido2', 54321, 'Dirección2', '987-654-3210', 'estudiante2@example.com', 0),
('Estudiante3', 'Apellido3', 67890, 'Dirección3', '555-555-5555', 'estudiante3@example.com', 1),
('Estudiante4', 'Apellido4', 98765, 'Dirección4', '444-444-4444', 'estudiante4@example.com', 0),
('Estudiante5', 'Apellido5', 13579, 'Dirección5', '999-999-9999', 'estudiante5@example.com', 1);

INSERT INTO courses (cr_name, cr_code, cr_description, cr_maximum_quota) VALUES
('Curso1', 101, 'Descripción del Curso 1', 30),
('Curso2', 102, 'Descripción del Curso 2', 25),
('Curso3', 103, 'Descripción del Curso 3', 20),
('Curso4', 104, 'Descripción del Curso 4', 35),
('Curso5', 105, 'Descripción del Curso 5', 28);