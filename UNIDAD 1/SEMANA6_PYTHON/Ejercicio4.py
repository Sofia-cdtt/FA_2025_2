#Ejercicio 4 Profesor Yordan
g = input("Genere una contraseña: ")
print("---------------------------------")
print("|     Válida tu contraseña      |")
print("|                               |")
print("|    1. Ud tiene 3 intentos     |")
print("---------------------------------")

intentos = 3

while(intentos >0):
    c = input("Ingrese la contraseña: ")

    if g == c:
        print("\nAcceso concedido. Bienvenido al sistema. ")
        break

    else:
        intentos -= 1
        print("Error. Contraseña incorrecta. Intentos restantes: ", intentos)

else: print("Acceso denegado: cerrando sistema. ") #esto solo funciona en python

