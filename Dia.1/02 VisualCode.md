Tres proyectos:

Empty
(WebApi ()  Y WebAplication (mvc)) se fusionan en un unico paquete llamado MVC Core

Core pipeline

Request => middle ware 1 x n => Response

ASPNET Web Server (Kestrel)

------------------------------------------------------------------------------------------------------------------------------

Exploring ASPNET Core Application

Startup.cs => punto de entrada de app

puedo configurar cadenas de conexión user names, read config file => Constructor
Adiciono clases

Connected services => azure

--------------------------------------------------------------------------------------------------------------------------------

MiddleWare es una o varias clases, organización para bussiness logic

SOLID

¿Que hace un middleware?

Puede manejar un request y generar una respuesta
Procesar un request HTTP modificarlo u enviarlo a otro middleware
procesar un response HTTP modificarlo u enviarlo a otro middleware

logging tiempo de respuesta de un request

offtopic => async await (wait)

--------------------------------------------------------------------------------------------------------------------------------

Demo: Middleware - WelcomePage

Metodo de extensión: I

--------------------------------------------------------------------------------------------------------------------------------

Configurar el middleware de MVC
adicionar paquete
adicionar middleware mvc
configurar el mvc
crear carpeta controllers
adicionar homecontroller
adicionar index y devolver el texto plano
run



