-- --------------------------------------------------------
-- Host:                         database-1.camnos0tv0v7.us-east-1.rds.amazonaws.com
-- Versión del servidor:         8.0.23 - Source distribution
-- SO del servidor:              Linux
-- HeidiSQL Versión:             11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para MatchBook
CREATE DATABASE IF NOT EXISTS `MatchBook` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `MatchBook`;

-- Volcando estructura para tabla MatchBook.biblio
CREATE TABLE IF NOT EXISTS `biblio` (
  `email` varchar(40) NOT NULL,
  `titulo` varchar(40) NOT NULL,
  `contenido` mediumtext NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla MatchBook.biblio: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `biblio` DISABLE KEYS */;
INSERT INTO `biblio` (`email`, `titulo`, `contenido`) VALUES
	('pitomorango@gmail.com', 'Estanis', 'apasudfpoasdfpoasdfpaasdfasddfsodifuasdpofiuasdpofuasdfopasdflkjasdhf'),
	('pitomorango@gmail.com', 'Cervantes', 'aosiifjañsdfjasñdlfjasñdflkjasdñfljkasdfñlajsdfñalsdjkfasdñlkf'),
	('pitomorango@gmail.com', 'Juan', 'aossdfgiifjañsdfjasñdlfjasñdflkjasdñfljkasdfñlajsdfñalsdjkfasdñlasdfasdfkf');
/*!40000 ALTER TABLE `biblio` ENABLE KEYS */;

-- Volcando estructura para tabla MatchBook.libro
CREATE TABLE IF NOT EXISTS `libro` (
  `id_libro` int NOT NULL AUTO_INCREMENT,
  `titulo` varchar(25) NOT NULL,
  `autor` varchar(25) NOT NULL,
  `paginas` int NOT NULL,
  `contenido_texto` varchar(500) NOT NULL,
  `num_likes` int NOT NULL,
  `id_usuario_fk` int NOT NULL,
  PRIMARY KEY (`id_libro`),
  KEY `fk_id_usuario` (`id_usuario_fk`),
  CONSTRAINT `fk_id_usuario` FOREIGN KEY (`id_usuario_fk`) REFERENCES `usuario` (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla MatchBook.libro: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `libro` DISABLE KEYS */;
INSERT INTO `libro` (`id_libro`, `titulo`, `autor`, `paginas`, `contenido_texto`, `num_likes`, `id_usuario_fk`) VALUES
	(2, 'Cervantes', ' Perro', 1, 'aosiifjañsdfjasñdlfjasñdflkjasdñfljkasdfñlajsdfñalsdjkfasdñlkf', 0, 1),
	(3, 'Cervantes', ' Perro', 1, 'aosiifjañsdfjasñdlfjasñdflkjasdñfljkasdfñlajsdfñalsdjkfasdñlkf', 0, 1),
	(4, 'Cervantes', ' Perro', 1, 'aossdfgiifjañsdfjasñdlfjasñdflkjasdñfljkasdfñlajsdfñalsdjkfasdñlkf', 1, 1),
	(5, 'Juan', ' Perro', 1, 'aossdfgiifjañsdfjasñdlfjasñdflkjasdñfljkasdfñlajsdfñalsdjkfasdñlasdfasdfkf', 0, 1),
	(6, 'Juan', ' Perrito', 1, 'pasudfpoasdfpoasdfpasodifuasdpofiuasdpofuasdfopasdflkjasdhf', 0, 1),
	(7, 'Juan', ' Perrito', 1, 'pasudfpoasdfpoasdfpaasdfasddfsodifuasdpofiuasdpofuasdfopasdflkjasdhf', 0, 1),
	(8, 'Juan', ' Perrito', 1, 'apasudfpoasdfpoasdfpaasdfasddfsodifuasdpofiuasdpofuasdfopasdflkjasdhf', 0, 1),
	(9, 'Estanis', ' Perrito', 1, 'apasudfpoasdfpoasdfpaasdfasddfsodifuasdpofiuasdpofuasdfopasdflkjasdhf', 1, 1),
	(10, 'Estanis', ' xd', 1, 'apasudfpoasdfpoasdfpaasdfasddfsodifuasdpofiuasdpofuasdfopasdflkjasdhf', 0, 1),
	(11, 'Estanis', ' xdxdxd', 1, 'apasudfpoasdfpoasdfpaasdfasddfsodifuasdpofiuasdpofuasdfopasdflkjasdhf', 1, 1),
	(12, 'Estanis', ' xdxdxdxd', 1, 'apasudfpoasdfpoasdfpaasdfasddfsodifuasdpofiuasdpofuasdfopasdflkjasdhf', 0, 1),
	(13, 'La odisea de santi', 'Marcos Simon', 56, 'Santi perdiendo rankeds, Santi perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti perdiendo rankedsSanti per', 0, 5);
/*!40000 ALTER TABLE `libro` ENABLE KEYS */;

-- Volcando estructura para tabla MatchBook.usuario
CREATE TABLE IF NOT EXISTS `usuario` (
  `id_usuario` int NOT NULL AUTO_INCREMENT,
  `username` varchar(15) NOT NULL,
  `fecha_nac` date NOT NULL,
  `email` varchar(30) NOT NULL,
  `pswd` varchar(50) NOT NULL,
  `direccion` varchar(40) NOT NULL,
  PRIMARY KEY (`id_usuario`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla MatchBook.usuario: ~4 rows (aproximadamente)
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` (`id_usuario`, `username`, `fecha_nac`, `email`, `pswd`, `direccion`) VALUES
	(1, 'santi maricona', '0000-00-00', 'santiestrela9@gmail.com', '123', 'sexosfd'),
	(2, 'pinga', '0000-00-00', 'pitomorango@gmail.com', '5555', 'La calle'),
	(3, 'alvaro', '0000-00-00', 'alvaro@gmail.com', '1234', 'FLORIDA UNIVERSITARIA'),
	(5, '2', '0000-00-00', '2', '2', 'rafa sucio');
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;

-- Volcando estructura para tabla MatchBook.valoracion
CREATE TABLE IF NOT EXISTS `valoracion` (
  `cant_likes` int NOT NULL,
  `reseña` varchar(500) DEFAULT NULL,
  `id_usuario_fk` int NOT NULL,
  `id_libro_fk` int NOT NULL,
  `fecha` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- Volcando datos para la tabla MatchBook.valoracion: ~0 rows (aproximadamente)
/*!40000 ALTER TABLE `valoracion` DISABLE KEYS */;
/*!40000 ALTER TABLE `valoracion` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
