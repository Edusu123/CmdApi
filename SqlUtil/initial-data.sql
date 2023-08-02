select * from CommandItems;

INSERT INTO CommandItems(HowTo, Platform, CommandLine)
VALUES 
    ('Create a new Migration', 'Entity Framework Core Command Line', 'dotnet ef migrations add <name of migration>'),
    ('Apply Migration to DB (Update Database)', 'Entity Framework Core Command Line', 'dotnet ef database update'),
    ('Create a new Migration', 'Entity Framework Package Manager Console', 'add-migration name of migration'),
    ('Apply Migration to DB (Update Database)', 'Entity Framework Package Manager Console', 'update-database');
