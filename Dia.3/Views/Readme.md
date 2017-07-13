Componente que ve el usuario

CSS

JavaScript

en MVC es de tipo cshtml por razor

Desde un controlador se puede enviar informacion a las vista:

ViewModel : Vista fuertemente tipada, la vista sabe exactamente el tipo de dato que le estoy pasando (Recomendado)
ViewData: data
ViewBag: viewBag.Nombre o .Apellido y son las propiedades es un Dynamic

TagHelper: Mejoras de sintaxis. Comparado con los tagHelper de razór son mas sencillos de modificar

Vistas parciales: deben ir dentro de una vista, no se puede mostrar sola.

View Components: Tienen un codebehind detras

------------------------------------------------------------------------------------------------------------------------

¿El tagHelper reemplaza el class?: Rta: no, son propiedades en el objeto.