create table login(
username nvarchar(200),
password nvarchar(200)
)
create table register(
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
	Address nvarchar(100),
    Password NVARCHAR(255) NOT NULL,
	Gender NVARCHAR(10) CHECK (Gender IN ('Male', 'Female')),
    DateOfBirth DATE NOT NULL,
    RegistrationDate DATETIME DEFAULT GETDATE(),
    CONSTRAINT UQ_Email UNIQUE (Email)
	)
	select * from register
	select * from login
	insert  into login
	values('priyanka', 'ghimire')
	