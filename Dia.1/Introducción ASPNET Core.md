Historia:

1 - Visual Basic 4/6 - App de escritorio
2 - ASPNET Web Forms VS 2003 .Net Framework 1.1
3 - ASPNET MVC .Net Framework 4. | 2008/2009
4 - ASPNET Web API (NO MVC) .Net Framework | 2012 | No System.Web
5 - ASPNET Core .Net Framework 4.6 | .Net Core
6 - ASPNET Core & Web Assembly ?

Web Forms: Update panel

SingalR : Comunicación punto a punto : Tiempo real. | Es un prj de WebSockets Server | Comunicación en Tiempo real

HTML : => HTML5 2004 => HTML5

Javascript toma fuerza => esta en el browser

Phonegap / Apache Corova

Node.js / para Server

5 - ASPNET Core : Modular, extensible, multiplataforma

¿Interesante? : Se puede usar con .Net Framework o con .Net Core

6 - WebAssembly ¿? : Web Assembly si el proyecto sigue modular y como piensa la comunidad sera muy usable.


-----------------------------------------------------------------------------------------------------------------------------------------------------------------


Que estaba mal con Web Forms

View State : Session
Poco control del HTML : Paginación grids
Complicado de testear : Escalando el hardware :(
Ciclo de vida pesado : Render, prerender, oninit, onload
Poca integración JS : Poca integración con js backbone, kcnock 
Poca integración con HTML5 : No se explota el canvas, storage, sockets, workers, history
Dependencia de System.Web :IIS
Lenta evolución : New VS, new Framework
Abstracciones : Abstracciones sobre abstracciones


-----------------------------------------------------------------------------------------------------------------------------------------------------------------

Que estaba mal de MVC

Dependencia a System.web
Dependencia al .Net Framework
Lenta evolución
No creado para la nube
En Realidad es ASPNET


-----------------------------------------------------------------------------------------------------------------------------------------------------------------

Bienvenido ASPNET Core


Que viene a solucionar ASPNET Core

Soporte con ASPNET Core: NEW *
Soporte a .Net Framework: El de toda la vida
Cross-platform: Windows, Linux o Mac
No es monolitico: Instalo lo que necesito en el proyecto
Open Source: IMPORTANTE: para dónde va el proyecto, antes era una caja negra (Ahora se ve) Aportes de la comunidad
Cloud Ready: Fue pensado en cloud no en azure

"Performance is a feature" 

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

Sobre .Net Core

.Net Core es version estandar, multiplataforma
Roslyn es el nuevo compilador - Net Core


.Net Standard

Problema: .Net Framework, .Net Core desarrollo para alguna de las versiones
Solución: Al hacer un proyecto sobre .Net Standard puedo compartir mis proyectos

Generics : .Net 2.0 elimina DataTables

-----------------------------------------------------------------------------------------------------------------------------------------------------------------

Yeoman: Generador de plantillas ( como un CLI )