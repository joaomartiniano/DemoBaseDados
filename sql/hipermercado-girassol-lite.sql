-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               10.4.18-MariaDB - mariadb.org binary distribution
-- Server OS:                    Win64
-- HeidiSQL Version:             11.2.0.6213
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

-- Dumping structure for table hipermercadogirassol.categorias
CREATE TABLE IF NOT EXISTS `categorias` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Designacao` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;

-- Dumping data for table hipermercadogirassol.categorias: ~10 rows (approximately)
/*!40000 ALTER TABLE `categorias` DISABLE KEYS */;
INSERT INTO `categorias` (`ID`, `Designacao`) VALUES
	(1, 'Mercearia'),
	(2, 'Frescos'),
	(3, 'Bebidas'),
	(4, 'Lacticínios'),
	(5, 'Congelados'),
	(6, 'Bebé'),
	(7, 'Higiene e Beleza'),
	(8, 'Limpeza'),
	(9, 'Animais'),
	(10, 'Iogurtes');
/*!40000 ALTER TABLE `categorias` ENABLE KEYS */;

-- Dumping structure for table hipermercadogirassol.marcas
CREATE TABLE IF NOT EXISTS `marcas` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Designacao` varchar(100) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- Dumping data for table hipermercadogirassol.marcas: ~7 rows (approximately)
/*!40000 ALTER TABLE `marcas` DISABLE KEYS */;
INSERT INTO `marcas` (`ID`, `Designacao`) VALUES
	(1, 'CIF'),
	(2, 'Mistolin'),
	(3, 'Continente'),
	(4, 'Sonasol'),
	(5, 'Iglo'),
	(6, 'Bonduelle'),
	(7, 'Nestlé');
/*!40000 ALTER TABLE `marcas` ENABLE KEYS */;

-- Dumping structure for table hipermercadogirassol.produtos
CREATE TABLE IF NOT EXISTS `produtos` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Designacao` varchar(255) NOT NULL,
  `Preco` decimal(20,6) NOT NULL DEFAULT 0.000000,
  `Descricao` varchar(1000) DEFAULT NULL,
  `Volume` varchar(50) DEFAULT NULL,
  `Peso` varchar(50) DEFAULT NULL,
  `UnidadesStock` int(11) DEFAULT 0,
  `Marca_ID` int(11) DEFAULT NULL,
  `Categoria_ID` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;

-- Dumping data for table hipermercadogirassol.produtos: ~7 rows (approximately)
/*!40000 ALTER TABLE `produtos` DISABLE KEYS */;
INSERT INTO `produtos` (`ID`, `Designacao`, `Preco`, `Descricao`, `Volume`, `Peso`, `UnidadesStock`, `Marca_ID`, `Categoria_ID`) VALUES
	(1, 'Tira Gorduras Spray', 1.090000, NULL, '750ml', NULL, 20, 3, 8),
	(2, 'Tira Gorduras Perfumado', 2.790000, NULL, '545ml', NULL, 18, 2, 8),
	(3, 'Spray Desengordurante Brilhante', 3.990000, NULL, '500ml', NULL, 8, 4, 8),
	(4, 'Ervilha Primavera', 2.990000, NULL, NULL, 'Embalagem 800 gr', 300, 5, 5),
	(5, 'Ervilhas', 1.840000, NULL, NULL, 'Embalagem 400 gr', 53, 6, 5),
	(6, 'Iogurte Líquido Morango e Banana', 0.990000, NULL, NULL, 'Embalagem 350 gr', 13, 7, 10),
	(7, 'Iogurte Líquido Natural Açucarado', 1.350000, NULL, NULL, 'Embalagem 1 kg', 22, 3, 10);
/*!40000 ALTER TABLE `produtos` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
