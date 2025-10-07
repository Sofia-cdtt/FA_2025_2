# Ejercicio 5
# Crear un programa que solicite 2 números enteros y que realice las siguientes
# operaciones:
# o Suma.
# o Resta.
# o Multiplicación.
# o División.
# Se debe de crear un menú en el cual te solicite la operación a realizar.
# Si ingreso una opción que no realiza ninguna operación volver a solicitar
# limpiando la consola.
# Debe de mostrar un mensaje si desea seguir realizando las operaciones (“y”
# para continuar, y cualquier otra tecla para terminar y cerrar consola).
# Cada vez que se realice una nueva operación limpiar la consola.
# Cada operación debe de tener su método void con parámetros.

def suma (a,b): print("\nla suma es: ",a+b)
def resta (a,b): print("\nla suma es: ",a-b)
def multi (a,b): print("\nla suma es: ",a*b)
def divi (a,b):
    if b != 0: print("\nLa División es: ",a+b)
    else: print("\nError. No se puede dividir entre 0")

def operaciones():
    while True:
        print("| Menú de operaciones |")
        print("\n1. Suma")
        print("2. Resta")
        print("3. Multiplicación")
        print("4. División")

        opc = int(input("Ingrese una opción: "))

        a = int(input("\nIngrese el primer número: "))
        b = int(input("\nIngrese el segundo número: "))

        match opc:
            case 1: suma(a,b)
            case 2: resta(a,b)
            case 3: multi(a,b)
            case 4: divi(a,b)
            case _: print("Error. Opción no válida")

        Seguir = input("¿Desea continuar? presione(y): ")

        if Seguir != "y":
            print("\nPrograma finalizado")
            break

operaciones()