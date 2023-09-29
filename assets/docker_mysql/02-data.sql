USE sysacad_db;

INSERT INTO users (us_name, us_password, us_role)
VALUES
('user1', 'passuser1', 'admin'),
('12345', 'passstudent1', 'basic'),
('user2', 'passuser2', 'admin'),
('54321', 'passstudent2', 'basic'),
('user5', 'passuser5', 'admin'),
('67890', 'passstudent3', 'basic'); 

INSERT INTO students (st_name, st_surname, st_file_number, st_address, st_phone_number, st_email_account, st_change_password)
VALUES
('Student1', 'Surname1', 12345, 'Address1', '123-456-7890', 'student1@example.com', 1),
('Student2', 'Surname2', 54321, 'Address2', '987-654-3210', 'student2@example.com', 0),
('Student3', 'Surname3', 67890, 'Address3', '555-555-5555', 'student3@example.com', 1),
('Student4', 'Surname4', 98765, 'Address4', '444-444-4444', 'student4@example.com', 0),
('Student5', 'Surname5', 13579, 'Address5', '999-999-9999', 'student5@example.com', 1);

INSERT INTO payments (py_st_file_number, py_concept, py_amount, py_settled)
VALUES
(12345, 'Payment1', 500, 1),
(54321, 'Payment2', 600, 0),
(67890, 'Payment3', 450, 1),
(98765, 'Payment4', 700, 1),
(13579, 'Payment5', 550, 0);

INSERT INTO courses (cr_name, cr_code, cr_description, cr_maximum_quota, cr_from, cr_until, cr_shift)
VALUES
('Course1', 101, 'Description of Course 1', 30, '2023-01-01', '2023-02-01', 'M'),
('Course2', 102, 'Description of Course 2', 25, '2023-02-01', '2023-03-01', 'F'),
('Course3', 103, 'Description of Course 3', 20, '2023-03-01', '2023-04-01', 'N'),
('Course4', 104, 'Description of Course 4', 35, '2023-04-01', '2023-05-01', 'M'),
('Course5', 105, 'Description of Course 5', 28, '2023-05-01', '2023-06-01', 'F');

INSERT INTO registrations (rg_st_file_number, rg_cr_code, rg_subject, rg_creation_date, rg_from, rg_until, rg_shift)
VALUES
(12345, 101, 'regst_course_1', '2023-01-01', '2023-01-10', '2023-02-10', 'M'),
(54321, 102, 'regst_course_2', '2023-02-01', '2023-02-15', '2023-03-15', 'F'),
(67890, 103, 'regst_course_3', '2023-03-01', '2023-03-20', '2023-04-20', 'N'),
(98765, 104, 'regst_course_4', '2023-04-01', '2023-04-25', '2023-05-25', 'M'),
(13579, 105, 'regst_course_5', '2023-05-01', '2023-05-30', '2023-06-30', 'F');
