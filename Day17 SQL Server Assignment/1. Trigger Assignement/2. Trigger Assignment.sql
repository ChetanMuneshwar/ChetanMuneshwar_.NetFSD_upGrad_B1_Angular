-- =============== Assignment 2 – Prevent Deleting Students. ================

use Assignment_Edu_Domain

-- Create Trigger – trg_PreventStudentDelete

CREATE TRIGGER trg_PreventStudentDelete
ON Students
AFTER DELETE
AS
BEGIN
    IF EXISTS (
        SELECT * 
        FROM Enrollments 
        WHERE StudentID IN (SELECT StudentID FROM deleted)
    )
    BEGIN
        RAISERROR ('Student has course enrollments and cannot be deleted',16,1)
        ROLLBACK TRANSACTION
    END
END;

-- Deleting a Student With Enrollments
DELETE FROM Students
WHERE StudentID = 1;