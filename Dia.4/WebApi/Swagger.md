en Startup.cs se hace un lamnbda para definir quien  realiza el servicio

luego

basePath la ruta donde esta la documentación

Options que es la variable de configuracion de swagger, se le dice la ruta dónde generar ese xml

Propiedades del proyecto: Build - XML documentation file

xml documentation file

-----------------------------------------------------------------------------------------------------------------------------------

por defecto solo carga la informaciòn de controladores que se desarrollan routing por atributos

Configure: StartUp 

app.UseSwagger() => genera un json con la información del servicio

app.SwaggerUI(options => json adicional)

-----------------------------------------------------------------------------------------------------------------------------------

Swagger : => tengo la documentación del servicio.

localhost:4568/swagger ...

library.api.xml => es el archivo de la documentación del código

