--=============== Assignment 2 – Exam Marks Transaction (Complete Query) ================

use Assignment_Edu_Domain

CREATE PROCEDURE sp_RecordExamMarks
    @StudentID INT,
    @ExamID INT,
    @MarksObtained INT
AS
BEGIN
    BEGIN TRY
        
        -- Start Transaction
        BEGIN TRANSACTION

        -- Insert marks into Marks table
        INSERT INTO Marks (StudentID, ExamID, MarksObtained)
        VALUES (@StudentID, @ExamID, @MarksObtained)

        -- Update exam record
        UPDATE Exams
        SET ExamDate = GETDATE()
        WHERE ExamID = @ExamID

        -- Commit if both succeed
        COMMIT TRANSACTION

        PRINT 'Exam marks recorded successfully'

    END TRY

    BEGIN CATCH
        
        -- Rollback if error occurs
        ROLLBACK TRANSACTION

        PRINT 'Error occurred. Transaction rolled back.'

    END CATCH
END

EXEC sp_RecordExamMarks 1,1,85

EXEC sp_RecordExamMarks 1,100,90