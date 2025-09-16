#semana 4 ncon el profesor Yordan (JP_EJERCICIOS_S4)
def ejercicio1():
    edad = int(input("Buen díá, Ingrese una edad: "))

    if edad < 18:
        print("Es menor de edad")
    else: #tambien se puede poner elif y se eliminaria el if de la linea 8
        if edad >= 18 and edad <= 64:
            print("Es adulto")
        else:
            print("Es un adulto mayor")

#yo
def ejercicio2():
    year = int(input("Buen día, Ingrese un año:"))
    
    if (year % 4 == 0 and year % 100 != 0) or (year % 400 == 0):
        print(f"El año: {year} es bisiesto")
    else:
        print(f"El año {year} no es bisiesto. ")

    #Verificar si es par o impar
    if year % 2 == 0:
        print(f"El año {year} es par. ")
    else:
        print(f"El año {year} es impar. ")

def ejercicio3():
    monto_pe = float(input("Buen día, Ingrese el monto en soles (PEN): "))

    #Mostrar opciones
    print("Seleccione la moneda a la que desea convertir: ")
    print("=================")
    print("[D] - Dólares (USD)")
    print("[E] - Euros (EUR)")
    print("=================")

    opcion = input("Ingrese la opción: ").upper() # .upper() convierte a mayuscula

    #Usamos match-case con letras (match es para estructura múltiple)
    match opcion:
        case "D":
            monto_usd = monto_pe / 3.75
            print(f"{monto_pe:.2f} PEN = {monto_usd:.2f} USD")

        case "E":
            monto_eur = monto_pe / 4.05
            print(f"{monto_pe:.2f} PEN = {monto_eur} EUR")

        case _:
            print("Opción inválida. Intente nuevamente. ")

def ejercicio4():
    import math
    
    print("Cálculo de Áreas")
    print("====================")
    print("[1] - Área de un cuadrado")
    print("[2] - Área de un rectángulo")
    print("[3] - Área de un triángulo")
    print("[4] - Área de un círculo\n") #\n es salto de linea
    print("====================")

    opcion = int(input("Buen día, Ingrese una opción: "))

    match opcion:
        case 1:
            lado = float(input("Ingrese el lado del cuadrado: "))
            area = lado ** 2
            print(f"El área del cuadrado es: {area}")

        case 2:
            base = float(input("Ingrese la base del rectángulo: "))
            altura = float(input("Ingrese la altura del rectángulo"))
            area = base * altura
            print(f"El área del rectángulo es: {area}")

        case 3:
            base = float(input("Ingrese la base del triángulo: "))
            altura = float(input("Ingrese la altura del triángulo"))
            area = (base * altura) / 2
            print(f"El área del triángulo es: {area}")

        case 4:
            radio = float(input("Ingrese el radio del círculo: "))
            area = math.pi * (radio ** 2)
            print(f"El área del círculo es: {area:.2f}")

        case _:
            print("El valor ingresado es incorrecto. ")

ejercicio4()