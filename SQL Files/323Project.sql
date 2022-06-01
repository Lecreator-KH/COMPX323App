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

CONSTRAINT PKPlayer PRIMARY KEY (Username),
CONSTRAINT FKPlayer FOREIGN KEY (Username) REFERENCES Person ON DELETE CASCADE
);

create table Player(
Username varchar(30),
TeamID varchar(30),

CONSTRAINT PKOrg PRIMARY KEY (Username),
CONSTRAINT FKOrg FOREIGN KEY (Username) REFERENCES Person ON DELETE CASCADE,
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
<<<<<<< HEAD
Select eventdate, TO_CHAR(startTime , 'HH:MI'), location, person From Watches;

-- Hash
-- B-Tree Index
Create Index bTreeMaxplayer on Sport(Maxplayer);
Create Index bTreeMinplayer on Sport(Minplayer);

Drop index bTreeMaxplayer;
Drop index bTreeMinplayer;

Select * From Sport where minplayer > 1 and minplayer < 3;
Select * From Sport where maxplayer > 7 and maxplayer < 10;


-- Hash cluster
create table Team(
TeamID NUMBER(*,0),
Name varchar(30) not null,
TeamEmail varchar(50) not null,
PhoneNumber varchar(20),
Website varchar(50) not null,
Sport varchar(30),

CONSTRAINT FKSport foreign key(Sport) references Sport(Name)
) cluster hashCluster(TeamID);

DROP table Team;
Create cluster hashCluster (
    TeamID number(*,0))
    HASHKeys 100 Hash is TeamID
    size 256;
    
Drop cluster hashCluster;

Select * From Team Where (TeamID = 99);
=======
Select TO_CHAR(startTime, 'HH:MI') From Watches;

>>>>>>> 9e6455849451fa08cec13910a11ac780b59f5d0b




