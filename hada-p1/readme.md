Sirvent Navarro, Álvaro
Práctica 1a

P1-> Al ejecutar el comando revert con la opción -n, lo que estamos haciendo es que no se realize el commit correspondiente cuando hacemos la recuperación del archivo.
Pasando de este modo al area de preparación.

P2-> Al realizar el comando reset, lo que ha sucedido es que hemos recuperado lo que teníamos en la rama del HEAD, pero esta vez, directamente se nos guardará de nuevo en el repositorio local.

P3-> Como ya he dicho en la pregunta anterior, una de las diferencias clave es que pasa directamente lo que tengamos en el Head de manera que no habrá que poner el alias Head en la llamada al comando como sucedía con revert.
Por otro lado, vemos que al haber utilizado la opción -n en el comando revert. Los archivos recuperados se quedaban en el area de preparación, teniendo que hacer así su commit correspondiente para subirlos al repositorio local. 
Cosa que no sucedía haciendo uso del comando reset, dado que este realiza el commit correspondiente directamente. 
Además, el reset mueve el puntero y el revert copia el último commit que se ha realizado. 