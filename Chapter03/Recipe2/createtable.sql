CREATE TABLE [dbo].[EmployeeInfo]
    (
        [PKEmployeeId] [bigint] IDENTITY(1,1) NOT NULL,
        [firstname] [varchar](50) NOT NULL,
        [lastname] [varchar](50) NULL,
        [email] [varchar](50) NOT NULL,
        [devicelist] [varchar](max) NULL,
        CONSTRAINT [PK_EmployeeInfo] PRIMARY KEY CLUSTERED
        (
            [PKEmployeeId] ASC
        )
    )