# Ejercicio 6
# Realizar un programa que te solicite moneda soles y lo convierta a los
# siguiente:
# o Dólares. (3.78)
# o Euros. (4.20)
# Crear los métodos con retorno y sin parámetros.
# Debe de mostrar un mensaje si desea seguir realizando las operaciones (“y”
# para continuar, y cualquier otra tecla para terminar y cerrar consola).
# Cada vez que se realice una nueva operación limpiar la consola.
# Una de las variables debe de ser declarada como global.

dolar =3.78
euro = 4.20
while True: # seleccionas el codigo y pones tab para ordenar
    soles = float(input("Ingrese el monto en soles: "))

    def convertir_d():
        return round (soles / dolar)

    def convertir_e():
        return round (soles / euro)


    print("\n| Bienvenido al sistema de convesión de modena |")
    print("\n1. Dolares")
    print("2. Euros")

    opc =int(input("Ingrese una opción: "))

    if opc in(1,2):
        if opc ==1: print("Conversión a dolares: ",convertir_d())
        else: print("Conversión a euros: ",convertir_e())
    else: print ("Error. Opción no válida. ")

    Seguir = input("¿Desea continuar? presione(y): ")

    if Seguir != "y":
        print("\nPrograma finalizado")
        break