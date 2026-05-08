# TimeTrack — Grupo 2 · Proyecto Intermodular
> Aplicación de gestión digital de la Formación en Empresa (FE) para el alumnado del Centro Integrado Cuatrovientos · 1º DAM
 
---

Los tutores/as de FE del Centro necesitan una herramienta que digitalice y centralice el seguimiento de las prácticas en empresa del alumnado. Actualmente, la gestión se realiza en papel, lo que genera dispersión documental y dificulta el acceso a la información en tiempo real.
 
**TimeTrack** nace como solución a esta necesidad: una aplicación estructurada, accesible y de consulta inmediata que permite visualizar con claridad el progreso de cada alumno/a durante su estancia en empresa.
 
---

## Integrantes

---

## Tecnologías
 
| Tecnología | Uso |
|---|---|
| **SQL Server** | Base de datos relacional para almacenamiento de alumnos, empresas, fichajes y tareas |
| **Visual Studio** | Entorno de desarrollo principal |
| **nUnit** | Framework de pruebas unitarias |
 
---

## Descripción de la arquitectura
...

### Usuarios del sistema
 
- **Alumno/a en prácticas** — Registra entrada/salida y tareas realizadas diariamente.
- **Tutor/a del Instituto** — Supervisa el progreso, horas acumuladas y alertas del alumnado.
- **Tutor/a de la empresa** — Consulta el seguimiento del alumno/a asignado/a.

### Principales funcionalidades
 
1. Configuración individualizada del perfil de prácticas (alumno/a, empresa, horas totales a realizar)
2. Registro de jornadas
3. Registro de tareas realizadas vinculadas a los Resultados de Aprendizaje del ciclo
4. Visualización en tiempo real de horas completadas y horas pendientes
5. Porcentaje de tiempo dedicado a las tareas de cada módulo
6. Cálculo y almacenamiento de horas por jornada; marcado automático del día como completado
7. **Alertas:** alta y baja en la Seguridad Social
8. **Alertas:** evaluación intermedia
9. **Alertas:** cumplimiento del total de horas (80, 100, 320, 400 o 500 h)

## Objetivo general
 
Digitalizar la gestión y seguimiento de la Formación en Empresa del alumnado, eliminando la dispersión documental y sustituyendo los registros en papel por un panel digital estructurado, accesible y de consulta inmediata.
 
