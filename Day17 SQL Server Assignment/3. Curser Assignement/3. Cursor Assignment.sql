--=============== Assignment 3 – Update Course Credits Using Cursor ================

use Assignment_Edu_Domain

-- Create Procedure sp_UpdateCourseCredits
CREATE PROCEDURE sp_UpdateCourseCredits
AS
BEGIN
    DECLARE @CourseID INT
    DECLARE @Credits INT

    DECLARE CourseCursor CURSOR FOR
    SELECT CourseID, Credits
    FROM Courses
    WHERE Credits < 3

    OPEN CourseCursor

    FETCH NEXT FROM CourseCursor INTO @CourseID, @Credits

    WHILE @@FETCH_STATUS = 0
    BEGIN
        UPDATE Courses
        SET Credits = Credits + 1
        WHERE CourseID = @CourseID

        FETCH NEXT FROM CourseCursor INTO @CourseID, @Credits
    END

    CLOSE CourseCursor
    DEALLOCATE CourseCursor

    PRINT 'Course credits updated successfully'
END


EXEC sp_UpdateCourseCredits