--=============== Assignment 3 – Department Transfer Transaction ================

use Assignment_Edu_Domain

CREATE PROCEDURE sp_TransferStudentDepartment
    @StudentID INT,
    @NewDepartmentID INT
AS
BEGIN
    BEGIN TRY

        BEGIN TRANSACTION

        -- Check if department exists
        IF NOT EXISTS (SELECT 1 FROM Departments WHERE DepartmentID = @NewDepartmentID)
        BEGIN
            RAISERROR('Department does not exist',16,1)
        END

        -- Update student's department
        UPDATE Students
        SET DepartmentID = @NewDepartmentID
        WHERE StudentID = @StudentID

        COMMIT TRANSACTION

        PRINT 'Student department transferred successfully'

    END TRY

    BEGIN CATCH

        ROLLBACK TRANSACTION

        PRINT 'Transfer failed. Transaction rolled back.'

    END CATCH
END

EXEC sp_TransferStudentDepartment 1,2

EXEC sp_TransferStudentDepartment 1,100