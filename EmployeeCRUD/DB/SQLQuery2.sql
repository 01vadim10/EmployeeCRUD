CREATE TABLE [dbo].[Table] (
    [EmployeeID]  INT            NOT NULL IDENTITY,
    [FirstName]   NVARCHAR (100) NOT NULL,
    [Surname]     NVARCHAR (100) NOT NULL,
    [DateOfBirth] DATE           NOT NULL,
    [Salary]      DECIMAL (20)   NOT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);

