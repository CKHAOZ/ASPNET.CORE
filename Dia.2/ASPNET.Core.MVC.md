Nombre documento para certificado: check! 

---------------------------------------------------------------------------------------------------------------------------------------

Algo sobre el patrón MVC

Los controladores deben ser bien definidos "Single principle"

Ha sido pensado para ser testeable!! 

3 componentes basicos

controlador: Request => actualiza el modelo y selecciona la vista
view
model : Generalmente son los datos que se modificán, retornan o leen.

ASPNET Tiene ASPNET MVC Core que implementa este patron de arquitectura.

---------------------------------------------------------------------------------------------------------------------------------------

Controller (reuqest) Update : View, Model

View => Controller => Model

Libro:  Head First Design Patterns

https://www.amazon.com/Head-First-Design-Patterns-Brain-Friendly/dp/0596007124/ref=sr_1_1?ie=UTF8&qid=1499824460&sr=8-1&keywords=head+first+design+patterns

https://www.amazon.com/s/ref=nb_sb_ss_c_1_14/144-5168241-7034132?url=search-alias%3Daps&field-keywords=head+first+design+patterns&sprefix=head+first+des%2Caps%2C197&crid=337BZME1G64N6

MVC es un patrón e arquitectura
El libro es sobre patrones de diseño

http://nancyfx.org/

---------------------------------------------------------------------------------------------------------------------------------------

Tipos de Routing: Basado en convenciones y otro basado en atributos (mas recomendado)

tipos de resultado: XML, JSON, string, html

---------------------------------------------------------------------------------------------------------------------------------------

Pero... antes de seguir

---------------------------------------------------------------------------------------------------------------------------------------

Entidades

Modelos que vienen del sistema de persistencia
En algunos casos son el modelo del dominio DDD *New LEER SOBRE DDD
NO es necesario que sean clases planas
Deben dar un valor a un dominio
Definir 2 clases iniciales:
    Category: Una categoria que puede tener muchos libros
        Book: un libro que solo puede tener una categoria


MartinFowler.com | Arquitectura

---------------------------------------------------------------------------------------------------------------------------------------

Patrón repositorio

CQRS (Command Query Responsability Segregation) => tengo algo para las consultas y otra cosa para los comandos  *New LEER SOBRE 

DB Relacional: No son optimas
Motor de buqueda: Consultas mas rápidas
Brighter:  *New LEER SOBRE prj
Dos repositorios: CategoriRepository and bookRepository
Inyección de dependencias para la implementación de los repositorios

---------------------------------------------------------------------------------------------------------------------------------------

El viewModel esta enfocado en devolver la información que necesita la vista realmente, la entidad de EF no necesariamente es la misma data.

"El problema del código reutilizable es tener que reutilizarlo" 

Es mejor dar la minima información requerida

---------------------------------------------------------------------------------------------------------------------------------------
Pregunta:

Se hace manual el mapeo entre una entidad y una entidad de viewmodel: Se puede hacer con automapper

