USE [aspnet-TestigerTest-F344EAF5-7ADB-4D84-85E3-7486BDAC2704];

DELETE FROM TreatmentArticles;
DELETE FROM Treatments;
DELETE FROM Articles;
DELETE FROM People;

SET IDENTITY_INSERT People ON;

INSERT INTO People(PersonID, FirstName, LastName) VALUES(1, 'Hans', 'Hase');
INSERT INTO People(PersonID, FirstName, LastName) VALUES(2, 'Peter', 'Pelikan');
INSERT INTO People(PersonID, FirstName, LastName) VALUES(3, 'Maya', 'Maus');
INSERT INTO People(PersonID, FirstName, LastName) VALUES(4, 'Lars', 'Lurch');
INSERT INTO People(PersonID, FirstName, LastName) VALUES(5, 'Emil', 'Elefant');

SET IDENTITY_INSERT People OFF;

SET IDENTITY_INSERT Articles ON;

INSERT INTO Articles(ArticleID, ArticleName, Price) VALUES(1, 'Aspirin', '10.0');
INSERT INTO Articles(ArticleID, ArticleName, Price) VALUES(2, 'Globoli', '2.0');
INSERT INTO Articles(ArticleID, ArticleName, Price) VALUES(3, 'Placebo', '3.5');

SET IDENTITY_INSERT Articles OFF;

SET IDENTITY_INSERT Treatments ON;

INSERT INTO Treatments(TreatmentID, PatientID, DoctorID, Date) VALUES(1, 1, '46b95884-41cd-475d-925f-044efe7ee88f', GETDATE());
INSERT INTO Treatments(TreatmentID, PatientID, DoctorID, Date) VALUES(2, 1, '46b95884-41cd-475d-925f-044efe7ee88f', GETDATE());
INSERT INTO Treatments(TreatmentID, PatientID, DoctorID, Date) VALUES(3, 2, '46b95884-41cd-475d-925f-044efe7ee88f', GETDATE());
INSERT INTO Treatments(TreatmentID, PatientID, DoctorID, Date) VALUES(4, 2, '46b95884-41cd-475d-925f-044efe7ee88f', GETDATE());

SET IDENTITY_INSERT Treatments OFF;

SET IDENTITY_INSERT TreatmentArticles ON;

INSERT INTO TreatmentArticles(TreatmentArticleID, TreatmentID, ArticleID, Amount) VALUES(1, 1, 1, 1);
INSERT INTO TreatmentArticles(TreatmentArticleID, TreatmentID, ArticleID, Amount) VALUES(2, 1, 2, 2);
INSERT INTO TreatmentArticles(TreatmentArticleID, TreatmentID, ArticleID, Amount) VALUES(3, 2, 1, 1);
INSERT INTO TreatmentArticles(TreatmentArticleID, TreatmentID, ArticleID, Amount) VALUES(4, 3, 1, 2);
INSERT INTO TreatmentArticles(TreatmentArticleID, TreatmentID, ArticleID, Amount) VALUES(5, 4, 3, 3);

SET IDENTITY_INSERT TreatmentArticles OFF;

