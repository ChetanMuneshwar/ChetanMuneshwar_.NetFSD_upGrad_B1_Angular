-- =============== Assignment 1 – Audit Trigger for Students. ================

use Assignment_Edu_Domain

-- Create Audit Table 
CREATE TABLE StudentAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ActionType VARCHAR(20),
    ActionDate DATETIME
);

-- Create Trigger trg_StudentInsertAudit
CREATE TRIGGER trg_StudentInsertAudit
ON Students
AFTER INSERT
AS
BEGIN
    INSERT INTO StudentAudit (StudentID, ActionType, ActionDate)
    SELECT 
        StudentID,
        'INSERT',
        GETDATE()
    FROM inserted;
END;

-- Insert a Student
INSERT INTO Students (FirstName, LastName, Gender, DepartmentID, AdmissionDate)
VALUES ('Rahul', 'Mehta', 'M', 2, '2024-06-10');

-- Insert Multiple Students
INSERT INTO Students (FirstName, LastName, Gender, DepartmentID, AdmissionDate)
VALUES 
('Priya','Sharma','F',1,'2024-06-10'),
('Karan','Patel','M',3,'2024-06-10');
SELECT * FROM StudentAudit;