-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-11-2022 a las 05:01:34
-- Versión del servidor: 10.4.25-MariaDB
-- Versión de PHP: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `pulso`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `historial`
--

CREATE TABLE `historial` (
  `idUser2` int(11) NOT NULL,
  `idReg` int(11) NOT NULL,
  `frecuencia` float NOT NULL,
  `fecha` varchar(50) NOT NULL,
  `clasificacion` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `historial`
--

INSERT INTO `historial` (`idUser2`, `idReg`, `frecuencia`, `fecha`, `clasificacion`) VALUES
(1, 1, 77, '21/11/2022 04:38:32 p. m.', 'Normal'),
(1, 2, 153, '21/11/2022 04:42:17 p. m.', 'Inadecuado'),
(1, 4, 66, '21/11/2022 04:51:34 p. m.', 'Excelente'),
(1, 5, 53, '21/11/2022 04:59:48 p. m.', 'Excelente'),
(7, 6, 72, '21/11/2022 05:04:39 p. m.', 'Bueno'),
(1, 7, 76, '21/11/2022 05:07:37 p. m.', 'Bueno'),
(1, 8, 96, '21/11/2022 05:32:26 p. m.', 'Inadecuado'),
(1, 9, 64, '23/11/2022 04:31:42 p. m.', 'Excelente'),
(7, 10, 71, '23/11/2022 05:23:01 p. m.', 'Bueno'),
(7, 11, 176, '21/11/2022 05:24:32 p. m.', 'Inadecuado'),
(7, 12, 79, '23/11/2022 05:25:14 p. m.', 'Normal'),
(7, 13, 66, '23/11/2022 05:30:12 p. m.', 'Excelente'),
(7, 14, 60, '23/11/2022 08:24:54 p. m.', 'Inadecuado'),
(7, 15, 78, '23/11/2022 08:41:41 p. m.', 'Normal'),
(1, 16, 223, '23/11/2022 09:48:24 p. m.', 'Inadecuado'),
(8, 17, 48, '23/11/2022 09:56:33 p. m.', 'Excelente');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `user`
--

CREATE TABLE `user` (
  `idUser` int(11) NOT NULL,
  `nomUser` varchar(100) NOT NULL,
  `passUser` varchar(30) NOT NULL,
  `edad` int(11) NOT NULL,
  `genero` char(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Volcado de datos para la tabla `user`
--

INSERT INTO `user` (`idUser`, `nomUser`, `passUser`, `edad`, `genero`) VALUES
(1, 'Maribel Amaya', '123', 21, 'F'),
(2, 'Jabneel Perez', '098', 21, 'M'),
(3, 'Yesenia Rodriguez', '567', 21, 'F'),
(4, 'Benjamin Zuñiga', '302', 21, 'M'),
(5, 'Amaya Galaviz', '234', 123, 'F'),
(6, 'Gamaliel Esquivel', '098', 21, 'M'),
(7, 'Yesenia Sanchez', '321', 21, 'F'),
(8, 'Valeria Lopez', '098', 21, 'F');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `historial`
--
ALTER TABLE `historial`
  ADD PRIMARY KEY (`idReg`),
  ADD KEY `idUser2` (`idUser2`);

--
-- Indices de la tabla `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`idUser`),
  ADD UNIQUE KEY `nomUser` (`nomUser`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `historial`
--
ALTER TABLE `historial`
  MODIFY `idReg` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- AUTO_INCREMENT de la tabla `user`
--
ALTER TABLE `user`
  MODIFY `idUser` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `historial`
--
ALTER TABLE `historial`
  ADD CONSTRAINT `historial_ibfk_1` FOREIGN KEY (`idUser2`) REFERENCES `user` (`idUser`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
