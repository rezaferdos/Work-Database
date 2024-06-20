USE [Work-Database_ADVCS]
GO


--INSERT INTO dbo.Countries
--(
--    Name,
--    Code
--)
--VALUES
--(   N'IRAN', -- Name - nvarchar(max)
--    N'IRI'  -- Code - nvarchar(max)
--),
--(   N'USA', -- Name - nvarchar(max)
--    N'USA'  -- Code - nvarchar(max)
--),
--(   N'ITALY', -- Name - nvarchar(max)
--    N'IT'  -- Code - nvarchar(max)
--)


--SELECT * FROM dbo.Countries

--INSERT INTO dbo.Provinces
--(
--    Name,
--    CountryCountryID
--)
--VALUES
--(   N'Tehran', -- Name - nvarchar(max)
--    1    -- CountryCountryID - int
--),
--(   N'Shiraz', -- Name - nvarchar(max)
--    1    -- CountryCountryID - int
--),
--(   N'Miami', -- Name - nvarchar(max)
--    2    -- CountryCountryID - int
--),
--(   N'NY', -- Name - nvarchar(max)
--    2    -- CountryCountryID - int
--),
--(   N'Rome', -- Name - nvarchar(max)
--    3    -- CountryCountryID - int
--)

--SELECT * FROM dbo.Provinces

INSERT INTO dbo.Cities
(
    Name,
    ProvinceProvinceID
)
VALUES
(   N'x', -- Name - nvarchar(max)
    2    -- ProvinceProvinceID - int
),
(   N'x', -- Name - nvarchar(max)
    2    -- ProvinceProvinceID - int
),
(   N'y', -- Name - nvarchar(max)
    3    -- ProvinceProvinceID - int
),
(   N'y', -- Name - nvarchar(max)
    5    -- ProvinceProvinceID - int
),
(   N'r', -- Name - nvarchar(max)
    6    -- ProvinceProvinceID - int
)

SELECT * FROM dbo.person

DELETE FROM dbo.Provinces 
WHERE ProvinceID = 3

CREATE TABLE Person (PersonID INT PRIMARY KEY NOT NULL IDENTITY,	
					 PersonName NVARCHAR(50))
SELECT * FROM dbo.Person
CREATE TABLE LastDegree (ID INT PRIMARY KEY NOT NULL IDENTITY,	
					 Degree NVARCHAR(50),
					 PersonID INT NOT NULL)
GO 
ALTER TABLE dbo.LastDegree 
ADD CONSTRAINT FK_PersonID FOREIGN KEY (PersonID) REFERENCES dbo.Person(PersonID)


INSERT INTO dbo.Person
(
    PersonName
)
VALUES
(N'Reza'),(N'Ali'),(N'Sara') -- PersonName - nvarchar(50)

SELECT * FROM dbo.Person -- 22, 23, 24

INSERT INTO dbo.LastDegree
(
    Degree,
    PersonID
)
VALUES
(   N'Diploma', -- Degree - nvarchar(50)
    22    -- PersonID - int
),
(   N'Master', -- Degree - nvarchar(50)
    24    -- PersonID - int
),
(   N'Sikl', -- Degree - nvarchar(50)
    23    -- PersonID - int
),
(   N'Bachelor', -- Degree - nvarchar(50)
    22    -- PersonID - int
)

SELECT * FROM dbo.LastDegree
SELECT * FROM dbo.Person