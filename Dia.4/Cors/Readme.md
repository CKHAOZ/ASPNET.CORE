Opcion 1:

app.UseCors(options =>
{
    options.WithOrigins("*"); // All origins
    // Se puede configurar un token
})

Opción 2:

Creando una politica:

Service.Add.Cors(options =>{
    options.AddPolicy("MyCorsPolicy",
        builder => builder.withOrigins("*"));

    options.AddPolicy("MyCorsPolicy",
        builder => builder.withOrigins("*"));
})


En el API - se puede colocar EnableCors"Nombre de la politica"

Opción 3: 

Cors Global:

Services.Configure<MvcOptions>(options=>{
    options.Filters.add(new CorsAuthorizationFilterFactory("myCorsPolicy"));
})


Estos requieren autorización por parte del cliente:

JOSE, oauth2, JWT

