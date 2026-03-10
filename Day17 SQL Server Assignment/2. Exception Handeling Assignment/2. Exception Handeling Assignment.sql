-- =============== Assignment 2 – Marks Validation Procedure ================

use Assignment_Edu_Domain

-- Create Procedure sp_InsertMarks

CREATE PROCEDURE sp_InsertMarks
    @StudentID INT,
    @ExamID INT,
    @MarksObtained INT
AS
BEGIN
    IF @MarksObtained < 0 OR @MarksObtained > 100
    BEGIN
        RAISERROR ('Invalid Marks',16,1)
        RETURN
    END

    INSERT INTO Marks (StudentID, ExamID, MarksObtained)
    VALUES (@StudentID, @ExamID, @MarksObtained)

    PRINT 'Marks inserted successfully'
END;

-- Insert Valid Marks
EXEC sp_InsertMarks 1,1,85;

-- Insert Invalid Marks (>100)
EXEC sp_InsertMarks 1,1,120;