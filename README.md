# hada-p1
Sirvent Navarro, Álvaro
Práctica 1b

P1-> La rama que se ha subido, es en la que nos encontramos actualmente. Es por ello, que al solo subir la rama en la que estamos situados, se nos subirá la rama master, que además, coincide con la rama donde tenemos todos los cambios actualizados.

P2-> Al comparar con la versión no modificada, lo que estamos haciendo es comparar la última versión del archivo que teníamos subida ( la más actualizada) con los cambios nuevos que hemos realizado en el mismo archivo.

P3-> Nos produce un conflicto, dado que tenemos un archivo diferente en el repositiorio remoto y no en el local, dando como resultado que tengamos que arreglar este error, con el fin de poder seguir actualizando los diferentes archivos.

P4-> Cuando le damos a Confirmar por etapas, lo que estábamos haciendo internamente  es realizar el commit correspondiente pasándolo al repositorio local.
Pero no realizando el respectivo push para pasarlo al repositorio remoto. 
Por otro lado, cuando hacemos click derecho y le damos a preparar, lo que realmente estamos haciendo es pasar el archivo al área de preparación ( git add) 
Por eso, necesitamos irnos a sincronización para realizar el respectivo push.

P5->Cuando hacemos "Confirmar por etapas e insertar" lo que hacemos es que se haga tanto el commit como el push correspondeinte de manera seguida, con el fin de que no nos tengamos que ir luego a sincronización y hacer nosotros de forma manual el push correspondiente.

P6-> Cuando hacemos “Confirmar por etapas y sincronizar” lo que realmente estamos haciendo es hacer tanto el commit del archivo que queremos hacer, como la sincronización de toda la rama en la que  estamos actualmente, haciendo uso del comado pull.

P7-> Cuando le damos a la opción de sincronizar, lo que realmente estamos realizando es un pull. Es decir, nos traemos todo lo que tengamos cambiado en el reposirio remoto directamente a nuestro dispositivo, pasando incluso el repositorio local. Mientras que si realizamos la opción "Extraer", lo que realmente estamos haciendo es usar el comando fecth, de manera que lo que haremos será recuperar solamente los commits que hayamos realizado sobre el repositorio remoto, y que no se encuentren en el local, pasándolos así al local.

P8->Cuando hacemos  “Fusionar mediante combinación”, lo que estamos haciendo es recuperar todos lo commits diferentes que habíamos aplicado en la rama devel2 y no en la rama master. 
Esto hará que tengamso que sincorinizar los cambios, dado que solo hemos recuperado los commits, pero no hemos hecho ningún push, por lo que tendremos que hacerlo de manera manual. Esto equivale al comando merge de git.

P9-> Cuando hacemos “Fusionar mediante cambio de base" realmente, lo que estamos haciendo es un rebase de lo tenemos en la otra rama para meterlo en la que tenemos en esta, pero sin guradar los commits.
