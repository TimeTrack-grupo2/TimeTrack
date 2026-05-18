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
VALUES (1,'1ºDAM')


INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES
(1,1, 'Programación'),
(1,2, 'Bases de Datos'),
(1,3, 'Sistemas Informáticos'),
(1,4, 'Lenguajes de Marcas'),
(1,5, 'Entornos de Desarrollo'),
(1,6, 'Itinerario Personal para la Empleabilidad'),
(1,7, 'Sostenibilidad'),
(1,8, 'Digitalización'),
(1,9, 'Programación'),
(1,10, 'Inglés');



INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA) VALUES
-- Programación (1)
(1,1,1,'Reconoce la estructura de un programa informático'),
(2,1,1,'Escribe programas utilizando un lenguaje de programación'),
(3,1,1,'Utiliza estructuras de control'),
(4,1,1,'Desarrolla programas mediante funciones'),

-- Bases de Datos (2)
(5,2,1,'Reconoce los elementos de una base de datos'),
(6,2,1,'Crea bases de datos relacionales'),
(7,2,1,'Realiza consultas SQL'),

-- Sistemas Informáticos (3)
(8,3,1,'Instala sistemas operativos'),
(9,3,1,'Configura sistemas informáticos'),

-- Lenguajes de Marcas (4)
(10,4,1,'Reconoce lenguajes de marcas'),
(11,4,1,'Elabora documentos XML y HTML'),	

-- Entornos de Desarrollo (5)
(12,5,1,'Reconoce entornos de desarrollo'),
(13,5,1,'Utiliza herramientas de programación'),

-- Itinerario Personal para la Empleabilidad (6)
(14,6,1,'Identifica oportunidades de empleo'),
(15,6,1,'Desarrolla habilidades profesionales'),

-- Sostenibilidad (7)
(16,7,1,'Aplica principios de sostenibilidad'),
(17,7,1,'Analiza impacto ambiental'),

-- Digitalización (8)
(18,8,1,'Comprende procesos de digitalización'),
(19,8,1,'Utiliza herramientas digitales'),

-- Programación (repetido 9)
(20,9,1,'Aplica técnicas avanzadas de programación'),
(21,9,1,'Optimiza código'),

-- Inglés (10)
(22,10,1,'Comprende documentación técnica en inglés'),
(23,10,1,'Se comunica en inglés en entorno profesional');


INSERT INTO CICLOS (ID_CICLO,NOMBRECICLO) 
VALUES (2,'2ºDAM');

INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES 
(2,1, 'Acceso a Datos'),
(2,2, 'Desarrollo de Interfaces'),
(2,3, 'Programación Multimedia y Dispositivos Móviles'),
(2,4, 'Programación de Servicios y Procesos'),
(2,5, 'Sistemas de Gestión Empresarial'),
(2,6, 'Empresa e Iniciativa Emprendedora'),
(2,7, 'Proyecto de Desarrollo de Aplicaciones Multiplataforma'),
(2,8, 'Formación en Centros de Trabajo');


INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA) VALUES 

-- Acceso a Datos
(1,1,2,'Desarrolla aplicaciones que gestionan información en bases de datos relacionales'),
(2,1,2,'Implementa acceso a datos mediante ficheros'),
(3,1,2,'Gestiona persistencia de objetos'),

-- Desarrollo de Interfaces
(4,2,2,'Diseña interfaces gráficas de usuario'),
(5,2,2,'Desarrolla aplicaciones con interfaces adaptativas'),
(6,2,2,'Aplica criterios de usabilidad y accesibilidad'),

-- Programación Multimedia y Móviles
(7,3,2,'Desarrolla aplicaciones multimedia'),
(8,3,2,'Programa aplicaciones para dispositivos móviles'),
(9,3,2,'Gestiona recursos multimedia'),

-- Servicios y Procesos
(10,4,2,'Desarrolla aplicaciones concurrentes'),
(11,4,2,'Programa servicios en red'),
(12,4,2,'Gestiona procesos del sistema'),

-- Sistemas de Gestión Empresarial
(13,5,2,'Instala sistemas ERP'),
(14,5,2,'Configura módulos empresariales'),
(15,5,2,'Desarrolla adaptaciones en sistemas ERP'),

-- Empresa
(16,6,2,'Reconoce oportunidades de negocio'),
(17,6,2,'Elabora un plan de empresa'),

-- Proyecto
(18,7,2,'Desarrolla un proyecto completo de aplicación'),
(19,7,2,'Documenta y presenta el proyecto'),

-- FCT
(20,8,2,'Se integra en el entorno laboral'),
(21,8,2,'Aplica competencias profesionales en empresa');

INSERT INTO CICLOS (ID_CICLO,NOMBRECICLO) 
VALUES (3,'1ºASIR');

INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES 
(3,1, 'Implantación de Sistemas Operativos'),
(3,2, 'Planificación y Administración de Redes'),
(3,3, 'Fundamentos de Hardware'),
(3,4, 'Gestión de Bases de Datos'),
(3,5, 'Lenguajes de Marcas y Sistemas de Gestión de Información'),
(3,6, 'Administración de Sistemas Operativos'),
(3,7, 'Servicios de Red e Internet'),
(3,8, 'Implantación de Aplicaciones Web'),
(3,9, 'Administración de Sistemas Gestores de Bases de Datos'),
(3,10, 'Seguridad y Alta Disponibilidad'),
(3,11, 'Proyecto de Administración de Sistemas Informáticos en Red'),
(3,12, 'Formación en Centros de Trabajo');

INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA) VALUES 

-- Implantación de Sistemas Operativos
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
(9,3,3,'Diagnostica fallos físicos'),

-- Bases de datos
(10,4,3,'Instala gestores de bases de datos'),
(11,4,3,'Administra bases de datos'),
(12,4,3,'Realiza copias de seguridad'),

-- Lenguajes de marcas
(13,5,3,'Elabora documentos XML'),
(14,5,3,'Gestiona información estructurada'),

-- Administración de SO
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
VALUES (4,'2ºASIR');

INSERT INTO MODULOS (id_ciclo, id_modulo, MODULO) VALUES 
(3,13, 'Administración de Sistemas Operativos'),
(3,14, 'Servicios de Red e Internet'),
(3,15, 'Implantación de Aplicaciones Web'),
(3,16, 'Administración de Sistemas Gestores de Bases de Datos'),
(3,17, 'Seguridad y Alta Disponibilidad'),
(3,18, 'Proyecto de Administración de Sistemas Informáticos en Red'),
(3,19, 'Formación en Centros de Trabajo');

INSERT INTO RA (id_ra, id_modulo, id_ciclo, RA	) VALUES 

-- Administración de SO
(31,13,3,'Administra sistemas operativos en red'),
(32,13,3,'Gestiona usuarios, grupos y permisos'),
(33,13,3,'Automatiza tareas de administración'),

-- Servicios de red
(34,14,3,'Configura servicios web'),
(35,14,3,'Administra servicios de red'),
(36,14,3,'Implementa servicios de correo y DNS'),

-- Aplicaciones web
(37,15,3,'Implanta aplicaciones web'),
(38,15,3,'Administra servidores de aplicaciones'),
(39,15,3,'Configura entornos de ejecución'),

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

--INSERT DE JORNADAS
INSERT INTO JORNADAS (DNI, ID_JORNADA, HORAS, FECHA_ENTRADA, ESTADO) VALUES
-- HOY
('12345678Z', 1, 8, GETDATE(), 'EN CURSO'),
('23456789D', 2, 6, DATEADD(HOUR, -2, GETDATE()), 'EN CURSO'),
('34567890V', 3, 4, DATEADD(HOUR, -5, GETDATE()), 'REALIZADO'),

-- AYER
('45678901G', 4, 8, DATEADD(DAY, -1, GETDATE()), 'REALIZADO'),

-- HACE 2 DIAS
('56789012B', 5, 7, DATEADD(DAY, -2, GETDATE()), 'REALIZADO'),

-- HOY SIN EMPEZAR
('12345678Z', 6, 5, DATEADD(HOUR, -1, GETDATE()), 'SIN EMPEZAR');

ALTER TABLE JORNADAS WITH CHECK CHECK CONSTRAINT ALL;

--INSERT DE TAREAS
INSERT INTO TAREAS (DNI, ID_JORNADA, ID_TAREA, HORAS, DESCRIPCION) VALUES

-- Jornada 1
('12345678Z', 1, 1, 2, 'Analisis de requisitos'),
('12345678Z', 1, 2, 3, 'Desarrollo backend'),
('12345678Z', 1, 3, 1, 'Reunión equipo'),

-- Jornada 2
('23456789D', 2, 1, 2, 'Diseño base de datos'),
('23456789D', 2, 2, 1.5, 'Implementación consultas'),
('23456789D', 2, 3, 1, 'Testing'),

-- Jornada 3
('34567890V', 3, 1, 2, 'Maquetación UI'),
('34567890V', 3, 2, 1, 'Corrección errores'),

-- Jornada 4
('45678901G', 4, 1, 3, 'Documentación'),
('45678901G', 4, 2, 2, 'Revisión código'),

-- Jornada 5
('56789012B', 5, 1, 2, 'Investigación'),
('56789012B', 5, 2, 3, 'Implementación funcionalidad'),
('56789012B', 5, 3, 1, 'Pruebas'),

-- Jornada 6
('12345678Z', 6, 1, 1, 'Preparación entorno'),
('12345678Z', 6, 2, 1.5, 'Planificación tareas');