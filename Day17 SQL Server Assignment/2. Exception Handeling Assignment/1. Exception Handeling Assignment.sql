-- =============== Assignment 1 – Insert Student Procedure with Exception Handling ================

use Assignment_Edu_Domain

-- Create Stored Procedure – sp_AddStudent
CREATE PROCEDURE sp_AddStudent
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @DepartmentID INT,
    @Gender CHAR(1),
    @AdmissionDate DATE
AS
BEGIN
    BEGIN TRY
        
        INSERT INTO Students (FirstName, LastName, DepartmentID, Gender, AdmissionDate)
        VALUES (@FirstName, @LastName, @DepartmentID, @Gender, @AdmissionDate)

        PRINT 'Student inserted successfully'

    END TRY

    BEGIN CATCH

        PRINT 'Error occurred while inserting student'

    END CATCH
END;

-- Insert Valid Student
EXEC sp_AddStudent 'Rahul', 'Sharma',1, 'M', '2024-06-10';

-- Insert Student with Invalid DepartmentID
EXEC sp_AddStudent 'Priya', 'Patel', 100, 'F', '2024-06-10';

SELECT * FROM Students;