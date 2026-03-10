-- =============== Assignment 3 – Safe Delete Procedure ================

use Assignment_Edu_Domain

-- Create Procedure sp_DeleteStudent
CREATE PROCEDURE sp_DeleteStudent
    @StudentID INT
AS
BEGIN
    BEGIN TRY

        DELETE FROM Students
        WHERE StudentID = @StudentID

        PRINT 'Student deleted successfully'

    END TRY

    BEGIN CATCH

        PRINT 'Error deleting student. Student may have enrollments.'

    END CATCH
END;

-- Delete Student with enrollments
EXEC sp_DeleteStudent 1;

-- Delete Student without enrollments
EXEC sp_DeleteStudent 25;