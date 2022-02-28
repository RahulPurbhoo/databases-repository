CREATE SCHEMA College;

USE College;

CREATE TABLE Student(
	Student_Number VARCHAR(100) NOT NULL,
    Student_FName VARCHAR(100)  NOT NULL,
    Student_Surname  VARCHAR(100)  NOT NULL,
    Alegbra  INT NOT NULL,
    Calculus  INT NOT NULL,
    Programming  INT NOT NULL,
    S_Databases  INT NOT NULL,
    PRIMARY KEY (Student_Number)
);

CREATE TABLE Grades(
	Student_Number VARCHAR(100) NOT NULL,
    Student_Average INT NOT NULL,
    Student_Grade VARCHAR(10) NOT NULL,
    FOREIGN KEY (Student_Number) REFERENCES Student(Student_Number)
);

INSERT INTO Student(Student_Number, Student_FName, Student_Surname, Alegbra, Calculus, Programming, S_Databases)
			 Values(01, 'Joe', 'Soap', 92, 78, 65, 67),
				   (02, 'Jane', 'Doe', 81, 79, 83, 89),
                   (03, 'Mary', 'Poppins', 63, 52, 65, 71),
                   (04, 'Mario', 'Rossi', 23, 42, 50, 44),
                   (05, 'John', 'Smith', 56, 67, 72, 72),
                   (06, 'Tom', 'Cruz', 81, 62, 53, 59),
                   (07, 'Jim', 'Beglin',  41, 48, 51, 53),
                   (08, 'Peter', 'Shmooks', 55, 55, 66, 58),
                   (09, 'Hans', 'Meier', 57, 87, 95, 64),
                   (10, 'Jackie', 'Brown', 97, 91, 86, 73);
    
SELECT * FROM Student;