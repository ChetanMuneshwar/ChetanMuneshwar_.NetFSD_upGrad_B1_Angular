--=============== Assignment 1 – Student Enrollment Transaction ================

use Assignment_Edu_Domain

-- Create Stored Procedure sp_EnrollStudentTransaction
CREATE PROCEDURE sp_EnrollStudentTransaction
    @StudentID INT,
    @CourseID INT
AS
BEGIN
    BEGIN TRY

        BEGIN TRANSACTION

        INSERT INTO Enrollments (StudentID, CourseID)
        VALUES (@StudentID, @CourseID)

        COMMIT TRANSACTION

        PRINT 'Student enrolled successfully'

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION

        PRINT 'Enrollment failed. Transaction rolled back.'

    END CATCH
END

-- Enroll Student in Course (Successful Case)
EXEC sp_EnrollStudentTransaction 3, 2

-- Test Failure Scenario
EXEC sp_EnrollStudentTransaction 3, 100;

SELECT * FROM Enrollments;