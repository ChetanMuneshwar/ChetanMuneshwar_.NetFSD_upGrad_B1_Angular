-- =============== Assignment 1 – Display Student Names Using Cursor ================

use Assignment_Edu_Domain

-- Create Stored Procedure sp_DisplayStudentsCursor
CREATE PROCEDURE sp_DisplayStudentsCursor
AS
BEGIN
    DECLARE @StudentID INT
    DECLARE @StudentName VARCHAR(100)

    DECLARE StudentCursor CURSOR FOR
    SELECT StudentID, FirstName + ' ' + LastName
    FROM Students

    OPEN StudentCursor

    FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName

    WHILE @@FETCH_STATUS = 0
    BEGIN
        PRINT 'StudentID: ' + CAST(@StudentID AS VARCHAR) + 
              '  Name: ' + @StudentName

        FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName
    END

    CLOSE StudentCursor
    DEALLOCATE StudentCursor
END

-- Execute the Procedure
EXEC sp_DisplayStudentsCursor