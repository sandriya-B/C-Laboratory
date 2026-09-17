CREATE DATABASE CollegeDB;
GO

USE CollegeDB;
GO

CREATE TABLE Student
(
    Id INT PRIMARY KEY,
    Name VARCHAR(50),
    Department VARCHAR(50)
);
GO

INSERT INTO Student VALUES
(1, 'Sandriya', 'IT'),
(2, 'Priya', 'CSE'),
(3, 'Arun', 'ECE');
GO