use GRUPO2
go

Delete from TAREA_RA
Delete from RA
Delete from MODULOS
Delete from TAREAS
Delete from JORNADAS
Delete from ALUMNOS
Delete from CICLOS


INSERT INTO CICLOS (ID_CICLO,NOMBRECICLO)
VALUES (1,'1�DAM')


INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES
(1,1, 'Programaci�n'),
(1,2, 'Bases de Datos'),
(1,3, 'Sistemas Inform�ticos'),
(1,4, 'Lenguajes de Marcas'),
(1,5, 'Entornos de Desarrollo'),
(1,6, 'Itinerario Personal para la Empleabilidad'),
(1,7, 'Sostenibilidad'),
(1,8, 'Digitalizaci�n'),
(1,9, 'Ingl�s');



INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA) VALUES
-- Programaci�n (1)
(1,1,1,'Reconoce la estructura de un programa inform�tico'),
(2,1,1,'Escribe programas utilizando un lenguaje de programaci�n'),
(3,1,1,'Utiliza estructuras de control'),
(4,1,1,'Desarrolla programas mediante funciones'),

-- Bases de Datos (2)
(5,2,1,'Reconoce los elementos de una base de datos'),
(6,2,1,'Crea bases de datos relacionales'),
(7,2,1,'Realiza consultas SQL'),

-- Sistemas Inform�ticos (3)
(8,3,1,'Instala sistemas operativos'),
(9,3,1,'Configura sistemas inform�ticos'),

-- Lenguajes de Marcas (4)
(10,4,1,'Reconoce lenguajes de marcas'),
(11,4,1,'Elabora documentos XML y HTML'),	

-- Entornos de Desarrollo (5)
(12,5,1,'Reconoce entornos de desarrollo'),
(13,5,1,'Utiliza herramientas de programaci�n'),

-- Itinerario Personal para la Empleabilidad (6)
(14,6,1,'Identifica oportunidades de empleo'),
(15,6,1,'Desarrolla habilidades profesionales'),

-- Sostenibilidad (7)
(16,7,1,'Aplica principios de sostenibilidad'),
(17,7,1,'Analiza impacto ambiental'),

-- Digitalizaci�n (8)
(18,8,1,'Comprende procesos de digitalizaci�n'),
(19,8,1,'Utiliza herramientas digitales'),

-- Programaci�n (repetido 9)
(20,9,1,'Aplica t�cnicas avanzadas de programaci�n'),
(21,9,1,'Optimiza c�digo'),

-- Ingl�s (10)
(22,10,1,'Comprende documentaci�n t�cnica en ingl�s'),
(23,10,1,'Se comunica en ingl�s en entorno profesional');


INSERT INTO CICLOS (ID_CICLO,NOMBRECICLO) 
VALUES (2,'2�DAM');

INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES 
(2,1, 'Acceso a Datos'),
(2,2, 'Desarrollo de Interfaces'),
(2,3, 'Programaci�n Multimedia y Dispositivos M�viles'),
(2,4, 'Programaci�n de Servicios y Procesos'),
(2,5, 'Sistemas de Gesti�n Empresarial'),
(2,6, 'Empresa e Iniciativa Emprendedora'),
(2,7, 'Proyecto de Desarrollo de Aplicaciones Multiplataforma'),
(2,8, 'Formaci�n en Centros de Trabajo');


INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA) VALUES 

-- Acceso a Datos
(1,1,2,'Desarrolla aplicaciones que gestionan informaci�n en bases de datos relacionales'),
(2,1,2,'Implementa acceso a datos mediante ficheros'),
(3,1,2,'Gestiona persistencia de objetos'),

-- Desarrollo de Interfaces
(4,2,2,'Dise�a interfaces gr�ficas de usuario'),
(5,2,2,'Desarrolla aplicaciones con interfaces adaptativas'),
(6,2,2,'Aplica criterios de usabilidad y accesibilidad'),

-- Programaci�n Multimedia y M�viles
(7,3,2,'Desarrolla aplicaciones multimedia'),
(8,3,2,'Programa aplicaciones para dispositivos m�viles'),
(9,3,2,'Gestiona recursos multimedia'),

-- Servicios y Procesos
(10,4,2,'Desarrolla aplicaciones concurrentes'),
(11,4,2,'Programa servicios en red'),
(12,4,2,'Gestiona procesos del sistema'),

-- Sistemas de Gesti�n Empresarial
(13,5,2,'Instala sistemas ERP'),
(14,5,2,'Configura m�dulos empresariales'),
(15,5,2,'Desarrolla adaptaciones en sistemas ERP'),

-- Empresa
(16,6,2,'Reconoce oportunidades de negocio'),
(17,6,2,'Elabora un plan de empresa'),

