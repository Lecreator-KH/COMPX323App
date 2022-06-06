drop table Person;
drop table Organizer;
drop table Player;
drop table Setting;
drop table Sport;
drop table Team;
drop table Venue;
drop table SportEvent;
drop table ViewingExperience;
drop table RunIn;
drop table Attends;
drop table Watches;

create table Person(
Username varchar(30),
Email varchar(50) not null,
Password varchar(30) not null,
FirstName varchar(30) not null,
LastName varchar(30) not null,

CONSTRAINT PKPerson PRIMARY KEY (Username),
CONSTRAINT emailCheck check (email LIKE '%_@_%.___%')
);

create table Organizer(
Username varchar(30),
Organization varchar(50) not null,
PhoneNumber varchar(11),

CONSTRAINT PKOrg PRIMARY KEY (Username),
CONSTRAINT FKOrg FOREIGN KEY (Username) REFERENCES Person ON DELETE CASCADE
);

create table Player(
Username varchar(30),
TeamID varchar(30),

CONSTRAINT PKPlayer PRIMARY KEY (Username),
CONSTRAINT FKPlayer FOREIGN KEY (Username) REFERENCES Person ON DELETE CASCADE,
CONSTRAINT FKTeamID FOREIGN KEY (TeamID) REFERENCES Team 
);
create table Setting(
SettingID varchar(30),

CONSTRAINT PKSettingID PRIMARY KEY (SettingID)
);

create table Sport(
Name varchar(30),
MinPlayer integer not null,
MaxPlayer integer not null,
RequiredSubstitute varchar(50),
SettingID varchar(30),

CONSTRAINT PKSport PRIMARY KEY (Name),
CONSTRAINT FKSetting foreign key(SettingID) references Setting(SettingID)
);

create table Team(
TeamID varchar(30),
Name varchar(30) not null,
TeamEmail varchar(50) not null,
PhoneNumber varchar(11),
Website varchar(50) not null,
Sport varchar(30),

CONSTRAINT PKTeam PRIMARY KEY (TeamID),
CONSTRAINT FKSport foreign key(Sport) references Sport(Name)
);

create table Venue(
Location varchar(50),

CONSTRAINT PKLocation PRIMARY KEY (Location)
);

create table SportEvent(
EventDate Date,
StartTime Date,
Location varchar(50),
EndTime Date,
Organizer varchar(30),
MainSponsor varchar(50) not null,
Description varchar(100),

CONSTRAINT PKSportEvent PRIMARY KEY (EventDate, StartTime, Location),
CONSTRAINT FKLocation FOREIGN KEY(Location) REFERENCES Venue(Location),
CONSTRAINT FKOrganizer FOREIGN KEY(Organizer) REFERENCES Organizer(Username)
)cluster hashCluster(Organizer);

create table ViewingExperience(
EventType varchar(30),

CONSTRAINT PKViewingExperience PRIMARY KEY (EventType)
);

create table RunIn(
EventDate date,
StartTime date,
Location varchar(50),
EventType varchar(30),

CONSTRAINT PKIn PRIMARY KEY (EventDate, StartTime, Location, EventType),
CONSTRAINT FKEventDate foreign key(EventDate, StartTime, Location) references SportEvent(EventDate, StartTime, Location),
CONSTRAINT FKEventType foreign key(EventType) references ViewingExperience(EventType)
);

create table Attends(
TeamID varchar(30),
EventDate date,
StartTime date,
Location varchar(50),

CONSTRAINT PKAttends PRIMARY KEY (TeamID, EventDate, StartTime, Location),
CONSTRAINT FKTeam foreign key(TeamID) references Team(TeamID),
CONSTRAINT FKEventDate2 foreign key(EventDate, StartTime, Location) references SportEvent(EventDate, StartTime, Location)
);

create table Watches(
Person varchar(30),
EventDate date,
StartTime date,
Location varchar(50),

CONSTRAINT PKWatches PRIMARY KEY (Person, EventDate, StartTime, Location),
CONSTRAINT FKPerson foreign key(Person) references Person(Username),
CONSTRAINT FKEventDate3 foreign key(EventDate, StartTime, Location) references SportEvent(EventDate, StartTime, Location)
);

Insert into Setting values('Indoor');
Insert into Setting values('Outdoor');

delete from watches where person like 'aaagynti72005'

Insert into watches values('aaagynti72005',26/06/11,5:22,'qoerhivbajh')

Insert into ViewingExperience values('In Person');
Insert into ViewingExperience values('Streaming Platform');

Select * From Person;
Select * From Organizer;
Select * From Player;
Select * From Setting;
Select * From Sport;
Select * From Team;
Select * From Venue;
Select * From SportEvent;
Select * From ViewingExperience;
Select * From RunIn;
Select * From Attends;
Select * From Watches;
Select eventdate, TO_CHAR(startTime , 'HH24:MI'), location, person From Watches;


-- Hash
-- B-Tree Index
Create Index btree on Person(firstname);
Drop index btree;

explain plan for
Select * from Person where firstname like 'nu%q%';

SELECT 
     PLAN_TABLE_OUTPUT 
FROM 
     TABLE(DBMS_XPLAN.DISPLAY());
-- Hash cluster
DROP table SportEventTest;
Drop cluster hashcluster;

create table SportEvent(
EventDate Date,
StartTime Date,
Location varchar(50),
EndTime Date,
Organizer varchar(30),
MainSponsor varchar(50) not null,
Description varchar(100),

CONSTRAINT PKSportEvent PRIMARY KEY (EventDate, StartTime, Location),
CONSTRAINT FKLocation FOREIGN KEY(Location) REFERENCES Venue(Location),
CONSTRAINT FKOrganizer FOREIGN KEY(Organizer) REFERENCES Organizer(Username)
)cluster hashCluster(Organizer);

Create cluster hashCluster (
    Organizer varchar(30))
    size 256 HASHKeys 100;

explain plan for
Select * from SportEvent where organizer = 'umtbverr90633';

SELECT 
     PLAN_TABLE_OUTPUT 
FROM 
     TABLE(DBMS_XPLAN.DISPLAY());
TRUNCATE table sport;
--Select * From Venue;
--Insert into venue values('Test 1 2 3');
--
--create table Test123(
--Location varchar(50),
--CONSTRAINT FKLocationTest FOREIGN KEY(Location) REFERENCES Venue(Location)
--)
--Drop table Test123
--Insert into Test123 values('108 Dallow Place')