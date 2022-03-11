-- MySqlBackup.NET 2.3.4
-- Dump Time: 2021-10-07 09:35:24
-- --------------------------------------
-- Server version 8.0.26 MySQL Community Server - GPL


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of descripcion_venta
-- 

DROP TABLE IF EXISTS `descripcion_venta`;
CREATE TABLE IF NOT EXISTS `descripcion_venta` (
  `ID_PRD` int unsigned DEFAULT NULL,
  `ID_VENTA` int unsigned DEFAULT NULL,
  `CANTIDAD` int unsigned DEFAULT NULL,
  `SUBTOTAL` int unsigned DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table descripcion_venta
-- 

/*!40000 ALTER TABLE `descripcion_venta` DISABLE KEYS */;

/*!40000 ALTER TABLE `descripcion_venta` ENABLE KEYS */;

-- 
-- Definition of productos
-- 

DROP TABLE IF EXISTS `productos`;
CREATE TABLE IF NOT EXISTS `productos` (
  `ID_PRODUCTO` int NOT NULL AUTO_INCREMENT,
  `NOMBRE` varchar(30) DEFAULT NULL,
  `MARCA` varchar(30) DEFAULT NULL,
  `DESCRIPCION` text,
  `CODIGO_BARRAS` tinytext NOT NULL,
  `STOCK` int unsigned DEFAULT NULL,
  `PRECIO` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`ID_PRODUCTO`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table productos
-- 

/*!40000 ALTER TABLE `productos` DISABLE KEYS */;

/*!40000 ALTER TABLE `productos` ENABLE KEYS */;

-- 
-- Definition of usuario
-- 

DROP TABLE IF EXISTS `usuario`;
CREATE TABLE IF NOT EXISTS `usuario` (
  `id` int unsigned AUTO_INCREMENT NOT NULL,
  `nombre` varchar(30) DEFAULT NULL,
  `contraseña` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table usuario
-- 

/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;

/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

-- 
-- Definition of ventas
-- 

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE IF NOT EXISTS `ventas` (
  `ID` int unsigned NOT NULL AUTO_INCREMENT,
  `FECHA` date NOT NULL,
  `TOTAL` decimal(10,2) DEFAULT NULL,
  `VENDEDOR` int unsigned DEFAULT NULL,
  PRIMARY KEY (`ID`),
  KEY `VENDEDOR` (`VENDEDOR`),
  CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`VENDEDOR`) REFERENCES `usuario` (`id`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- 
-- Dumping data for table ventas
-- 

/*!40000 ALTER TABLE `ventas` DISABLE KEYS */;

/*!40000 ALTER TABLE `ventas` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2021-10-07 09:35:24
-- Total time: 0:0:0:0:281 (d:h:m:s:ms)
