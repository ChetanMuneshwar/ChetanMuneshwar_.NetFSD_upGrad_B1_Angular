-- =============== Assignment 2 – Calculate Total Marks Per Student ================

use Assignment_Edu_Domain

-- Create Procedure sp_CalculateStudentTotalMarks	
create PROCEDURE sp_CalculateStudentTotalMarks
AS
BEGIN
    DECLARE @StudentID INT
    DECLARE @StudentName VARCHAR(100)
    DECLARE @TotalMarks INT

    DECLARE StudentCursor CURSOR FOR
    SELECT StudentID, FirstName + ' ' + LastName
    FROM Students

    OPEN StudentCursor

    FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName

    WHILE @@FETCH_STATUS = 0
    BEGIN
        SELECT @TotalMarks = SUM(MarksObtained)
        FROM Marks
        WHERE StudentID = @StudentID

        PRINT 'Student: ' + @StudentName + 
              '  Total Marks: ' + CAST(ISNULL(@TotalMarks,0) AS VARCHAR)

        FETCH NEXT FROM StudentCursor INTO @StudentID, @StudentName
    END

    CLOSE StudentCursor
    DEALLOCATE StudentCursor
END

EXEC sp_CalculateStudentTotalMarks