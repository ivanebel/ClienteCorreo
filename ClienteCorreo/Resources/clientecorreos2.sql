-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 24-08-2015 a las 06:41:42
-- Versión del servidor: 5.5.27
-- Versión de PHP: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `clientecorreos`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `adjunto`
--

CREATE TABLE IF NOT EXISTS `adjunto` (
  `idadjunto` int(20) NOT NULL AUTO_INCREMENT,
  `detalle` varchar(100) DEFAULT NULL,
  `path` varchar(255) DEFAULT NULL,
  `correo_idcorreo` int(11) NOT NULL,
  PRIMARY KEY (`idadjunto`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `configuracion`
--

CREATE TABLE IF NOT EXISTS `configuracion` (
  `cantidadcorreos` int(20) DEFAULT NULL,
  `ruta` varchar(255) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `configuracion`
--

INSERT INTO `configuracion` (`cantidadcorreos`, `ruta`) VALUES
(0, 'C:\\\\Data\\');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `correo`
--

CREATE TABLE IF NOT EXISTS `correo` (
  `idcorreo` int(20) NOT NULL AUTO_INCREMENT,
  `asunto` varchar(255) DEFAULT NULL,
  `detalle` text,
  `tipocorreo` varchar(100) DEFAULT NULL,
  `fecha` varchar(30) DEFAULT NULL,
  `leido` tinyint(1) DEFAULT NULL,
  `cuenta_idcuenta` int(20) DEFAULT NULL,
  `server_idserver` int(20) DEFAULT NULL,
  PRIMARY KEY (`idcorreo`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=387 ;

--
-- Volcado de datos para la tabla `correo`
--

INSERT INTO `correo` (`idcorreo`, `asunto`, `detalle`, `tipocorreo`, `fecha`, `leido`, `cuenta_idcuenta`, `server_idserver`) VALUES
(379, 'Tres consejos para sacarle el máximo partido a Gmail', '<!DOCTYPE html>\r\n<html><head><meta http-equiv="content-type" content="text/html;charset=UTF-8" /><title>Tres consejos para sacarle el máximo partido a Gmail</title></head><body style="background-color:#e5e5e5; margin:20px 0;"><br /><div style="margin:2%;"><div style="direction:ltr; text-align:left; font-family:''Open sans'',''Arial'',sans-serif; color:#444; background-color:white; padding:1.5em; border-radius:1em; box-shadow:1px -5px 8px 2px #bbb; max-width:580px; margin:2% auto 0 auto;"><table style="background:white;width:100%"><tr><td><div style="width:90px; height:54px; margin:10px auto;"><img src="https://services.google.com/fh/files/emails/google_logo_flat_90_color.png" alt="Google" width="90" height="34"/></div><div style="width:90%; padding-bottom:10px; padding-left:15px"><p><img alt="" aria-hidden="true" src="https://ssl.gstatic.com/ui/v1/icons/mail/images/gmail_logo_large.png" style="display:inline-block; max-height:10px; margin-right:5px;"/><span style="font-family:''Open sans'',''Arial'',sans-serif; font-weight:bold; font-size:small; line-height:1.4em">Hola, Cliente:</span></p><p><span style="font-family:''Open sans'',''Arial'',sans-serif; font-size:2.08em;">Consejos para sacarle el máximo partido a Gmail</span><br/></p></div><p></p><div style="float:left; clear:both; padding:0px 5px 10px 10px;"><img src="https://services.google.com/fh/files/emails/importcontacts.png" alt="Contactos" style="display:block;"width="129"height="129"/></div><div style="float:left; vertical-align:middle; padding:10px; max-width:398px; float:left;"><table style="vertical-align:middle;"><tr><td style="font-family:''Open sans'',''Arial'',sans-serif;"><span style="font-size:20px;">Importa tus contactos y tu correo a Gmail</span><br/><br/><span style="font-size:small; line-height:1.4em">Con tu ordenador, puedes copiar tus contactos y mensajes de tu antigua cuenta de correo para simplificar aún más la transición a Gmail. <a href="https://support.google.com/mail/answer/164640?hl=es&amp;ref_topic=1669014" style="text-decoration:none; color:#15C">Más información</a></span></td></tr></table></div><div style="float:left; clear:both; padding:0px 5px 10px 10px;"><img src="https://ssl.gstatic.com/mail/welcome/localized/es/welcome_search.png" alt="Busca" style="display:block;"width="129"height="129"/></div><div style="float:left; vertical-align:middle; padding:10px; max-width:398px; float:left;"><table style="vertical-align:middle;"><tr><td style="font-family:''Open sans'',''Arial'',sans-serif;"><span style="font-size:20px;">Encuéntralo todo enseguida</span><br/><br/><span style="font-size:small; line-height:1.4em">Con toda la potencia de búsqueda de Google en tu bandeja de entrada, es muy fácil ordenar el correo. Encuentra lo que quieras con las predicciones basadas en el contenido del correo, en búsquedas previas y en tus contactos.</span></td></tr></table></div><div style="float:left; clear:both; padding:0px 5px 10px 10px;"><img src="https://ssl.gstatic.com/accounts/services/mail/msa/welcome_hangouts.png" alt="Busca" style="display:block;"width="129"height="129"/></div><div style="float:left; vertical-align:middle; padding:10px; max-width:398px; float:left;"><table style="vertical-align:middle;"><tr><td style="font-family:''Open sans'',''Arial'',sans-serif;"><span style="font-size:20px;">Mucho más que correo electrónico</span><br/><br/><span style="font-size:small; line-height:1.4em">Puedes enviar SMS y hacer videollamadas con <a href="https://www.google.com/intl/es/hangouts/" style="text-decoration:none; color:#15C">Hangouts</a> sin salir de Gmail. Si quieres utilizar esta función en un dispositivo móvil, descárgate la aplicación de Hangouts para <a href="https://play.google.com/store/apps/details?id=com.google.android.talk&amp;hl=es" style="text-decoration:none; color:#15C">Android</a> o para <a href="https://itunes.apple.com/es/app/hangouts/id643496868?mt=8" style="text-decoration:none; color:#15C">dispositivos de Apple</a>.</span></td></tr></table></div><br/><br/>\r\n<div style="clear:both; padding-left:13px; height:6.8em;"><table style="width:100%; border-collapse:collapse; border:0"><tr><td style="width:68px"><img alt=''Icono de Gmail'' width="49" height="37" src="https://ssl.gstatic.com/ui/v1/icons/mail/images/gmail_logo_large.png" style="display:block;"/></td><td style="align:left; font-family:''Open sans'',''Arial'',sans-serif; vertical-align:bottom"><span style="font-size:small">Que disfrutes de tu correo,<br/></span><span style="font-size:x-large; line-height:1">El equipo de Gmail</span></td></tr></table></div>\r\n</td></tr></table></div>\r\n<div style="direction:ltr;color:#777; font-size:0.8em; border-radius:1em; padding:1em; margin:0 auto 4% auto; font-family:''Arial'',''Helvetica'',sans-serif; text-align:center;">© 2015 Google Inc. 1600 Amphitheatre Parkway, Mountain View, CA 94043<br/></div></div></body></html>\r\n', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 1, 1),
(380, 'Lo mejor de Gmail estés donde estés', '<!DOCTYPE html>\r\n<html><head><meta http-equiv="content-type" content="text/html;charset=UTF-8" /><title>Lo mejor de Gmail estés donde estés</title></head><body style="background-color:#e5e5e5; margin:20px 0;"><br /><div style="margin:2%;"><div style="direction:ltr; text-align:left; font-family:''Open sans'',''Arial'',sans-serif; color:#444; background-color:white; padding:1.5em; border-radius:1em; box-shadow:1px -5px 8px 2px #bbb; max-width:580px; margin:2% auto 0 auto;"><table style="background:white;width:100%"><tr><td><div style="width:90px; height:54px; margin:10px auto;"><img src="https://services.google.com/fh/files/emails/google_logo_flat_90_color.png" alt="Google" width="90" height="34"/></div><div style="float:right; padding-top:2em;"><img src="https://ssl.gstatic.com/accounts/services/mail/msa/welcome_nexus.png" alt="Nexus 4 with Gmail" style="border:0; margin-right:10px;" width="155" height="242"/></div><div style="width:90%; padding-bottom:10px; padding-left:15px"><p><img alt="" aria-hidden="true" src="https://ssl.gstatic.com/ui/v1/icons/mail/images/gmail_logo_large.png" style="display:inline-block; max-height:10px; margin-right:5px;"/><span style="font-family:''Open sans'',''Arial'',sans-serif; font-weight:bold; font-size:small; line-height:1.4em">Hola, Cliente:</span></p><p><span style="font-family:''Open sans'',''Arial'',sans-serif; font-size:2.08em;"><br/>Descárgate la aplicación oficial de Gmail para móviles</span><br/></p></div><p></p><div style="padding-left:15px"><p style="size:small; line-height:1.4em;">Las mejores funciones de Gmail solo están disponible en tu teléfono y tablet con la aplicación oficial de Gmail. Descarga la aplicación o ve a <a href="https://www.gmail.com/" target="_blank" style="text-decoration:none; color:#15C">gmail.com</a> con tu ordenador o tu dispositivo móvil.</p><p style="line-height:2em; margin-right:170px;"><a href="https://play.google.com/store/apps/details?id=com.google.android.gm" style="text-decoration:none"><img alt="Google Play" width="127" height="44" src="https://ssl.gstatic.com/accounts/services/mail/buttons/google_play_es.png" style="border:0" /></a>&nbsp;&nbsp;<a href="https://itunes.apple.com/es/app/gmail/id422689480?mt=8" style="text-decoration:none;"><img alt="App Store" width="144" height="43" src="https://ssl.gstatic.com/accounts/services/mail/buttons/apple_store_es.png" style="border:0" /></a></p></div><br/><br/>\r\n<div style="clear:both; padding-left:13px; height:6.8em;"><table style="width:100%; border-collapse:collapse; border:0"><tr><td style="width:68px"><img alt=''Icono de Gmail'' width="49" height="37" src="https://ssl.gstatic.com/ui/v1/icons/mail/images/gmail_logo_large.png" style="display:block;"/></td><td style="align:left; font-family:''Open sans'',''Arial'',sans-serif; vertical-align:bottom"><span style="font-size:small">Que disfrutes de tu correo,<br/></span><span style="font-size:x-large; line-height:1">El equipo de Gmail</span></td></tr></table></div>\r\n</td></tr></table></div>\r\n<div style="direction:ltr;color:#777; font-size:0.8em; border-radius:1em; padding:1em; margin:0 auto 4% auto; font-family:''Arial'',''Helvetica'',sans-serif; text-align:center;">© 2015 Google Inc. 1600 Amphitheatre Parkway, Mountain View, CA 94043<br/></div></div></body></html>\r\n', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 1, 1),
(381, 'Organízate mejor con la bandeja de entrada de Gmail', '<!DOCTYPE html>\r\n<html><head><meta http-equiv="content-type" content="text/html;charset=UTF-8" /><title>Organízate mejor con la bandeja de entrada de Gmail</title></head><body style="background-color:#e5e5e5; margin:20px 0;"><br /><div style="margin:2%;"><div style="direction:ltr; text-align:left; font-family:''Open sans'',''Arial'',sans-serif; color:#444; background-color:white; padding:1.5em; border-radius:1em; box-shadow:1px -5px 8px 2px #bbb; max-width:580px; margin:2% auto 0 auto;"><table style="background:white;width:100%"><tr><td><div style="width:90px; height:54px; margin:10px auto;"><img src="https://services.google.com/fh/files/emails/google_logo_flat_90_color.png" alt="Google" width="90" height="34"/></div><div style="width:90%; padding-bottom:10px; padding-left:15px"><p><img alt="" aria-hidden="true" src="https://ssl.gstatic.com/ui/v1/icons/mail/images/gmail_logo_large.png" style="display:inline-block; max-height:10px; margin-right:5px;"/><span style="font-family:''Open sans'',''Arial'',sans-serif; font-weight:bold; font-size:small; line-height:1.4em">Hola, Cliente:</span></p><p><span style="font-family:''Open sans'',''Arial'',sans-serif; font-size:2.08em;">Con la bandeja de entrada de Gmail, tú lo controlas todo</span><br/></p></div><p></p><div style="clear:both; float:left; padding: 0px 5px 10px 10px; vertical-align:top;"><a href="https://www.youtube.com/watch?v=CFf7dlewJus" style="text-decoration:none; border:0;"><img alt="Vídeo sobre la bandeja de entrada" width="129" height="129" style="border:0" src="https://ssl.gstatic.com/mail/welcome/localized/es/welcome_video_2.png"/></a></div><div style="float:left; vertical-align:middle; padding:10px; max-width:398px; float:left;"><table style="vertical-align:middle;"><tr><td style="font-family:''Open sans'',''Arial'',sans-serif;"><span style="font-size:20px;">Te presentamos la bandeja de entrada</span><br/><br/><span style="font-size:small; line-height:1.4em">La bandeja de entrada de Gmail ordena tu correo por categorías: de un vistazo sabes qué mensajes nuevos hay y decides qué mensajes leer y cuándo hacerlo o si quieres ver a la vez todos los del mismo tipo. <a href="https://www.youtube.com/watch?v=CFf7dlewJus" style="text-decoration:none; color:#15C">Ver vídeo</a></span></td></tr></table></div><div style="float:left; clear:both; padding:0px 5px 10px 10px;"><img src="https://ssl.gstatic.com/mail/welcome/localized/es/welcome_inbox_tab_2.png" alt="Pestaña Social" style="display:block;"width="129"height="129"/></div><div style="float:left; vertical-align:middle; padding:10px; max-width:398px; float:left;"><table style="vertical-align:middle;"><tr><td style="font-family:''Open sans'',''Arial'',sans-serif;"><span style="font-size:20px;">Elige tus categorías</span><br/><br/><span style="font-size:small; line-height:1.4em">Las categorías Social y Promociones están activadas de forma predeterminada. Añade categorías (Notificaciones o Foros, por ejemplo) o quita otras si quieres ver esos correos en la bandeja Prioritarios. <a href="https://support.google.com/mail/?hl=es&amp;p=inboxcategories_all" style="text-decoration:none; color:#15C">Aprende a elegir categorías</a></span></td></tr></table></div><div style="float:left; clear:both; padding:0px 5px 10px 10px;"><img src="https://ssl.gstatic.com/mail/welcome/localized/es/welcome_customize_2.png" alt="Personaliza" style="display:block;"width="129"height="129"/></div><div style="float:left; vertical-align:middle; padding:10px; max-width:398px; float:left;"><table style="vertical-align:middle;"><tr><td style="font-family:''Open sans'',''Arial'',sans-serif;"><span style="font-size:20px;">Personaliza tu bandeja de entrada</span><br/><br/><span style="font-size:small; line-height:1.4em">Si ves un mensaje que quieras clasificar en otra categoría, cámbialo a ella. En los dispositivos móviles puedes elegir de qué categorías quieres recibir notificaciones. <a href="https://support.google.com/mail/?hl=es&amp;p=inboxcategories_all" style="text-decoration:none; color:#15C">Más consejos para personalizar tu Gmail</a></span></td></tr></table></div><br/><br/><br/><div style="clear: both; vertical-align:middle; padding-left:15px; line-height:1.4em; font-family:''Open sans'',''Arial'',sans-serif; font-size: small; text-align: left">Si quieres conocer mejor la nueva bandeja de entrada Gmail, ve al <a href="https://support.google.com/mail/?hl=es&amp;p=inboxcategories_all" style="text-decoration:none; color:#15C">centro de ayuda</a> o echa un vistazo a <a href="https://www.youtube.com/watch?v=CFf7dlewJus&amp" style="text-decoration:none; color:#15C">este vídeo</a>.</div><br/><br/>\r\n<div style="clear:both; padding-left:13px; height:6.8em;"><table style="width:100%; border-collapse:collapse; border:0"><tr><td style="width:68px"><img alt=''Icono de Gmail'' width="49" height="37" src="https://ssl.gstatic.com/ui/v1/icons/mail/images/gmail_logo_large.png" style="display:block;"/></td><td style="align:left; font-family:''Open sans'',''Arial'',sans-serif; vertical-align:bottom"><span style="font-size:small">Que disfrutes de tu correo,<br/></span><span style="font-size:x-large; line-height:1">El equipo de Gmail</span></td></tr></table></div>\r\n</td></tr></table></div>\r\n<div style="direction:ltr;color:#777; font-size:0.8em; border-radius:1em; padding:1em; margin:0 auto 4% auto; font-family:''Arial'',''Helvetica'',sans-serif; text-align:center;">© 2015 Google Inc. 1600 Amphitheatre Parkway, Mountain View, CA 94043<br/></div></div></body></html>\r\n', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 1, 1),
(382, 'lalala', '<div dir="ltr">Gil</div>\r\n', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 1, 1),
(383, 'Holi', '<html><body><div style="color:#000; background-color:#fff; font-family:HelveticaNeue, Helvetica Neue, Helvetica, Arial, Lucida Grande, sans-serif;font-size:16px"><div id="yui_3_16_0_1_1440369311172_2443">Prueba</div></div></body></html>', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 2, 1),
(384, 'Prueba 1', '<html><body><div style="color:#000; background-color:#fff; font-family:HelveticaNeue, Helvetica Neue, Helvetica, Arial, Lucida Grande, sans-serif;font-size:16px"><div id="yui_3_16_0_1_1440369311172_5465" dir="ltr">asdad</div></div></body></html>', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 2, 1),
(385, 'Re: Dale', '<div dir="ltr">gil<img alt="30.jpg" class="kr" style="max-width: 100%; opacity: 1;" src="cid:14f5cfb4dee59c214d01"><div class="gmail_quote"><div dir="ltr">El dom., 23 de ago. de 2015 a la(s) 8:34 p. m., &lt;<a href="mailto:clientedecorreotp@yahoo.com">clientedecorreotp@yahoo.com</a>&gt; escribió:<br></div><blockquote class="gmail_quote" style="margin:0 0 0 .8ex;border-left:1px #ccc solid;padding-left:1ex">DALE<br>\r\n<br>\r\n</blockquote></div></div>\r\n', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 2, 1),
(386, 'lalala', '<div dir="ltr">Gil</div>\r\n', 'RECIBIDO', '23/08/2015 12:00:00 a.m.', 0, 2, 1);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuenta`
--

CREATE TABLE IF NOT EXISTS `cuenta` (
  `idcuenta` int(20) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(100) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `server_idserver` int(20) DEFAULT NULL,
  PRIMARY KEY (`idcuenta`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `cuenta`
--

INSERT INTO `cuenta` (`idcuenta`, `usuario`, `password`, `server_idserver`) VALUES
(1, 'clientedecorreotp@gmail.com', 'frcu2010', 1),
(2, 'clientedecorreotp@yahoo.com', 'frcu2010', 2);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `origendestino`
--

CREATE TABLE IF NOT EXISTS `origendestino` (
  `idorigendestino` int(20) NOT NULL AUTO_INCREMENT,
  `direccion` varchar(100) DEFAULT NULL,
  `cc` tinyint(1) DEFAULT NULL,
  `cco` tinyint(1) DEFAULT NULL,
  `correo_idcorreo` int(20) DEFAULT NULL,
  PRIMARY KEY (`idorigendestino`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=384 ;

--
-- Volcado de datos para la tabla `origendestino`
--

INSERT INTO `origendestino` (`idorigendestino`, `direccion`, `cc`, `cco`, `correo_idcorreo`) VALUES
(376, 'mail-noreply@google.com', 0, 0, 379),
(377, 'mail-noreply@google.com', 0, 0, 380),
(378, 'mail-noreply@google.com', 0, 0, 381),
(379, 'clientedecorreotp@gmail.com', 0, 0, 382),
(380, 'clientedecorreotp@yahoo.com', 0, 0, 383),
(381, 'clientedecorreotp@yahoo.com', 0, 0, 384),
(382, 'ivanebel@gmail.com', 0, 0, 385),
(383, 'clientedecorreotp@gmail.com', 0, 0, 386);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `server`
--

CREATE TABLE IF NOT EXISTS `server` (
  `idserver` int(20) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `popurl` varchar(100) DEFAULT NULL,
  `popport` int(20) DEFAULT NULL,
  `smtpurl` varchar(100) DEFAULT NULL,
  `smtpport` int(20) DEFAULT NULL,
  `isssl` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idserver`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=3 ;

--
-- Volcado de datos para la tabla `server`
--

INSERT INTO `server` (`idserver`, `nombre`, `popurl`, `popport`, `smtpurl`, `smtpport`, `isssl`) VALUES
(1, 'gmail', 'pop.gmail.com', 995, 'smtp.gmail.com', 587, 1),
(2, 'yahoo', 'pop.mail.yahoo.com', 995, 'smtp.mail.yahoo.com', 587, 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
