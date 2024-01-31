-- IMPORTANT
-- Please execute the following script after using: update-database
-- Passwords for all accounts is the same: 123456

-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: filmwebdb
-- ------------------------------------------------------
-- Server version	8.0.35

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Dumping data for table `aspnetroleclaims`
--

LOCK TABLES `aspnetroleclaims` WRITE;
/*!40000 ALTER TABLE `aspnetroleclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetroleclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `aspnetroles`
--

LOCK TABLES `aspnetroles` WRITE;
/*!40000 ALTER TABLE `aspnetroles` DISABLE KEYS */;
INSERT INTO `aspnetroles` VALUES (1,'User','USER',NULL);
INSERT INTO `aspnetroles` VALUES (2,'Admin','ADMIN',NULL);
/*!40000 ALTER TABLE `aspnetroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `aspnetuserclaims`
--

LOCK TABLES `aspnetuserclaims` WRITE;
/*!40000 ALTER TABLE `aspnetuserclaims` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserclaims` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `aspnetuserlogins`
--

LOCK TABLES `aspnetuserlogins` WRITE;
/*!40000 ALTER TABLE `aspnetuserlogins` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetuserlogins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `aspnetuserroles`
--

LOCK TABLES `aspnetuserroles` WRITE;
/*!40000 ALTER TABLE `aspnetuserroles` DISABLE KEYS */;
INSERT INTO `aspnetuserroles` VALUES (6,1);
INSERT INTO `aspnetuserroles` VALUES (7,1);
INSERT INTO `aspnetuserroles` VALUES (8,1);
INSERT INTO `aspnetuserroles` VALUES (9,1);
/*!40000 ALTER TABLE `aspnetuserroles` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `aspnetusers`
--

LOCK TABLES `aspnetusers` WRITE;
/*!40000 ALTER TABLE `aspnetusers` DISABLE KEYS */;
INSERT INTO `aspnetusers` VALUES (6,'Robert','Newman','Male','1980-04-10','2024-01-24 12:00:24.993241','ptl56384@omeie.com','PTL56384@OMEIE.COM','ptl56384@omeie.com','PTL56384@OMEIE.COM',1,'AQAAAAIAAYagAAAAEC0oSEh8cSxtYb5YZNNtHXftocaBP1NMJnPRwuK5uPAG2AOq5n/z84l1Gm0B/sYlBw==','NRKHHRGDDJ2NXPWMYWJVNALFJ5IDSB4C','31bb6b33-23f3-49ae-aa6e-1e9516cfbed4',NULL,0,0,NULL,1,0);
INSERT INTO `aspnetusers` VALUES (7,'Lisa','Smith','Female','2004-01-31','2024-01-25 14:16:30.715379','zib22848@zbock.com','ZIB22848@ZBOCK.COM','zib22848@zbock.com','ZIB22848@ZBOCK.COM',1,'AQAAAAIAAYagAAAAEPJVZJpvBEPp0sDxOv+OOu5Wz1+wgE3TW4IO1lge5ZBfqMmtj6eJPNKkQd3VmYtcoA==','MRXYJ5O37T3OJH6HQNDNW4R4NBFOVDRO','43fb1975-03c9-4f94-a8ff-b43d236a492b',NULL,0,0,NULL,1,0);
INSERT INTO `aspnetusers` VALUES (8,'Adam','Brown','Male','1970-01-01','2024-01-25 14:18:36.094233','klv38677@omeie.com','KLV38677@OMEIE.COM','klv38677@omeie.com','KLV38677@OMEIE.COM',1,'AQAAAAIAAYagAAAAEL7GwOYaXOPX/x2au9K8DP2id7qU6rQISt7tlmSMt7+yAopVRKgydDVGXMc0DltU/Q==','GAKND33OB436NM6D4KRQ3GLMKHJ2W4ID','516fa9af-4d10-42ad-8f21-42a09a5f00a0',NULL,0,0,NULL,1,0);
INSERT INTO `aspnetusers` VALUES (9,'Olivia','Williams','Female','1964-07-25','2024-01-31 01:14:41.479469','nel21797@nezid.com','NEL21797@NEZID.COM','nel21797@nezid.com','NEL21797@NEZID.COM',1,'AQAAAAIAAYagAAAAEL6upMJZuJQHuK9tHfUmqVapAOw0dyNQxuBThPH205fOqidhPAIFzyqTOaXC4ctE8w==','PWOVSUZ2IZWSPIB4FP7W43UFIXCVHKDG','0579cc5e-3a70-40ef-a76d-ed37ecaefc06',NULL,0,0,NULL,1,0);
/*!40000 ALTER TABLE `aspnetusers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `aspnetusertokens`
--

LOCK TABLES `aspnetusertokens` WRITE;
/*!40000 ALTER TABLE `aspnetusertokens` DISABLE KEYS */;
/*!40000 ALTER TABLE `aspnetusertokens` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `films`
--

LOCK TABLES `films` WRITE;
/*!40000 ALTER TABLE `films` DISABLE KEYS */;
INSERT INTO `films` VALUES (1,'Star Wars: Episode I','Star Wars: Episode I – The Phantom Menace is a 1999 American epic space opera film written and directed by George Lucas. It stars Liam Neeson, Ewan McGregor, Natalie Portman, Jake Lloyd, Ahmed Best, Ian McDiarmid, Anthony Daniels, Kenny Baker, Pernilla August and Frank Oz. It is the fourth film in the Star Wars film series, the first film of the prequel trilogy and the first chronological chapter of the \"Skywalker Saga\". Set 32 years before the original trilogy (13 years before the formation of the Galactic Empire), during the era of the Galactic Republic, the plot follows Jedi Master Qui-Gon Jinn and his apprentice Obi-Wan Kenobi as they try to protect Queen Padmé Amidala of Naboo in hopes of securing a peaceful end to an interplanetary trade dispute. Joined by Anakin Skywalker—a young slave with unusually strong natural powers of the Force—they simultaneously contend with the mysterious return of the Sith. The film was produced by Lucasfilm and distributed by 20th Century Fox.','1999-06-19','00:01:33.000000','http://localhost:5000/Static/Films/Posters/1.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/1.jpg','The Phantom Menace');
INSERT INTO `films` VALUES (2,'Star Wars: Episode II','Star Wars: Episode II – Attack of the Clones is a 2002 American epic space opera film directed by George Lucas and written by Lucas and Jonathan Hales. The sequel to The Phantom Menace (1999), it is the fifth film in the Star Wars film series and second chronological chapter of the \"Skywalker Saga\". The film stars Ewan McGregor, Natalie Portman, Hayden Christensen, Ian McDiarmid, Samuel L. Jackson, Christopher Lee, Anthony Daniels, Kenny Baker, Frank Oz, Temuera Morrison, Silas Carson, and Jimmy Smits.','2002-06-16','00:01:42.000000','http://localhost:5000/Static/Films/Posters/2.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/2.jpg','Attack of the Clones');
INSERT INTO `films` VALUES (3,'Star Wars: Episode III','Star Wars: Episode III – Revenge of the Sith is a 2005 American epic space opera film written and directed by George Lucas. It stars Ewan McGregor, Natalie Portman, Hayden Christensen, Ian McDiarmid, Samuel L. Jackson, Christopher Lee, Anthony Daniels, Kenny Baker, and Frank Oz. The sequel to The Phantom Menace (1999) and Attack of the Clones (2002), it is the sixth film in the Star Wars film series, the final installment in the Star Wars prequel trilogy, and third chronological chapter of the \"Skywalker Saga\". The film was the final movie in the Star Wars franchise that George Lucas worked on, with subsequent films being made without Lucas\' involvement following his selling of Lucasfilm to The Walt Disney Company.','2005-06-19','00:01:42.000000','http://localhost:5000/Static/Films/Posters/3.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/3.jpg','Revenge of the Sith');
INSERT INTO `films` VALUES (4,'Star Wars: Episode IV','Star Wars (retroactively retitled Star Wars: Episode IV – A New Hope) is a 1977 American epic space opera film written and directed by George Lucas, produced by Lucasfilm and distributed by 20th Century-Fox. It was the first film released in the Star Wars film series and the fourth chronological chapter of the \"Skywalker Saga\". Set \"a long time ago\" in a fictional universe where the galaxy is ruled by the tyrannical Galactic Empire, the story focuses on a group of freedom fighters known as the Rebel Alliance, who aim to destroy the Empire\'s newest weapon, the Death Star. When Rebel leader Princess Leia is apprehended by the Empire, Luke Skywalker acquires stolen architectural plans of the Death Star and sets out to rescue her while learning the ways of a metaphysical power known as \"the Force\" from Jedi Master Obi-Wan Kenobi. The cast includes Mark Hamill, Harrison Ford, Carrie Fisher, Peter Cushing, Alec Guinness, David Prowse, James Earl Jones, Anthony Daniels, Kenny Baker, and Peter Mayhew.','1977-06-25','00:01:21.000000','http://localhost:5000/Static/Films/Posters/4.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/4.jpg','A New Hope');
INSERT INTO `films` VALUES (5,'Star Wars: Episode V','The Empire Strikes Back (also known as Star Wars: Episode V – The Empire Strikes Back) is a 1980 American epic space opera film directed by Irvin Kershner from a screenplay by Leigh Brackett and Lawrence Kasdan, based on a story by George Lucas. The sequel to Star Wars (1977),[b] it is the second film in the Star Wars film series and the fifth chronological chapter of the \"Skywalker Saga\". Set three years after the events of Star Wars, the film recounts the battle between the malevolent Galactic Empire, led by the Emperor, and the Rebel Alliance, led by Princess Leia. Luke Skywalker trains to master the Force so he can confront the powerful Sith lord, Darth Vader. The ensemble cast includes Mark Hamill, Harrison Ford, Carrie Fisher, Billy Dee Williams, Anthony Daniels, David Prowse, Kenny Baker, Peter Mayhew, and Frank Oz.','1980-06-21','00:01:24.000000','http://localhost:5000/Static/Films/Posters/5.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/5.jpg','The Empire Strikes Back');
INSERT INTO `films` VALUES (6,'Star Wars: Episode VI','Return of the Jedi (also known as Star Wars: Episode VI – Return of the Jedi) is a 1983 American epic space opera film directed by Richard Marquand. The screenplay is by Lawrence Kasdan and George Lucas from a story by Lucas, who was also the executive producer. The sequel to Star Wars (1977)[a] and The Empire Strikes Back (1980), it is the third installment in the original Star Wars trilogy, the third film to be produced, and the sixth chronological film in the \"Skywalker Saga\". The film stars Mark Hamill, Harrison Ford, Carrie Fisher, Billy Dee Williams, Anthony Daniels, David Prowse, Kenny Baker, Peter Mayhew and Frank Oz.','1983-06-25','00:01:32.000000','http://localhost:5000/Static/Films/Posters/6.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/6.jpg','Return of the Jedi');
INSERT INTO `films` VALUES (7,'Star Wars: Episode VII','Star Wars: The Last Jedi (also known as Star Wars: Episode VIII – The Last Jedi) is a 2017 American epic space opera film written and directed by Rian Johnson. Produced by Lucasfilm and distributed by Walt Disney Studios Motion Pictures, it is the second installment of the Star Wars sequel trilogy, following The Force Awakens (2015), and the eighth episode of the nine-part \"Skywalker saga\". The film\'s ensemble cast includes Mark Hamill, Carrie Fisher, Adam Driver, Daisy Ridley, John Boyega, Oscar Isaac, Andy Serkis, Lupita Nyong\'o, Domhnall Gleeson, Anthony Daniels, Gwendoline Christie, Kelly Marie Tran, Laura Dern, and Benicio del Toro. The Last Jedi follows Rey as she seeks the aid of Luke Skywalker in hopes of turning the tide for the Resistance in the fight against Kylo Ren and the First Order while General Leia Organa, Finn, and Poe Dameron attempt to escape a First Order attack on the dwindling Resistance fleet. The film features the first posthumous film performance by Fisher, who died in December 2016, and the film is dedicated to her memory.','2015-12-18','00:01:38.000000','http://localhost:5000/Static/Films/Posters/7.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/7.jpg','The Force Awakens');
INSERT INTO `films` VALUES (8,'Star Wars: Episode VIII','Star Wars: The Last Jedi (also known as Star Wars: Episode VIII – The Last Jedi) is a 2017 American epic space opera film written and directed by Rian Johnson. Produced by Lucasfilm and distributed by Walt Disney Studios Motion Pictures, it is the second installment of the Star Wars sequel trilogy, following The Force Awakens (2015), and the eighth episode of the nine-part \"Skywalker saga\". The film\'s ensemble cast includes Mark Hamill, Carrie Fisher, Adam Driver, Daisy Ridley, John Boyega, Oscar Isaac, Andy Serkis, Lupita Nyong\'o, Domhnall Gleeson, Anthony Daniels, Gwendoline Christie, Kelly Marie Tran, Laura Dern, and Benicio del Toro. The Last Jedi follows Rey as she seeks the aid of Luke Skywalker in hopes of turning the tide for the Resistance in the fight against Kylo Ren and the First Order while General Leia Organa, Finn, and Poe Dameron attempt to escape a First Order attack on the dwindling Resistance fleet. The film features the first posthumous film performance by Fisher, who died in December 2016, and the film is dedicated to her memory.','2017-12-15','00:01:52.000000','http://localhost:5000/Static/Films/Posters/8.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/8.jpg','The Last Jedi');
INSERT INTO `films` VALUES (9,'Star Wars: Episode IX','Star Wars: The Rise of Skywalker (also known as Star Wars: Episode IX – The Rise of Skywalker) is a 2019 American epic space opera film produced, co-written, and directed by J. J. Abrams. Produced by Lucasfilm and Abrams\' production company Bad Robot Productions, and distributed by Walt Disney Studios Motion Pictures, it is the third installment of the Star Wars sequel trilogy, following The Force Awakens (2015) and The Last Jedi (2017), and the final episode of the nine-part \"Skywalker saga\".[a] Its ensemble cast includes Carrie Fisher,[b] Mark Hamill, Adam Driver, Daisy Ridley, John Boyega, Oscar Isaac, Anthony Daniels, Naomi Ackie, Domhnall Gleeson, Richard E. Grant, Lupita Nyong\'o, Keri Russell, Joonas Suotamo, Kelly Marie Tran, Ian McDiarmid, and Billy Dee Williams. Set one year after The Last Jedi, The Rise of Skywalker follows Rey, Finn, and Poe Dameron as they lead the Resistance\'s final stand against Supreme Leader Kylo Ren and the First Order, who are aided by the return of the Galactic Emperor, Palpatine.','2019-12-20','00:01:42.000000','http://localhost:5000/Static/Films/Posters/9.jpg','ScienceFiction','http://localhost:5000/Static/Films/Banners/9.jpg','The Rise of Skywalker');
/*!40000 ALTER TABLE `films` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `forums`
--

LOCK TABLES `forums` WRITE;
/*!40000 ALTER TABLE `forums` DISABLE KEYS */;
INSERT INTO `forums` VALUES (3,'lorem ipsum','2024-01-28 04:04:08.144467',8);
INSERT INTO `forums` VALUES (10,'dolor lorem ipsum','2024-01-28 04:04:36.340167',8);
INSERT INTO `forums` VALUES (15,'dolor lorem ipsum','2024-01-28 04:04:37.615889',8);
INSERT INTO `forums` VALUES (16,'dolor lorem ipsum','2024-01-28 04:04:37.770327',8);
INSERT INTO `forums` VALUES (17,'dolor lorem ipsum','2024-01-28 04:04:37.910198',8);
INSERT INTO `forums` VALUES (18,'dolor lorem ipsum','2024-01-28 04:04:38.051968',8);
INSERT INTO `forums` VALUES (19,'dolor lorem ipsum','2024-01-28 04:04:38.196756',8);
INSERT INTO `forums` VALUES (20,'dolor lorem ipsum','2024-01-28 04:04:38.337583',8);
INSERT INTO `forums` VALUES (21,'dolor lorem ipsum','2024-01-28 04:04:38.479836',8);
INSERT INTO `forums` VALUES (22,'dolor lorem ipsum','2024-01-28 04:04:38.613965',8);
INSERT INTO `forums` VALUES (23,'dolor lorem ipsum','2024-01-28 04:04:38.769382',8);
INSERT INTO `forums` VALUES (24,'dolor lorem ipsum','2024-01-28 04:04:38.920953',8);
INSERT INTO `forums` VALUES (25,'dolor lorem ipsum','2024-01-28 04:04:39.081725',8);
INSERT INTO `forums` VALUES (26,'dolor lorem ipsum','2024-01-28 04:04:39.432279',8);
INSERT INTO `forums` VALUES (27,'dolor lorem ipsum','2024-01-28 04:04:39.586190',8);
INSERT INTO `forums` VALUES (28,'dolor lorem ipsum','2024-01-28 04:04:39.740306',8);
INSERT INTO `forums` VALUES (29,'dolor lorem ipsum','2024-01-28 04:04:39.907883',8);
INSERT INTO `forums` VALUES (31,'dolor lorem ipsum','2024-01-28 04:04:40.426369',8);
INSERT INTO `forums` VALUES (35,'dolor lorem ipsum','2024-01-28 04:04:41.194941',8);
INSERT INTO `forums` VALUES (36,'dolor lorem ipsum','2024-01-28 04:04:41.347787',8);
INSERT INTO `forums` VALUES (37,'dolor lorem ipsum','2024-01-28 04:04:41.518036',8);
INSERT INTO `forums` VALUES (42,'Testowe forum','2024-01-29 16:54:24.615412',8);
INSERT INTO `forums` VALUES (43,'testowe forum','2024-01-29 16:55:08.530347',6);
INSERT INTO `forums` VALUES (44,'afafsasf','2024-01-31 01:10:44.305676',6);
INSERT INTO `forums` VALUES (45,'asfasfasf','2024-01-31 01:12:06.219669',8);
/*!40000 ALTER TABLE `forums` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `messages`
--

LOCK TABLES `messages` WRITE;
/*!40000 ALTER TABLE `messages` DISABLE KEYS */;
INSERT INTO `messages` VALUES (10,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,10);
INSERT INTO `messages` VALUES (15,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,15);
INSERT INTO `messages` VALUES (16,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,16);
INSERT INTO `messages` VALUES (17,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,17);
INSERT INTO `messages` VALUES (18,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,18);
INSERT INTO `messages` VALUES (19,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,19);
INSERT INTO `messages` VALUES (20,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,20);
INSERT INTO `messages` VALUES (21,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,21);
INSERT INTO `messages` VALUES (22,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,22);
INSERT INTO `messages` VALUES (23,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,23);
INSERT INTO `messages` VALUES (24,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,24);
INSERT INTO `messages` VALUES (25,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,25);
INSERT INTO `messages` VALUES (26,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,26);
INSERT INTO `messages` VALUES (27,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,27);
INSERT INTO `messages` VALUES (28,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,28);
INSERT INTO `messages` VALUES (29,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,29);
INSERT INTO `messages` VALUES (31,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,31);
INSERT INTO `messages` VALUES (35,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,35);
INSERT INTO `messages` VALUES (36,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,36);
INSERT INTO `messages` VALUES (37,'ahj as123kss adas hasd khha hasjkhd  hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-28 01:44:35.831160',8,37);
INSERT INTO `messages` VALUES (44,'pierwsza wiadomosc na tym forum','2024-01-28 01:44:35.831160',8,42);
INSERT INTO `messages` VALUES (45,'Initial message Initial message Initial message Initial message Initial message Initial message','2024-01-28 01:44:35.831160',6,43);
INSERT INTO `messages` VALUES (55,'ahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk','2024-01-29 22:37:23.894309',8,3);
INSERT INTO `messages` VALUES (59,'ahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdkahjksdas hasd khha hasjkhd hjashd j jahsdkjh kjas hdkjash djkhaskj jkdhasjkh dajk hdajkh kdahk jdhajkh kajh jkha j kahjdk\n\n\n','2024-01-30 00:59:08.594453',8,3);
INSERT INTO `messages` VALUES (60,'sadad','2024-01-31 01:08:19.832349',6,43);
INSERT INTO `messages` VALUES (61,'afdsfsdfs','2024-01-31 01:08:46.183922',6,43);
INSERT INTO `messages` VALUES (62,'asdfsaf','2024-01-31 01:09:33.699045',6,3);
INSERT INTO `messages` VALUES (63,'asfafafafaffhdf','2024-01-28 01:44:35.831160',6,44);
INSERT INTO `messages` VALUES (64,'asfasfasf','2024-01-28 01:44:35.831160',8,45);
INSERT INTO `messages` VALUES (65,'zsfasfa','2024-01-31 01:12:15.161964',8,44);
INSERT INTO `messages` VALUES (66,'sdfsdfsdf','2024-01-31 01:12:28.223757',8,44);
/*!40000 ALTER TABLE `messages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `personfilmpositions`
--

LOCK TABLES `personfilmpositions` WRITE;
/*!40000 ALTER TABLE `personfilmpositions` DISABLE KEYS */;
INSERT INTO `personfilmpositions` VALUES (1,'Actor',1,4);
INSERT INTO `personfilmpositions` VALUES (2,'Actor',1,5);
INSERT INTO `personfilmpositions` VALUES (3,'Actor',1,6);
INSERT INTO `personfilmpositions` VALUES (4,'Actor',1,7);
INSERT INTO `personfilmpositions` VALUES (5,'Actor',2,4);
INSERT INTO `personfilmpositions` VALUES (6,'Actor',2,5);
INSERT INTO `personfilmpositions` VALUES (7,'Actor',2,6);
INSERT INTO `personfilmpositions` VALUES (8,'Actor',2,7);
INSERT INTO `personfilmpositions` VALUES (9,'Actor',2,8);
INSERT INTO `personfilmpositions` VALUES (10,'Actor',2,9);
INSERT INTO `personfilmpositions` VALUES (11,'Actor',3,4);
INSERT INTO `personfilmpositions` VALUES (12,'Actor',3,5);
INSERT INTO `personfilmpositions` VALUES (13,'Actor',3,6);
INSERT INTO `personfilmpositions` VALUES (14,'Actor',3,7);
INSERT INTO `personfilmpositions` VALUES (15,'Actor',3,8);
INSERT INTO `personfilmpositions` VALUES (16,'Actor',4,1);
INSERT INTO `personfilmpositions` VALUES (17,'Actor',4,2);
INSERT INTO `personfilmpositions` VALUES (18,'Actor',4,3);
INSERT INTO `personfilmpositions` VALUES (19,'Actor',4,5);
INSERT INTO `personfilmpositions` VALUES (20,'Actor',4,6);
INSERT INTO `personfilmpositions` VALUES (21,'Actor',5,1);
INSERT INTO `personfilmpositions` VALUES (22,'Actor',5,2);
INSERT INTO `personfilmpositions` VALUES (23,'Actor',5,3);
INSERT INTO `personfilmpositions` VALUES (24,'Actor',6,4);
INSERT INTO `personfilmpositions` VALUES (25,'Actor',6,5);
INSERT INTO `personfilmpositions` VALUES (26,'Actor',6,6);
/*!40000 ALTER TABLE `personfilmpositions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `persons`
--

LOCK TABLES `persons` WRITE;
/*!40000 ALTER TABLE `persons` DISABLE KEYS */;
INSERT INTO `persons` VALUES (1,'Harrison','Ford','Male','American',185,'1964-07-13','consectetur libero id faucibus nisl tincidunt eget nullam non nisi est sit amet facilisis magna etiam tempor orci eu lobortis elementum nibh tellus molestie nunc non blandit massa enim nec dui nunc mattis enim ut tellus elementum sagittis vitae et leo duis ut diam quam nulla porttitor massa id neque aliquam vestibulum morbi blandit cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque elit eget gravida cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus mauris vitae ultricies leo integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas dui id ornare arcu odio ut sem nulla pharetra diam sit amet nisl suscipit adipiscing bibendum est ultricies integer quis auctor elit sed vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet cursus sit amet dictum sit amet justo donec enim diam vulputate ut pharetra sit amet aliquam id diam maecenas ultricies mi eget mauris pharetra et ultrices neque ornare aenean euismod elementum nisi quis eleifend quam adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum neque egestas congue quisque egestas diam in arcu cursus euismod quis viverra nibh cras pulvinar mattis nunc sed blandit libero volutpat sed cras ornare arcu dui vivamus arcu felis bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida dictum fusce ut placerat orci nulla pellentesque dignissim enim sit amet venenatis urna cursus eget nunc scelerisque viverra mauris in aliquam sem fringilla ut morbi tincidunt augue interdum','http://localhost:5000/Static/People/Portraits/1.jpg');
INSERT INTO `persons` VALUES (2,'Mark','Hamill','Male','American',175,'1951-09-25','consectetur libero id faucibus nisl tincidunt eget nullam non nisi est sit amet facilisis magna etiam tempor orci eu lobortis elementum nibh tellus molestie nunc non blandit massa enim nec dui nunc mattis enim ut tellus elementum sagittis vitae et leo duis ut diam quam nulla porttitor massa id neque aliquam vestibulum morbi blandit cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque elit eget gravida cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus mauris vitae ultricies leo integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas dui id ornare arcu odio ut sem nulla pharetra diam sit amet nisl suscipit adipiscing bibendum est ultricies integer quis auctor elit sed vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet cursus sit amet dictum sit amet justo donec enim diam vulputate ut pharetra sit amet aliquam id diam maecenas ultricies mi eget mauris pharetra et ultrices neque ornare aenean euismod elementum nisi quis eleifend quam adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum neque egestas congue quisque egestas diam in arcu cursus euismod quis viverra nibh cras pulvinar mattis nunc sed blandit libero volutpat sed cras ornare arcu dui vivamus arcu felis bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida dictum fusce ut placerat orci nulla pellentesque dignissim enim sit amet venenatis urna cursus eget nunc scelerisque viverra mauris in aliquam sem fringilla ut morbi tincidunt augue interdum','http://localhost:5000/Static/People/Portraits/2.jpg');
INSERT INTO `persons` VALUES (3,'Carrie','Fisher','Female','American',155,'1956-10-21','consectetur libero id faucibus nisl tincidunt eget nullam non nisi est sit amet facilisis magna etiam tempor orci eu lobortis elementum nibh tellus molestie nunc non blandit massa enim nec dui nunc mattis enim ut tellus elementum sagittis vitae et leo duis ut diam quam nulla porttitor massa id neque aliquam vestibulum morbi blandit cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque elit eget gravida cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus mauris vitae ultricies leo integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas dui id ornare arcu odio ut sem nulla pharetra diam sit amet nisl suscipit adipiscing bibendum est ultricies integer quis auctor elit sed vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet cursus sit amet dictum sit amet justo donec enim diam vulputate ut pharetra sit amet aliquam id diam maecenas ultricies mi eget mauris pharetra et ultrices neque ornare aenean euismod elementum nisi quis eleifend quam adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum neque egestas congue quisque egestas diam in arcu cursus euismod quis viverra nibh cras pulvinar mattis nunc sed blandit libero volutpat sed cras ornare arcu dui vivamus arcu felis bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida dictum fusce ut placerat orci nulla pellentesque dignissim enim sit amet venenatis urna cursus eget nunc scelerisque viverra mauris in aliquam sem fringilla ut morbi tincidunt augue interdum','http://localhost:5000/Static/People/Portraits/3.jpg');
INSERT INTO `persons` VALUES (4,'Ian','McDiarmid','Male','Scottish',178,'1944-08-11','consectetur libero id faucibus nisl tincidunt eget nullam non nisi est sit amet facilisis magna etiam tempor orci eu lobortis elementum nibh tellus molestie nunc non blandit massa enim nec dui nunc mattis enim ut tellus elementum sagittis vitae et leo duis ut diam quam nulla porttitor massa id neque aliquam vestibulum morbi blandit cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque elit eget gravida cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus mauris vitae ultricies leo integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas dui id ornare arcu odio ut sem nulla pharetra diam sit amet nisl suscipit adipiscing bibendum est ultricies integer quis auctor elit sed vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet cursus sit amet dictum sit amet justo donec enim diam vulputate ut pharetra sit amet aliquam id diam maecenas ultricies mi eget mauris pharetra et ultrices neque ornare aenean euismod elementum nisi quis eleifend quam adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum neque egestas congue quisque egestas diam in arcu cursus euismod quis viverra nibh cras pulvinar mattis nunc sed blandit libero volutpat sed cras ornare arcu dui vivamus arcu felis bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida dictum fusce ut placerat orci nulla pellentesque dignissim enim sit amet venenatis urna cursus eget nunc scelerisque viverra mauris in aliquam sem fringilla ut morbi tincidunt augue interdum','http://localhost:5000/Static/People/Portraits/4.jpg');
INSERT INTO `persons` VALUES (5,'Ewan','McGregor','Male','Scottish',177,'1971-03-31','consectetur libero id faucibus nisl tincidunt eget nullam non nisi est sit amet facilisis magna etiam tempor orci eu lobortis elementum nibh tellus molestie nunc non blandit massa enim nec dui nunc mattis enim ut tellus elementum sagittis vitae et leo duis ut diam quam nulla porttitor massa id neque aliquam vestibulum morbi blandit cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque elit eget gravida cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus mauris vitae ultricies leo integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas dui id ornare arcu odio ut sem nulla pharetra diam sit amet nisl suscipit adipiscing bibendum est ultricies integer quis auctor elit sed vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet cursus sit amet dictum sit amet justo donec enim diam vulputate ut pharetra sit amet aliquam id diam maecenas ultricies mi eget mauris pharetra et ultrices neque ornare aenean euismod elementum nisi quis eleifend quam adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum neque egestas congue quisque egestas diam in arcu cursus euismod quis viverra nibh cras pulvinar mattis nunc sed blandit libero volutpat sed cras ornare arcu dui vivamus arcu felis bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida dictum fusce ut placerat orci nulla pellentesque dignissim enim sit amet venenatis urna cursus eget nunc scelerisque viverra mauris in aliquam sem fringilla ut morbi tincidunt augue interdum','http://localhost:5000/Static/People/Portraits/5.jpg');
INSERT INTO `persons` VALUES (6,'Alec','Guinness','Male','English',178,'1914-04-02','consectetur libero id faucibus nisl tincidunt eget nullam non nisi est sit amet facilisis magna etiam tempor orci eu lobortis elementum nibh tellus molestie nunc non blandit massa enim nec dui nunc mattis enim ut tellus elementum sagittis vitae et leo duis ut diam quam nulla porttitor massa id neque aliquam vestibulum morbi blandit cursus risus at ultrices mi tempus imperdiet nulla malesuada pellentesque elit eget gravida cum sociis natoque penatibus et magnis dis parturient montes nascetur ridiculus mus mauris vitae ultricies leo integer malesuada nunc vel risus commodo viverra maecenas accumsan lacus vel facilisis volutpat est velit egestas dui id ornare arcu odio ut sem nulla pharetra diam sit amet nisl suscipit adipiscing bibendum est ultricies integer quis auctor elit sed vulputate mi sit amet mauris commodo quis imperdiet massa tincidunt nunc pulvinar sapien et ligula ullamcorper malesuada proin libero nunc consequat interdum varius sit amet mattis vulputate enim nulla aliquet porttitor lacus luctus accumsan tortor posuere ac ut consequat semper viverra nam libero justo laoreet sit amet cursus sit amet dictum sit amet justo donec enim diam vulputate ut pharetra sit amet aliquam id diam maecenas ultricies mi eget mauris pharetra et ultrices neque ornare aenean euismod elementum nisi quis eleifend quam adipiscing vitae proin sagittis nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum neque egestas congue quisque egestas diam in arcu cursus euismod quis viverra nibh cras pulvinar mattis nunc sed blandit libero volutpat sed cras ornare arcu dui vivamus arcu felis bibendum ut tristique et egestas quis ipsum suspendisse ultrices gravida dictum fusce ut placerat orci nulla pellentesque dignissim enim sit amet venenatis urna cursus eget nunc scelerisque viverra mauris in aliquam sem fringilla ut morbi tincidunt augue interdum','http://localhost:5000/Static/People/Portraits/6.jpg');
/*!40000 ALTER TABLE `persons` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping data for table `reviews`
--

LOCK TABLES `reviews` WRITE;
/*!40000 ALTER TABLE `reviews` DISABLE KEYS */;
INSERT INTO `reviews` VALUES (1,4.7,'Star Wars: The Empire Strikes Back\" stands as a pinnacle in cinematic history. Directed by Irvin Kershner, this sequel transcends its predecessor, delivering a darker, more nuanced narrative. The film expands the Star Wars universe, introducing iconic characters like Yoda and Lando Calrissian. The battle on the ice planet Hoth is a visual spectacle, showcasing groundbreaking special effects. The emotional depth of the characters is heightened, especially in the development of the relationship between Luke Skywalker and Darth Vader.','2024-01-01 01:01:01.000000',6,6,'Meh');
INSERT INTO `reviews` VALUES (3,7.2,'The narrative skillfully blends nostalgia with fresh storytelling, setting the stage for a new era in the galaxy far, far away. The Millennium Falcon\'s return, Rey\'s journey, and the mystery surrounding Luke Skywalker generate anticipation and excitement. The Force Awakens successfully reignites the Star Wars magic, combining thrilling action with character-driven storytelling, making it a worthy addition to the iconic franchise.','2024-01-26 21:30:20.143914',7,6,'Already seen better productions');
INSERT INTO `reviews` VALUES (20,10,'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.','2024-01-27 18:00:38.102007',8,6,'Excellent stuff!');
INSERT INTO `reviews` VALUES (21,4.3,'qwrafa','2024-01-31 01:07:12.464435',6,2,'asfasf');
/*!40000 ALTER TABLE `reviews` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-31  2:28:52