-- Proyecto
(18,7,2,'Desarrolla un proyecto completo de aplicaci�n'),
(19,7,2,'Documenta y presenta el proyecto'),

-- FCT
(20,8,2,'Se integra en el entorno laboral'),
(21,8,2,'Aplica competencias profesionales en empresa');

INSERT INTO CICLOS (ID_CICLO,NOMBRECICLO) 
VALUES (3,'1�ASIR');

INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES 
(3,1, 'Implantaci�n de Sistemas Operativos'),
(3,2, 'Planificaci�n y Administraci�n de Redes'),
(3,3, 'Fundamentos de Hardware'),
(3,4, 'Gesti�n de Bases de Datos'),
(3,5, 'Lenguajes de Marcas y Sistemas de Gesti�n de Informaci�n')

INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA) VALUES 

-- Implantaci�n de Sistemas Operativos
(1,1,3,'Instala sistemas operativos'),
(2,1,3,'Configura sistemas operativos'),
(3,1,3,'Gestiona recursos del sistema'),

-- Redes
(4,2,3,'Configura infraestructuras de red'),
(5,2,3,'Administra dispositivos de red'),
(6,2,3,'Resuelve incidencias de conectividad'),

-- Hardware
(7,3,3,'Identifica componentes hardware'),
(8,3,3,'Monta y configura equipos'),
(9,3,3,'Diagnostica fallos f�sicos'),

-- Bases de datos
(10,4,3,'Instala gestores de bases de datos'),
(11,4,3,'Administra bases de datos'),
(12,4,3,'Realiza copias de seguridad'),

-- Lenguajes de marcas
(13,5,3,'Elabora documentos XML'),
(14,5,3,'Gestiona informaci�n estructurada'),

-- Administraci�n de SO
(15,6,3,'Administra usuarios y permisos'),
(16,6,3,'Automatiza tareas del sistema'),
(17,6,3,'Supervisa rendimiento'),

-- Servicios de red
(18,7,3,'Configura servicios web'),
(19,7,3,'Administra servicios de red'),
(20,7,3,'Implementa servicios de correo'),

-- Aplicaciones web
(21,8,3,'Implanta aplicaciones web'),
(22,8,3,'Configura servidores de aplicaciones'),

-- SGBD
(23,9,3,'Administra SGBD'),
(24,9,3,'Optimiza consultas'),

-- Seguridad
(25,10,3,'Aplica medidas de seguridad'),
(26,10,3,'Configura sistemas de alta disponibilidad'),

-- Proyecto
(27,11,3,'Desarrolla proyecto ASIR'),
(28,11,3,'Documenta y presenta proyecto'),

-- FCT
(29,12,3,'Se integra en la empresa'),
(30,12,3,'Aplica competencias profesionales');


INSERT INTO CICLOS (ID_CICLO,NOMBRECICLO) 
VALUES (4,'2�ASIR');

INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES 
(3,13, 'Administraci�n de Sistemas Operativos'),
(3,14, 'Servicios de Red e Internet'),
(3,15, 'Implantaci�n de Aplicaciones Web'),
(3,16, 'Administraci�n de Sistemas Gestores de Bases de Datos'),
(3,17, 'Seguridad y Alta Disponibilidad'),
(3,18, 'Proyecto de Administraci�n de Sistemas Inform�ticos en Red'),
(3,19, 'Formaci�n en Centros de Trabajo');

INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA	) VALUES 

-- Administraci�n de SO
(31,13,3,'Administra sistemas operativos en red'),
(32,13,3,'Gestiona usuarios, grupos y permisos'),
(33,13,3,'Automatiza tareas de administraci�n'),

-- Servicios de red
(34,14,3,'Configura servicios web'),
(35,14,3,'Administra servicios de red'),
(36,14,3,'Implementa servicios de correo y DNS'),

-- Aplicaciones web
(37,15,3,'Implanta aplicaciones web'),
(38,15,3,'Administra servidores de aplicaciones'),
(39,15,3,'Configura entornos de ejecuci�n'),

-- SGBD
(40,16,3,'Administra sistemas gestores de bases de datos'),
(41,16,3,'Optimiza el rendimiento de bases de datos'),
(42,16,3,'Garantiza la seguridad y disponibilidad'),

-- Seguridad
(43,17,3,'Aplica medidas de seguridad en sistemas'),
(44,17,3,'Configura sistemas de alta disponibilidad'),
(45,17,3,'Supervisa incidencias de seguridad'),

-- Proyecto
(46,18,3,'Desarrolla un proyecto integral ASIR'),
(47,18,3,'Documenta y presenta el proyecto'),

