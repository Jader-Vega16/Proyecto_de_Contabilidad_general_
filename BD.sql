CREATE DATABASE  IF NOT EXISTS `Contabilidad_JPR` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_spanish_ci */;
USE `Contabilidad_JPR`;
-- MySQL dump 10.13  Distrib 5.7.30, for Linux (x86_64)
--
-- Host: localhost    Database: Contabilidad_JPR
-- ------------------------------------------------------
-- Server version	5.7.30-0ubuntu0.18.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Asiento_contable`
--

DROP TABLE IF EXISTS `Asiento_contable`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Asiento_contable` (
  `idAsiento` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Esta variable contiene el id único de la tabla.',
  `codigoAsiento` int(11) NOT NULL COMMENT 'Es el número con que se hace el asiento a lo largo del ejercicio.\n',
  `cuentaDebeID` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL COMMENT 'Es el código de la cuenta de partida doble que se relaciona con los ingresos y debitos.',
  `importeDebe` double DEFAULT NULL COMMENT 'Total de aumento de activos y gastos',
  `cuentaHaberID` varchar(50) COLLATE utf8_spanish_ci DEFAULT NULL COMMENT 'Es el código de la cuenta de partida doble que se relaciona con gastos y créditos.\n',
  `importeHaber` double DEFAULT NULL COMMENT ' Total de disminución de pasivos, patrimonio neto e ingresos.',
  `activo` int(11) NOT NULL COMMENT 'Indica si el asiento contable está activo o si ya no sigue vigente, 1 para activo y 0 para inactivo',
  `fecha_asiento` date NOT NULL COMMENT ' Es la fecha en que se realizó el asiento contable.',
  `Catalogo_cuentas_idCatalogo_cuentas` int(11) NOT NULL COMMENT 'Es el id único que posee la tabla catalogo cuentas.',
  `Usuario_idUsuario` int(11) NOT NULL COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  `Detalles_empresa_id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.',
  PRIMARY KEY (`idAsiento`,`Usuario_idUsuario`,`Detalles_empresa_id_empresa`,`Catalogo_cuentas_idCatalogo_cuentas`),
  KEY `fk_Asiento_contable_Catalogo_cuentas1_idx` (`Catalogo_cuentas_idCatalogo_cuentas`),
  KEY `fk_Asiento_contable_Usuario1_idx` (`Usuario_idUsuario`),
  KEY `fk_Asiento_contable_Detalles_empresa1_idx` (`Detalles_empresa_id_empresa`),
  CONSTRAINT `fk_Asiento_contable_Catalogo_cuentas1` FOREIGN KEY (`Catalogo_cuentas_idCatalogo_cuentas`) REFERENCES `Catalogo_cuentas` (`idCatalogo_cuentas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Asiento_contable_Detalles_empresa1` FOREIGN KEY (`Detalles_empresa_id_empresa`) REFERENCES `Detalles_empresa` (`id_empresa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Asiento_contable_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `Usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Tabla con todas las partidas pertenecientes a los asientos generados y almacenados en el libro diario.\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Asiento_contable`
--

LOCK TABLES `Asiento_contable` WRITE;
/*!40000 ALTER TABLE `Asiento_contable` DISABLE KEYS */;
INSERT INTO `Asiento_contable` VALUES (1,1,'1.1.1.1',500,'-',0,1,'2000-01-10',4,1,'ANCC101112'),(2,1,'2',500,'-',0,1,'2000-01-10',5,1,'ANCC101112'),(3,1,'3',1000,'-',0,1,'2000-01-10',6,1,'ANCC101112'),(4,1,'-',0,'4',2000,1,'2000-02-10',7,1,'ANCC101112');
/*!40000 ALTER TABLE `Asiento_contable` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Catalogo_cuentas`
--

DROP TABLE IF EXISTS `Catalogo_cuentas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Catalogo_cuentas` (
  `idCatalogo_cuentas` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Es el id único que posee la tabla catalogo cuentas.',
  `numero_cuenta` varchar(50) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Es el código de ruta de la cuenta.',
  `nombre_cuenta` varchar(20) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Es el nombre fiscal de la cuenta.\n',
  `descripcion_cuenta` varchar(40) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Es la finalidad de una cuenta en específico, siendo esto un aclarativo de dicha finalidad.\n',
  `activo` int(11) NOT NULL COMMENT 'Indica si la cuenta está activo o no, si ya no lo esta es porque fue eliminada, 1 para activo y 0 para inactivo\n',
  `pais_cuenta` varchar(35) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Es el país de origen de la cuenta.\n',
  `id_cuentaPadre` int(11) DEFAULT NULL COMMENT ' Indica si la cuenta padre de una subcuenta, si es que la cuenta posee una, esto para llevar el orden de cuentas de forma recursiva',
  `Detalles_empresa_id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.',
  `Tipos_naturaleza_id_naturalezaCuenta` int(11) NOT NULL COMMENT 'Es el id que identifica un tipo de naturaleza de cuenta.',
  `Usuario_idUsuario` int(11) NOT NULL COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  PRIMARY KEY (`idCatalogo_cuentas`,`Usuario_idUsuario`,`Tipos_naturaleza_id_naturalezaCuenta`,`Detalles_empresa_id_empresa`),
  KEY `fk_Catalogo_cuentas_Detalles_empresa1_idx` (`Detalles_empresa_id_empresa`),
  KEY `fk_Catalogo_cuentas_Tipos_naturaleza1_idx` (`Tipos_naturaleza_id_naturalezaCuenta`),
  KEY `fk_Catalogo_cuentas_Usuario1_idx` (`Usuario_idUsuario`),
  KEY `id_cuentaPadre_idx` (`id_cuentaPadre`),
  CONSTRAINT `fk_Catalogo_cuentas_Detalles_empresa1` FOREIGN KEY (`Detalles_empresa_id_empresa`) REFERENCES `Detalles_empresa` (`id_empresa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Catalogo_cuentas_Tipos_naturaleza1` FOREIGN KEY (`Tipos_naturaleza_id_naturalezaCuenta`) REFERENCES `Tipos_naturaleza` (`id_naturalezaCuenta`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Catalogo_cuentas_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `Usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `id_cuentaPadre` FOREIGN KEY (`id_cuentaPadre`) REFERENCES `Catalogo_cuentas` (`idCatalogo_cuentas`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Es una recopilación de todas las cuentas contables en las que se realizan las operaciones y en las que se llevan la contabilidad de la empresa.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Catalogo_cuentas`
--

LOCK TABLES `Catalogo_cuentas` WRITE;
/*!40000 ALTER TABLE `Catalogo_cuentas` DISABLE KEYS */;
INSERT INTO `Catalogo_cuentas` VALUES (1,'1','Activos','Destinada a los activos',1,'Nicaragua',1,'ANCC101112',1,1),(2,'1.1','Activos Corrientes','Destinada a los activos corrientes',1,'Nicaragua',2,'ANCC101112',2,2),(3,'1.1.1.001','Caja','Destinada a la caja',1,'Nicaragua',1,'ANCC101112',3,2),(4,'1.1.1.1','Caja general','Para caja general',1,'Nicaragua',3,'ANCC101112',1,1),(5,'2','Cuentas por cobrar','Para ingreso de dinero',1,'Nicaragua',5,'ANCC101112',1,1),(6,'3','Compra de Mercaderia','Pago de mercaderia',1,'Nicaragua',6,'ANCC101112',1,1),(7,'4','Venta de Mercaderia','Ingreso de mercaderia',1,'Nicaragua',7,'ANCC101112',1,1);
/*!40000 ALTER TABLE `Catalogo_cuentas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Detalles_empresa`
--

DROP TABLE IF EXISTS `Detalles_empresa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Detalles_empresa` (
  `id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.',
  `nombre_empresa` varchar(35) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el nombre corriente de la empresa.\n',
  `nombre_comercial` varchar(35) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el nombre comercial de la empresa. Este sera el nombre por el cual la empresa sera identificada en el tráfico mercantil.',
  `direccion_empresa` varchar(85) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Indica la dirección actual de la empresa.',
  `localidad_empresa` varchar(30) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Indica la localidad de la empresa.\n',
  `correo_empresa` varchar(35) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el correo de la empresa.',
  `activo` int(11) NOT NULL COMMENT ' Indica si la empresa está activa o no, si no está activa es porque fue eliminada, 1 para activo y 0 para inactivo',
  PRIMARY KEY (`id_empresa`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Esta tabla contiene información específica sobre la empresa, la cual será usada en el sistema de la misma.\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Detalles_empresa`
--

LOCK TABLES `Detalles_empresa` WRITE;
/*!40000 ALTER TABLE `Detalles_empresa` DISABLE KEYS */;
INSERT INTO `Detalles_empresa` VALUES ('AMNC070809','Amanecer','Empresa Amanecer','Direccion Amanecer','Managua','amanecer@gmail.com',1),('ANCC101112','Anochecer','Empresa Anochecer','Direccion Anochecer','Anochecer','anochecer@gmail.com',1),('OCSO040506','Ocaso','Empresa Ocaso','Direccion Ocaso','Chinandega','ocaso@gmail.com',1);
/*!40000 ALTER TABLE `Detalles_empresa` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Empleados`
--

DROP TABLE IF EXISTS `Empleados`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Empleados` (
  `idEmpleado` varchar(10) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Esta variable contiene el id con el cual es identificado cada usuario que posee un empleado dentro del sistema de la empresa.\n',
  `fecha_ingreso` date NOT NULL COMMENT 'Indica la fecha en el que ingreso el empleado.\n',
  `cedula` varchar(17) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el número de cedula del empleado, cuyo usuario fue registrado en el sistema de la empresa.\n',
  `nombre_cargo` varchar(25) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Indica el cargo que posee el empleado dentro de la empresa.\n',
  `nombre_empleado` varchar(30) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Indica el nombre completo empleado.\n',
  `apellido_empleado` varchar(30) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Indica el apellido completo del empleado.\n',
  `telefono_empleado` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL COMMENT 'Contiene el número de teléfono del empleado.',
  `celular_empleado` varchar(10) COLLATE utf8_spanish_ci DEFAULT NULL COMMENT 'Contiene el número de celular del empleado.',
  `correo_empleado` varchar(35) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el correo empresarial del empleado.',
  `direccion_empleado` varchar(85) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Contiene la dirección del domicilio del empleado.\n',
  `sueldo` double NOT NULL COMMENT 'Indica el sueldo a pagar al empleado por parte de la empresa.',
  `activo` int(11) NOT NULL,
  PRIMARY KEY (`idEmpleado`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Esta tabla contiene la información tanto personal como laboral de cada empleado dentro del sistema de la empresa.\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Empleados`
--

LOCK TABLES `Empleados` WRITE;
/*!40000 ALTER TABLE `Empleados` DISABLE KEYS */;
INSERT INTO `Empleados` VALUES ('JSVR161020','2000-02-16','001-161000-1046J','Gerente','Jader Scott','Vega Romero','2222-2222','7777-7777','jader.vega@gmail.com','Casa de Jader',120.15,1),('PCTC070601','2000-02-25','002-070601-1154P','Supervisora','Priscila del Carmen','Tinoco Cruz','2424-2424','8888-8888','priscila02@gmail.com','Rancho Tinoco',110.23,1),('RCMC250499','2000-02-28','003-250599-1245R','Asistente','Priscila Carolina','Mora Carrion','2323-2323','7878-7878','rashel.M@gmal.com','Residencia Mora',112.01,1);
/*!40000 ALTER TABLE `Empleados` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Libro_diario`
--

DROP TABLE IF EXISTS `Libro_diario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Libro_diario` (
  `idLibro_diario` int(11) NOT NULL AUTO_INCREMENT COMMENT ' Es el id único que posee un libro diario.',
  `fecha_libroDiario` date NOT NULL COMMENT 'Fecha en la que se realizó el registro del libro diario.',
  `concepto_movimiento` varchar(80) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Concepto del movimiento realizado en el libro diario.',
  `totalDebe` double DEFAULT NULL COMMENT 'Total de aumento de activos y gastos del libro diario.',
  `totalHaber` double DEFAULT NULL COMMENT 'Total de disminución de pasivos, patrimonio neto e ingresos del libro diario.',
  `activo` int(11) NOT NULL COMMENT ' Indica si  el libro diario sigue vigente o no, 1 si esta vigente y 0 si no lo esta.',
  `Usuario_idUsuario` int(11) NOT NULL COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  `Detalles_empresa_id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.',
  `Asiento_contable_idAsiento` int(11) NOT NULL COMMENT 'Esta variable contiene el id único de la tabla.',
  `Catalogo_cuentas_idCatalogo_cuentas` int(11) NOT NULL COMMENT 'Es el id único que posee la tabla catalogo cuentas.',
  `Periodos_contables_idPeriodos_contables` int(11) NOT NULL COMMENT 'Es el id del periodo en el que se hace referencia a los libros contables de cualquier entidad.',
  PRIMARY KEY (`idLibro_diario`,`Usuario_idUsuario`,`Detalles_empresa_id_empresa`,`Asiento_contable_idAsiento`,`Catalogo_cuentas_idCatalogo_cuentas`,`Periodos_contables_idPeriodos_contables`),
  KEY `fk_Libro_diario_Usuario1_idx` (`Usuario_idUsuario`),
  KEY `fk_Libro_diario_Detalles_empresa1_idx` (`Detalles_empresa_id_empresa`),
  KEY `fk_Libro_diario_Asiento_contable1_idx` (`Asiento_contable_idAsiento`),
  KEY `fk_Libro_diario_Catalogo_cuentas1_idx` (`Catalogo_cuentas_idCatalogo_cuentas`),
  KEY `fk_Libro_diario_Periodos_contables1_idx` (`Periodos_contables_idPeriodos_contables`),
  CONSTRAINT `fk_Libro_diario_Asiento_contable1` FOREIGN KEY (`Asiento_contable_idAsiento`) REFERENCES `Asiento_contable` (`idAsiento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_diario_Catalogo_cuentas1` FOREIGN KEY (`Catalogo_cuentas_idCatalogo_cuentas`) REFERENCES `Catalogo_cuentas` (`idCatalogo_cuentas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_diario_Detalles_empresa1` FOREIGN KEY (`Detalles_empresa_id_empresa`) REFERENCES `Detalles_empresa` (`id_empresa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_diario_Periodos_contables1` FOREIGN KEY (`Periodos_contables_idPeriodos_contables`) REFERENCES `Periodos_contables` (`idPeriodos_contables`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_diario_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `Usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Tabla en donde se guardan todas la anotaciones realizadas en el libro diario';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Libro_diario`
--

LOCK TABLES `Libro_diario` WRITE;
/*!40000 ALTER TABLE `Libro_diario` DISABLE KEYS */;
INSERT INTO `Libro_diario` VALUES (1,'2000-10-10','Paga reparacion',500,0,1,1,'AMNC070809',1,1,1),(2,'2000-10-10','Ganancia Mercaderia',0,500,1,1,'AMNC070809',2,1,1);
/*!40000 ALTER TABLE `Libro_diario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Libro_mayor`
--

DROP TABLE IF EXISTS `Libro_mayor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Libro_mayor` (
  `idLibro_mayor` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Es el id unico que posee un libro mayor.',
  `mes_libro_mayor` varchar(10) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Es el mes en que se realiza el libro mayor.',
  `concepto_movimiento` varchar(80) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Concepto del movimiento realizado en el libro mayor.',
  `totalHaber` double DEFAULT NULL COMMENT 'Total de disminución de pasivos, patrimonio neto e ingresos del libro mayor.\n',
  `totalDebe` double DEFAULT NULL COMMENT 'Total de aumento de activos y gastos del libro mayor.',
  `activo` int(11) NOT NULL COMMENT ' Indica si el libro mayor sigue vigente o no, 1 para activo y 0 para inactivo\n',
  `Asiento_contable_idAsiento` int(11) NOT NULL COMMENT 'Esta variable contiene el id único de la tabla.',
  `Usuario_idUsuario` int(11) NOT NULL COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  `Detalles_empresa_id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.\n',
  `Periodos_contables_idPeriodos_contables` int(11) NOT NULL COMMENT 'Es el  id del periodo en el que se hace referencia a los libros contables de cualquier entidad.',
  `Catalogo_cuentas_idCatalogo_cuentas` int(11) NOT NULL COMMENT 'Es el id único que posee la tabla catalogo cuentas.',
  PRIMARY KEY (`idLibro_mayor`,`Asiento_contable_idAsiento`,`Usuario_idUsuario`,`Detalles_empresa_id_empresa`,`Periodos_contables_idPeriodos_contables`,`Catalogo_cuentas_idCatalogo_cuentas`),
  KEY `fk_Libro_mayor_Asiento_contable1_idx` (`Asiento_contable_idAsiento`),
  KEY `fk_Libro_mayor_Usuario1_idx` (`Usuario_idUsuario`),
  KEY `fk_Libro_mayor_Detalles_empresa1_idx` (`Detalles_empresa_id_empresa`),
  KEY `fk_Libro_mayor_Periodos_contables1_idx` (`Periodos_contables_idPeriodos_contables`),
  KEY `fk_Libro_mayor_Catalogo_cuentas1_idx` (`Catalogo_cuentas_idCatalogo_cuentas`),
  CONSTRAINT `fk_Libro_mayor_Asiento_contable1` FOREIGN KEY (`Asiento_contable_idAsiento`) REFERENCES `Asiento_contable` (`idAsiento`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_mayor_Catalogo_cuentas1` FOREIGN KEY (`Catalogo_cuentas_idCatalogo_cuentas`) REFERENCES `Catalogo_cuentas` (`idCatalogo_cuentas`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_mayor_Detalles_empresa1` FOREIGN KEY (`Detalles_empresa_id_empresa`) REFERENCES `Detalles_empresa` (`id_empresa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_mayor_Periodos_contables1` FOREIGN KEY (`Periodos_contables_idPeriodos_contables`) REFERENCES `Periodos_contables` (`idPeriodos_contables`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Libro_mayor_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `Usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Tabla en donde se guardan todas la anotaciones realizadas en el libro mayor';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Libro_mayor`
--

LOCK TABLES `Libro_mayor` WRITE;
/*!40000 ALTER TABLE `Libro_mayor` DISABLE KEYS */;
INSERT INTO `Libro_mayor` VALUES (1,'Octubre','Pago de inmuebles',500,0,1,1,1,'AMNC070809',1,1),(2,'Octubre','Ingreso de pagos',0,500,1,2,1,'AMNC070809',1,2);
/*!40000 ALTER TABLE `Libro_mayor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Periodos_contables`
--

DROP TABLE IF EXISTS `Periodos_contables`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Periodos_contables` (
  `idPeriodos_contables` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Es el id del periodo en el que se hace referencia a los libros contables de cualquier entidad.\n',
  `codigoPeriodo` varchar(8) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Indica el codigo unico de un periodo contable',
  `fecha_incio` date NOT NULL COMMENT 'Fecha en la que comienza un periodo contable.\n',
  `fecha_fin` date NOT NULL COMMENT 'Fecha en la que culmina un periodo contable.\n',
  `activo` int(11) NOT NULL COMMENT ' Indica si el periodo contable sigue vigente o no, 1 para vigente y 0 para invigente',
  `Detalles_empresa_id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.\n',
  `Usuario_idUsuario` int(11) NOT NULL COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  PRIMARY KEY (`idPeriodos_contables`,`Detalles_empresa_id_empresa`,`Usuario_idUsuario`),
  KEY `fk_Periodos_contables_Detalles_empresa1_idx` (`Detalles_empresa_id_empresa`),
  KEY `fk_Periodos_contables_Usuario1_idx` (`Usuario_idUsuario`),
  CONSTRAINT `fk_Periodos_contables_Detalles_empresa1` FOREIGN KEY (`Detalles_empresa_id_empresa`) REFERENCES `Detalles_empresa` (`id_empresa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Periodos_contables_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `Usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT=' Esta tabla almacena la información de los distintos periodos contables que lleva la empresa \n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Periodos_contables`
--

LOCK TABLES `Periodos_contables` WRITE;
/*!40000 ALTER TABLE `Periodos_contables` DISABLE KEYS */;
INSERT INTO `Periodos_contables` VALUES (1,'2000-04','2000-04-01','2000-04-30',1,'ANCC101112',1),(2,'2000-05','2000-05-01','2000-05-29',1,'ANCC101112',1),(3,'2000-06','2000-05-01','2000-05-31',1,'ANCC101112',1);
/*!40000 ALTER TABLE `Periodos_contables` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Rol`
--

DROP TABLE IF EXISTS `Rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Rol` (
  `idRol` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Esta variable contiene el id del tipo de rol que se le fue otorgado a un usuario que tiene acceso al sistema de la empresa.',
  `nombre` varchar(15) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Indica el nombre del rol que desempeñara cada empleado, el cual tiene un usuario dentro del sistema de la empresa.',
  PRIMARY KEY (`idRol`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Esta tabla contiene la información sobre el rol que fue otorgado a cada empleado en el sistema de la empresa.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Rol`
--

LOCK TABLES `Rol` WRITE;
/*!40000 ALTER TABLE `Rol` DISABLE KEYS */;
INSERT INTO `Rol` VALUES (1,'Administrador'),(2,'Invitado');
/*!40000 ALTER TABLE `Rol` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Rol_opciones`
--

DROP TABLE IF EXISTS `Rol_opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Rol_opciones` (
  `idRolOpc` int(11) NOT NULL AUTO_INCREMENT,
  `habilitado` int(11) NOT NULL,
  `fechaCreacion` date NOT NULL,
  `Rol_idRol` int(11) NOT NULL,
  `Tabla_opciones_idOpciones` int(11) NOT NULL,
  PRIMARY KEY (`idRolOpc`,`Tabla_opciones_idOpciones`,`Rol_idRol`),
  KEY `fk_Rol_opciones_Rol1_idx` (`Rol_idRol`),
  KEY `fk_Rol_opciones_Tabla_opciones1_idx` (`Tabla_opciones_idOpciones`),
  CONSTRAINT `fk_Rol_opciones_Rol1` FOREIGN KEY (`Rol_idRol`) REFERENCES `Rol` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Rol_opciones_Tabla_opciones1` FOREIGN KEY (`Tabla_opciones_idOpciones`) REFERENCES `Tabla_opciones` (`idOpciones`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Rol_opciones`
--

LOCK TABLES `Rol_opciones` WRITE;
/*!40000 ALTER TABLE `Rol_opciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `Rol_opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Tabla_moneda`
--

DROP TABLE IF EXISTS `Tabla_moneda`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Tabla_moneda` (
  `id_moneda` int(11) NOT NULL AUTO_INCREMENT COMMENT ' Esta variable contiene el id propio de cada moneda que será usada en el sistema de la empresa.',
  `nombre_moneda` varchar(45) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Indica el nombre de la moneda que será usada en el sistema de la empresa.',
  `cod_ISO_Alfab` varchar(3) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Indica el código ISO de cada moneda. El ISO 4217 establece que cada divisa en el mundo debe ser representada por un código de tres letras.',
  `pais` varchar(35) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Esta variable indica el país al que pertenece dicha moneda que es usada en el sistema',
  `tasa_conversion` double NOT NULL COMMENT 'Esta variable contiene la tasa de conversión  a la moneda nacional usada en un proceso hecho por el sistema de la empresa.',
  `activo` int(11) NOT NULL COMMENT 'Indica si la moneda está activa o no, si no está activa es porque fue eliminada, 1 para activo y 0 para inactivo\n',
  `Usuario_idUsuario` int(11) NOT NULL COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  `Detalles_empresa_id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.\n',
  PRIMARY KEY (`id_moneda`,`Usuario_idUsuario`,`Detalles_empresa_id_empresa`),
  KEY `fk_Tabla_moneda_Usuario1_idx` (`Usuario_idUsuario`),
  KEY `fk_Tabla_moneda_Detalles_empresa1_idx` (`Detalles_empresa_id_empresa`),
  CONSTRAINT `fk_Tabla_moneda_Detalles_empresa1` FOREIGN KEY (`Detalles_empresa_id_empresa`) REFERENCES `Detalles_empresa` (`id_empresa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Tabla_moneda_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `Usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Contiene toda la información básica de una serie de monedas basándose en los datos requeridos según la ISO 4217. ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Tabla_moneda`
--

LOCK TABLES `Tabla_moneda` WRITE;
/*!40000 ALTER TABLE `Tabla_moneda` DISABLE KEYS */;
INSERT INTO `Tabla_moneda` VALUES (1,'Euro','EUR','Paises Bajos',37.39,1,2,'ANCC101112'),(2,'Colon Costarricense','CRC','Costa Rica',0.061,1,1,'OCSO040506'),(3,'Dolar Estado Unidense','USD','Estados Unidos',34.55,1,1,'OCSO040506');
/*!40000 ALTER TABLE `Tabla_moneda` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Tabla_opciones`
--

DROP TABLE IF EXISTS `Tabla_opciones`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Tabla_opciones` (
  `idOpciones` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Esta variable contiene el id único de cada opción que está disponible en el sistema de la empresa.\n',
  `nombre_opcion` varchar(15) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Contiene el nombre de la opción que puede ser seleccionada por el usuario en dependencia de su rol.\n',
  `formulario_opcion` varchar(25) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Es el nombre de formulario en donde se encuentra disponible cualquier opción dentro del sistema de la empresa.',
  PRIMARY KEY (`idOpciones`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Esta tabla contiene todas las opciones de las que dispone el sistema con su respectivo formulario en que se encuentra.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Tabla_opciones`
--

LOCK TABLES `Tabla_opciones` WRITE;
/*!40000 ALTER TABLE `Tabla_opciones` DISABLE KEYS */;
/*!40000 ALTER TABLE `Tabla_opciones` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Tipos_naturaleza`
--

DROP TABLE IF EXISTS `Tipos_naturaleza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Tipos_naturaleza` (
  `id_naturalezaCuenta` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Es el id que identifica un tipo de naturaleza de cuenta.\n',
  `nombreNaturaleza` varchar(20) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Nombre del tipo de naturaleza de la cuenta.',
  `descripcion_naturaleza` varchar(45) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Breve descripción del concepto del tipo de naturaleza de la cuenta.',
  `activo` int(11) NOT NULL COMMENT 'Indica si  el tipo de naturaleza ha sido eliminado  o no, 1 para activo y 0 para inactivo',
  PRIMARY KEY (`id_naturalezaCuenta`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='En esta tabla ase almacenan todos los tipos de naturalezas de cuenta';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Tipos_naturaleza`
--

LOCK TABLES `Tipos_naturaleza` WRITE;
/*!40000 ALTER TABLE `Tipos_naturaleza` DISABLE KEYS */;
INSERT INTO `Tipos_naturaleza` VALUES (1,'Cuenta de ahorro','Para ahorra, ofrece cierta rentabilidad',1),(2,'Cuentas corrientes','No ofrecen renumeracion',1),(3,'Cuentas de nomina','Para domicilio de nomina',1);
/*!40000 ALTER TABLE `Tipos_naturaleza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario`
--

DROP TABLE IF EXISTS `Usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario` (
  `idUsuario` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  `usuario` varchar(15) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el nombre de usuario del empleado con cuenta de acceso al sistema de la empresa.\n',
  `pwd` varchar(10) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene la contraseña propia de cada usuario del sistema.',
  `fechaCreacion` date NOT NULL COMMENT 'Es la fecha en la que fue creado el usuario de un empleado de la empresa para poder acceder al sistema.',
  `activo` int(11) NOT NULL COMMENT ' Indica si el usuario está activo o no, si no está activo es porque fue eliminado, 1 para activo y 0 para inactivo\n',
  `Empleados_idEmpleado` varchar(10) COLLATE utf8_spanish_ci NOT NULL COMMENT ' Esta variable contiene el id propio para cada empleado de la empresa',
  `Detalles_empresa_id_empresa` varchar(18) COLLATE utf8_spanish_ci NOT NULL COMMENT 'Contiene el id único de la empresa.',
  PRIMARY KEY (`idUsuario`,`Detalles_empresa_id_empresa`,`Empleados_idEmpleado`),
  KEY `fk_Usuario_Empleados1_idx` (`Empleados_idEmpleado`),
  KEY `fk_Usuario_Detalles_empresa1_idx` (`Detalles_empresa_id_empresa`),
  CONSTRAINT `fk_Usuario_Detalles_empresa1` FOREIGN KEY (`Detalles_empresa_id_empresa`) REFERENCES `Detalles_empresa` (`id_empresa`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Usuario_Empleados1` FOREIGN KEY (`Empleados_idEmpleado`) REFERENCES `Empleados` (`idEmpleado`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Contiene los datos de todos los usuarios que tienen acceso al sistema, previamente registrados.\n';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario`
--

LOCK TABLES `Usuario` WRITE;
/*!40000 ALTER TABLE `Usuario` DISABLE KEYS */;
INSERT INTO `Usuario` VALUES (1,'Jader_Vega','Scott123','2000-02-16',1,'JSVR161020','ANCC101112'),(2,'Priscila_Tinoco','Tinoco456','2000-02-25',1,'PCTC070601','AMNC070809'),(3,'Rashel_Mora','Mora789','2000-02-28',1,'RCMC250499','OCSO040506');
/*!40000 ALTER TABLE `Usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Usuario_rol`
--

DROP TABLE IF EXISTS `Usuario_rol`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `Usuario_rol` (
  `idusuario_rol` int(11) NOT NULL AUTO_INCREMENT COMMENT 'Esta variable contiene el id unico para identificar un usuario con un rol.\n',
  `fechaCreacion` date NOT NULL COMMENT 'Es la fecha en la que fue creado el usuario con un rol específico de un empleado de la empresa para poder acceder al sistema.',
  `Usuario_idUsuario` int(11) NOT NULL COMMENT 'Esta variable contiene el id único con el que cada usuario de los empelados debe identificarse si tiene cuenta con acceso al sistema de la empresa.',
  `Rol_idRol` int(11) NOT NULL COMMENT ' Esta variable contiene el id del tipo de rol que se le fue otorgado a un usuario que tiene acceso al sistema de la empresa.',
  PRIMARY KEY (`idusuario_rol`,`Usuario_idUsuario`,`Rol_idRol`),
  KEY `fk_Usuario_rol_Usuario1_idx` (`Usuario_idUsuario`),
  KEY `fk_Usuario_rol_Rol1_idx` (`Rol_idRol`),
  CONSTRAINT `fk_Usuario_rol_Rol1` FOREIGN KEY (`Rol_idRol`) REFERENCES `Rol` (`idRol`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_Usuario_rol_Usuario1` FOREIGN KEY (`Usuario_idUsuario`) REFERENCES `Usuario` (`idUsuario`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_spanish_ci COMMENT='Esta tabla contiene la información de los usuarios con sus respectivos roles en la empresa, lo cual permitirá llevar un control sobre las opciones que tiene disponible el usuario.';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Usuario_rol`
--

LOCK TABLES `Usuario_rol` WRITE;
/*!40000 ALTER TABLE `Usuario_rol` DISABLE KEYS */;
INSERT INTO `Usuario_rol` VALUES (1,'2000-10-16',2,1);
/*!40000 ALTER TABLE `Usuario_rol` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-10 15:18:57
