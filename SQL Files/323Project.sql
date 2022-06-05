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
PhoneNumber varchar(20),

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
PhoneNumber varchar(20),
Website varchar(50) not null,
Sport varchar(30),

CONSTRAINT PKTeam PRIMARY KEY (TeamID),
CONSTRAINT FKSport foreign key(Sport) references Sport(Name)
);

create table Venue(
Location varchar(30),

CONSTRAINT PKLocation PRIMARY KEY (Location)
);

create table SportEvent(
EventDate Date,
StartTime Date,
Location varchar(30),
EndTime Date,
Organizer varchar(30),
MainSponsor varchar(50) not null,
Description varchar(100),

CONSTRAINT PKSportEvent PRIMARY KEY (EventDate, StartTime, Location),
CONSTRAINT FKLocation FOREIGN KEY(Location) REFERENCES Venue(Location),
CONSTRAINT FKOrganizer FOREIGN KEY(Organizer) REFERENCES Organizer(Username)
);

create table ViewingExperience(
EventType varchar(30),

CONSTRAINT PKViewingExperience PRIMARY KEY (EventType)
);

create table RunIn(
EventDate date,
StartTime date,
Location varchar(30),
EventType varchar(30),

CONSTRAINT PKIn PRIMARY KEY (EventDate, StartTime, Location, EventType),
CONSTRAINT FKEventDate foreign key(EventDate, StartTime, Location) references SportEvent(EventDate, StartTime, Location),
CONSTRAINT FKEventType foreign key(EventType) references ViewingExperience(EventType)
);

create table Attends(
TeamID varchar(30),
EventDate date,
StartTime date,
Location varchar(30),

CONSTRAINT PKAttends PRIMARY KEY (TeamID, EventDate, StartTime, Location),
CONSTRAINT FKTeam foreign key(TeamID) references Team(TeamID),
CONSTRAINT FKEventDate2 foreign key(EventDate, StartTime, Location) references SportEvent(EventDate, StartTime, Location)
);

create table Watches(
Person varchar(30),
EventDate date,
StartTime date,
Location varchar(30),

CONSTRAINT PKWatches PRIMARY KEY (Person, EventDate, StartTime, Location),
CONSTRAINT FKPerson foreign key(Person) references Person(Username),
CONSTRAINT FKEventDate3 foreign key(EventDate, StartTime, Location) references SportEvent(EventDate, StartTime, Location)
);

Insert into Setting values('Indoor');
Insert into Setting values('Outdoor');

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
Select eventdate, TO_CHAR(startTime , 'HH24:MI'), location, person From Watches;

Select eventdate, TO_CHAR(startTime , 'HH24:MI'), location From SportEvent where startTime like  TO_CHAR('08:32' , 'HH24:MI')
select USERNAME from Person where Username like 'ornkhjjn415'
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

create table SportEventTest(
EventDate Date,
StartTime Date,
Location varchar(30),
EndTime Date,
Organizer varchar(30),
MainSponsor varchar(50) not null,
Description varchar(100),

CONSTRAINT PKSportEventTest PRIMARY KEY (EventDate, StartTime, Location),
CONSTRAINT FKLocationTest FOREIGN KEY(Location) REFERENCES Venue(Location),
CONSTRAINT FKOrganizerTest FOREIGN KEY(Organizer) REFERENCES Organizer(Username)
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