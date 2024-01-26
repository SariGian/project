
CREATE TABLE Address (
    [Id]       INT    IDENTITY (1, 1) NOT NULL,
    city NVARCHAR (100) not null,
    street NVARCHAR (100) not null,
    building   INT      NOT NULL,
    [AppartmentNum] INT    NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    
);
CREATE TABLE Workers (
    [Id]  INT    IDENTITY (1, 1) NOT NULL,
    FirstName NVARCHAR (100) not null,
    LastName NVARCHAR (100) not null,
    AddressId int  NOT NULL,
    TypeOfWorker NVARCHAR (100) not null,
    FOREIGN KEY ([AddressId]) REFERENCES [dbo].[address] ([Id])
);
ALTER TABLE Workers
add PRIMARY KEY CLUSTERED ([Id] ASC)


CREATE TABLE customers (
    [Id]  INT    IDENTITY (1, 1) NOT NULL,
    FirstName NVARCHAR (100) not null,
    LastName NVARCHAR (100) not null,
    AddressId int  NOT NULL,
    TypeOfWorker NVARCHAR (100) not null,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AddressId]) REFERENCES [dbo].[address] ([Id])
);

insert into address
values('Jerusalem','Yirmiahu',67,4),('BetShemesh','NaharHayarden',32,6),('Beytar','Haran',89,4),('BetShemesh','NaharHayarden',39,1),
('Jerusalem','MinchatYitzchak',25,4),('Beytar','Haran',34,6);

insert into workers
values('Shlomo','Levy',3,'Driver'),('Chaim','Heler',1,'Manager'),('Mendy','Frid',5,'Driver'),('Nechama','Segal',2,'Secretary')


alter table customers
drop column TypeOfWorker;

