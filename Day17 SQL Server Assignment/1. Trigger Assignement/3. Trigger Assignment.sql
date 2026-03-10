-- =============== Assignment 3 – Update Marks Trigger. ================

use Assignment_Edu_Domain

-- Create Audit Table
CREATE TABLE MarksAudit
(
    AuditID INT IDENTITY(1,1) PRIMARY KEY,
    StudentID INT,
    ExamID INT,
    OldMarks INT,
    NewMarks INT,
    UpdatedDate DATETIME
);

-- Create Trigger – trg_UpdateMarksAudit
CREATE TRIGGER trg_UpdateMarksAudit
ON Marks
AFTER UPDATE
AS
BEGIN
    INSERT INTO MarksAudit (StudentID, ExamID, OldMarks, NewMarks, UpdatedDate)
    SELECT 
        d.StudentID,
        d.ExamID,
        d.MarksObtained,
        i.MarksObtained,
        GETDATE()
    FROM deleted d
    JOIN inserted i
    ON d.MarkID = i.MarkID;
END;

-- Update Marks
UPDATE Marks
SET MarksObtained = 95
WHERE MarkID = 1;

select * from MarksAudit