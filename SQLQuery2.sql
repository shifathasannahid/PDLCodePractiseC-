/*

--Database Create

Create Database jobDB;


Use jobDB;

*/

--Create Department Table
/*
CREATE TABLE Department (
    Dept_id INT PRIMARY KEY,
    name VARCHAR(100)
);

*/


--Create Employee Table 
/*
CREATE TABLE Employee (
    Emp_Id INT PRIMARY KEY,
    Emp_name VARCHAR(100),
    Dept_id INT,
    
    FOREIGN KEY (Dept_id) REFERENCES Department(Dept_id)
);
*/

-- Department Table Data Insert
/*
INSERT INTO Department (Dept_id, name)
VALUES 
(1, 'HR'),
(2, 'IT'),
(3, 'Finance'),
(4, 'Marketing'),
(5, 'Sales');
*/

-- Employee Table Data Insert
/*
INSERT INTO Employee (Emp_Id, Emp_name, Dept_id)
VALUES
(101, 'Shifat', 1),
(102, 'Hasan', 2),
(103, 'Nahid', 3),
(104, 'Nadim', 4),
(105, 'Jahid', 5);
*/

--Inner join

/*
SELECT Employee.Emp_name, Department.name
FROM Employee
INNER JOIN Department
ON Employee.Dept_id = Department.Dept_id;
*/

--LEFT JOIN
/*
SELECT Employee.Emp_name, Department.name
FROM Employee
LEFT JOIN Department
ON Employee.Dept_id = Department.Dept_id;

*/

--Right join

SELECT Employee.Emp_name, Department.name 
FROM Employee
RIGHT JOIN Department
ON Employee.Dept_id = Department.Dept_id;  