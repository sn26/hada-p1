Sirvent Navarro, Álvaro
Práctica 1a

P1-> Al ejecutar el comando revert con la opción -n, lo que estamos haciendo es que no se realize el commit correspondiente cuando hacemos la recuperación del archivo.
Pasando de este modo al area de preparación.

P2-> Al realizar el comando reset, lo que ha sucedido es que hemos recuperado lo que teníamos en la rama del HEAD, pero esta vez, directamente se nos guardará de nuevo en el repositorio local.

P3-> Como ya he dicho en la pregunta anterior, una de las diferencias clave es que pasa directamente lo que tengamos en el Head de manera que no habrá que poner el alias Head en la llamada al comando como sucedía con revert.
Por otro lado, vemos que al haber utilizado la opción -n en el comando revert. Los archivos recuperados se quedaban en el area de preparación, teniendo que hacer así su commit correspondiente para subirlos al repositorio local. 
Cosa que no sucedía haciendo uso del comando reset, dado que este realiza el commit correspondiente directamente. 
Además, el reset mueve el puntero y el revert copia el último commit que se ha realizado. 

P4-> Entre las diferencias que nos encontramos entre rebase y merge, las más destacables, son las siguientes: 
		-> En primer lugar, nos encontramos que si hacemos rebase, lo que sucederá es que cuando hagamos gitkpara ver las ramas que este nos deja, veremos que en el caso de rebase, lo que sucede es que se nos habrá unificado todo en una sola rama. Mientras que con merge, nos dejará el gráfico de ramas.
		-> En segundo lugar, vemos que cuando haccemos merge, tenemos que realizar un commit de más. Mientras que si utilizamos el comando rebase esto no es necesario, dado que unifica sin necesidad de realizar un nuevo commit.
		-> En tercer lugar, nos encontramos con la diferencia MÁS IMPORTANTE, y es que cuando realizamos un rebase, al unificar todas las ramas, se pierde el historial de commits que hayamos realizado. En el merge, esto no sucede, dado que deja las ramas anteriores. Resulta realmente importante sobretodo, si se trabaja en equipo.
