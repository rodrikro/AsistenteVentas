-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 06-06-2022 a las 05:02:56
-- Versión del servidor: 10.4.17-MariaDB
-- Versión de PHP: 7.3.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `asistenteventas`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `categorias`
--

CREATE TABLE `categorias` (
  `idCategoria` int(11) NOT NULL,
  `idDepartamento` int(11) NOT NULL,
  `clave` varchar(15) COLLATE utf8mb4_bin NOT NULL,
  `nombreCategoria` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `descripcion` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `momentoCreacion` datetime NOT NULL,
  `momentoModificacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `categorias`
--

INSERT INTO `categorias` (`idCategoria`, `idDepartamento`, `clave`, `nombreCategoria`, `descripcion`, `momentoCreacion`, `momentoModificacion`) VALUES
(1, 1, 'D01C01', 'Damas', '', '2022-06-05 20:36:07', '2022-06-05 20:36:07'),
(2, 1, 'D01C02', 'Caballeros', '', '2022-06-05 20:36:07', '2022-06-05 20:36:07'),
(3, 2, 'D02C01', 'Cumpleaños', '', '2022-06-05 20:36:07', '2022-06-05 20:36:07'),
(4, 2, 'D02C02', 'Novedades', '', '2022-06-05 20:36:07', '2022-06-05 20:36:07');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `departamentos`
--

CREATE TABLE `departamentos` (
  `idDepartamento` int(11) NOT NULL,
  `clave` varchar(15) COLLATE utf8mb4_bin NOT NULL,
  `nombreDepartamento` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `descripcion` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `momentoCreacion` datetime NOT NULL,
  `momentoModificacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `departamentos`
--

INSERT INTO `departamentos` (`idDepartamento`, `clave`, `nombreDepartamento`, `descripcion`, `momentoCreacion`, `momentoModificacion`) VALUES
(1, 'D01', 'Ropa', 'Toda la mercancía de ropa', '2022-05-23 00:47:25', '2022-05-23 00:47:25'),
(2, 'D02', 'Accesorios', 'Toda la mercancía relacionada a accesorios', '2022-05-23 00:48:25', '2022-05-23 00:48:25');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `productos`
--

CREATE TABLE `productos` (
  `IdProducto` int(11) NOT NULL,
  `IdDepartamento` int(11) NOT NULL,
  `IdCategoria` int(11) NOT NULL,
  `IdProveedor` int(11) NOT NULL,
  `Clave` varchar(30) COLLATE utf8mb4_bin NOT NULL,
  `Nombre` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `Presentacion` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `CantidadMinima` int(11) NOT NULL,
  `CantidadActual` int(11) NOT NULL,
  `Descripcion` varchar(150) COLLATE utf8mb4_bin NOT NULL,
  `Activo` bit(1) NOT NULL,
  `FechaCreacion` datetime NOT NULL,
  `FechaModificacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedores`
--

CREATE TABLE `proveedores` (
  `IdProveedor` int(11) NOT NULL,
  `NombreProveedor` varchar(50) COLLATE utf8mb4_bin NOT NULL,
  `FechaCreacion` datetime NOT NULL,
  `FechaModificacion` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `proveedores`
--

INSERT INTO `proveedores` (`IdProveedor`, `NombreProveedor`, `FechaCreacion`, `FechaModificacion`) VALUES
(1, 'Proveedor de ropa', '2022-06-05 21:23:26', '2022-06-05 21:23:26'),
(2, 'Proveedor de accesorios', '2022-06-05 21:23:26', '2022-06-05 21:23:26');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `usuarios`
--

CREATE TABLE `usuarios` (
  `usuario` varchar(20) COLLATE utf8mb4_bin NOT NULL,
  `contrasena` varchar(100) COLLATE utf8mb4_bin NOT NULL,
  `nombre` varchar(150) COLLATE utf8mb4_bin NOT NULL,
  `descripcion` varchar(250) COLLATE utf8mb4_bin NOT NULL,
  `perfil` varchar(20) COLLATE utf8mb4_bin NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_bin;

--
-- Volcado de datos para la tabla `usuarios`
--

INSERT INTO `usuarios` (`usuario`, `contrasena`, `nombre`, `descripcion`, `perfil`) VALUES
('ROMA', '12345', 'Rosa Maria Rodriguez Lopez', 'La jefa', 'ADMINISTRADOR'),
('RAMK', '12345', 'Rodrigo Abel Monarrez Krotzsch', 'Desarrollador', 'ADMINISTRADOR');

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `categorias`
--
ALTER TABLE `categorias`
  ADD PRIMARY KEY (`idCategoria`);

--
-- Indices de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  ADD PRIMARY KEY (`idDepartamento`);

--
-- Indices de la tabla `productos`
--
ALTER TABLE `productos`
  ADD PRIMARY KEY (`IdProducto`);

--
-- Indices de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  ADD PRIMARY KEY (`IdProveedor`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `categorias`
--
ALTER TABLE `categorias`
  MODIFY `idCategoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT de la tabla `departamentos`
--
ALTER TABLE `departamentos`
  MODIFY `idDepartamento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `productos`
--
ALTER TABLE `productos`
  MODIFY `IdProducto` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `proveedores`
--
ALTER TABLE `proveedores`
  MODIFY `IdProveedor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
