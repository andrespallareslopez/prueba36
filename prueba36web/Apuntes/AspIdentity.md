# Asp.Net Identity. Apuntes

>Nota:
Para conectarse por nombre netbios \\\HP no olvidar la doble barra

Paquetes necesarios:

~~~
Install-Package Microsoft.Owin
Install-Package EntityFramework
Install-Package Microsoft.AspNet.Identity.Core
Install-Package Microsoft.AspNet.Identity.EntityFramework
~~~

Tenemos que establecer una cadena de conexion en el web.config para la base de datos que vamos a utilizar.

> Observamos que muchos metodos que utiliza Identity Framework son asincronos, porque introducimos el ensamblado
> using Microsoft.AspNet.Identity.EntityFramework pero si agregamos using Microsoft.AspNet.Identity,(sin EntityFramework) introduciremos 
> los metodos sincronos





