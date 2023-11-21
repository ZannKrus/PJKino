-- MySQL dump 10.13  Distrib 8.0.34, for Win64 (x86_64)
--
-- Host: localhost    Database: new_schema
-- ------------------------------------------------------
-- Server version	8.0.34

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
-- Table structure for table `actors`
--

DROP TABLE IF EXISTS `actors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `actors` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `last_name` varchar(255) NOT NULL,
  `first_name` varchar(255) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `actors`
--

LOCK TABLES `actors` WRITE;
/*!40000 ALTER TABLE `actors` DISABLE KEYS */;
INSERT INTO `actors` VALUES (1,'Уортингтон','Сэм'),(2,'Салдана','Зои'),(3,'Уивер','Сигурни'),(4,'Лэнг','Стивен'),(5,'Родригес','Мишель'),(6,'Кэмпбелл','Нив'),(7,'Кокс','Кортни'),(8,'Аркетт','Дэвид'),(9,'Ульрих','Скит'),(10,'Лиллард','Мэттью'),(11,'Керри','Джим'),(12,'Диас','Кэмерон'),(13,'Ригерт','Питер'),(14,'Грин','Питер'),(15,'Ясбек','Эми'),(16,'Лоуренс','Дженнифер'),(17,'Хатчерсон','Джош'),(18,'Хемсворт','Лиам'),(19,'Харрельсон','Вуди'),(20,'Бэнкс','Элизабет'),(21,'Джонс','Джеймс Эрл'),(22,'Гловер','Дональд'),(23,'Эджиофор','Чиветель'),(24,'Оливер','Джон'),(25,'Кани','Джон'),(26,'Иствуд','Клинт'),(27,'Клиф','Ли Ван'),(28,'Уоллак','Илай'),(29,'Джуффре','Альдо'),(30,'Пистилли','Луиджи'),(31,'ДиКаприо','Леонардо'),(32,'Уинслет','Кейт'),(33,'Зейн','Билли'),(34,'Бейтс','Кэти'),(35,'Фишер','Фрэнсис'),(36,'Хэнкс','Том'),(37,'Сайзмор','Том'),(38,'Бёрнс','Эдвард'),(39,'Пеппер','Барри'),(40,'Голдберг','Адам'),(41,'Чо','Джон'),(42,'Сон','Сара'),(43,'Гоу','Алекс Джейн'),(44,'Лью','Меган'),(45,'Лау','Кайя Доун'),(46,'Камбербэтч','Бенедикт'),(47,'Сили','Кэмерон'),(48,'Джонс','Рашида'),(49,'Уильямс','Фаррелл'),(50,'О’Хэйр','Тристан');
/*!40000 ALTER TABLE `actors` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-11-21 18:11:56