-- FCT
(48,19,3,'Se integra en el entorno laboral'),
(49,19,3,'Aplica competencias profesionales en empresa');

--INSERT DE ALUMNOS
INSERT INTO ALUMNOS (DNI, NOMBRE, APELLIDO1, APELLIDO2, ID_CICLO) VALUES
('12345678Z', 'Maxim', 'Perez', 'Lopez', 1),
('23456789D', 'Carlos', 'Garcia', 'Martinez', 1),
('34567890V', 'Lucia', 'Fernandez', 'Sanchez', 2),
('45678901G', 'Marta', 'Gomez', 'Ruiz', 2),
('56789012B', 'Pablo', 'Diaz', 'Hernandez', 1);

-- INSERT DE JORNADAS
INSERT INTO JORNADAS (DNI, ID_JORNADA, HORAS, FECHA_ENTRADA, ESTADO) VALUES
-- HOY
('12345678Z', 1, 8, GETDATE(), 'EN CURSO'),
('23456789D', 2, 6, DATEADD(HOUR, -2, GETDATE()), 'EN CURSO'),

-- HACE 5 DIAS
('34567890V', 3, 4, DATEADD(DAY, -5, GETDATE()), 'REALIZADO'),

-- AYER
('45678901G', 4, 8, DATEADD(DAY, -1, GETDATE()), 'REALIZADO'),

-- HACE 2 DIAS
('56789012B', 5, 7, DATEADD(DAY, -2, GETDATE()), 'REALIZADO'),

-- HOY SIN EMPEZAR
('12345678Z', 6, 5, DATEADD(HOUR, -1, GETDATE()), 'SIN EMPEZAR');

ALTER TABLE JORNADAS WITH CHECK CHECK CONSTRAINT ALL;


-- INSERT DE TAREAS
INSERT INTO TAREAS (DNI, ID_JORNADA, ID_TAREA, HORAS, DESCRIPCION) VALUES

-- Jornada 1 (Total = 6h / 8h)
('12345678Z', 1, 1, 2, 'Analisis de requisitos'),
('12345678Z', 1, 2, 3, 'Desarrollo backend'),
('12345678Z', 1, 3, 1, 'Reunion equipo'),

-- Jornada 2 (Total = 4.5h / 6h)
('23456789D', 2, 1, 2, 'Diseño base de datos'),
('23456789D', 2, 2, 1.5, 'Implementación consultas'),
('23456789D', 2, 3, 1, 'Testing'),

-- Jornada 3 (Total = 3h / 4h)
('34567890V', 3, 1, 2, 'Maquetación UI'),
('34567890V', 3, 2, 1, 'Corrección errores'),

-- Jornada 4 (Total = 5h / 8h)
('45678901G', 4, 1, 3, 'Documentación'),
('45678901G', 4, 2, 2, 'Revisión código'),

-- Jornada 5 (Total = 6h / 7h)
('56789012B', 5, 1, 2, 'Investigación'),
('56789012B', 5, 2, 3, 'Implementación funcionalidad'),
('56789012B', 5, 3, 1, 'Pruebas'),

-- Jornada 6 (Total = 2.5h / 5h)
('12345678Z', 6, 1, 1, 'Preparación entorno'),
('12345678Z', 6, 2, 1.5, 'Planificación tareas');

-- INSERT DE TAREA_RA
INSERT INTO TAREA_RA (ID_CICLO, ID_MODULO, ID_RA, DNI, ID_JORNADA, ID_TAREA) VALUES

-- MAXIM (1º DAM)

-- Jornada 1
(1,1,2,'12345678Z',1,1), -- Programación
(1,2,7,'12345678Z',1,2), -- Bases de Datos
(1,5,12,'12345678Z',1,3), -- Entornos

-- Jornada 6
(1,3,8,'12345678Z',6,1), -- Sistemas
(1,6,14,'12345678Z',6,2), -- IPE


-- CARLOS (1º DAM)

-- Jornada 2
(1,2,6,'23456789D',2,1), -- Bases de Datos
(1,2,7,'23456789D',2,2), -- Bases de Datos
(1,5,13,'23456789D',2,3), -- Entornos


-- LUCIA (2º DAM)

-- Jornada 3
(2,2,4,'34567890V',3,1), -- Desarrollo Interfaces
(2,2,5,'34567890V',3,2), -- Desarrollo Interfaces


-- MARTA (2º DAM)

-- Jornada 4
(2,6,16,'45678901G',4,1), -- Empresa
(2,7,18,'45678901G',4,2), -- Proyecto


-- PABLO (1º DAM)

-- Jornada 5
(1,5,12,'56789012B',5,1), -- Entornos
(1,1,3,'56789012B',5,2), -- Programación
(1,1,4,'56789012B',5,3); -- Programación