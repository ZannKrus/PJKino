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
-- Table structure for table `comments`
--

DROP TABLE IF EXISTS `comments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `comments` (
  `id` bigint unsigned NOT NULL AUTO_INCREMENT,
  `accounts_id` bigint NOT NULL,
  `films_id` bigint NOT NULL,
  `comment` text NOT NULL,
  `comment_rating` bigint DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `comments`
--

LOCK TABLES `comments` WRITE;
/*!40000 ALTER TABLE `comments` DISABLE KEYS */;
INSERT INTO `comments` VALUES (1,4,1,'Удивительный мир Пандоры и невероятные визуальные эффекты делают фильм Аватар незабываемым приключением.',NULL),(2,5,2,'Зрителей увлекает головокружительное количество поворотов сюжета и неожиданных разоблачений в фильме Крик.',NULL),(3,2,3,'Фильм Маска - это воплощение безудержного веселья, позитивной энергии и невероятной мимики Джима Керри.',NULL),(4,3,3,'Ни одна другая комедия не сравнится с Маской по своей оригинальности и выходкам главного героя.',NULL),(5,5,4,'Этот фильм показывает нам, что любовь, дружба и справедливость имеют огромную силу в борьбе с превратностями судьбы.',NULL),(6,5,6,'Уникальные персонажи и их противостояние создают динамичный и захватывающий сюжет фильма.',NULL),(7,2,6,'Отличный саундтрек и культовые актёры делают Хорошего плохого злого одним из самых популярных и известных западных фильмов.',NULL),(8,1,7,'Необыкновенные визуальные эффекты и гениальная работа актёров делают Титаник незабываемым киноопытом.',NULL),(9,5,8,'Этот фильм показывает нам настоящую значимость и ценность человеческой жизни в военное время и заставляет задуматься о смысле жертв и борьбы.',NULL),(10,3,10,'Великолепная анимация и прекрасные песни делают Гринч одним из самых любимых и зажигательных рождественских фильмов.',NULL),(11,6,1,'grehreje5tjetrhj',NULL),(12,6,1,'acwverbnetn',NULL),(13,6,1,'hejertjrjtrje',NULL),(14,6,1,'test',NULL);
/*!40000 ALTER TABLE `comments` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-22 13:42:34
