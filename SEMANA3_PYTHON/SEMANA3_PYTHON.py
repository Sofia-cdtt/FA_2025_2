def ejercicio1():
    Nombre = input("Ingrese su nombre: ")
    Carrera = input("Ingrese su carrera: ")

    #print para imprimir
    #el f es igual que el $ en c#
    print(f"\n{Nombre}, Bienvenido a FA de {Carrera}")

def ejercicio2():
    print("\"\"Sofia\"\"")

def ejercicio3(): #Ejercicio python hecho por el profesor
    x = int(input("Ingrese el valor de x: "))
    y = int(input("Ingrese el valor de y: "))

    print("Suma: ", (x+y))
    print("Resta: ", (x-y))
    print("Multiplicación: ", (x*y))
    print("División: ", (x/y))

import math #Importando la libreria math

def ejercicio4():
    num = float(input("Ingrese su número decimal: "))

    print("Raíz 2: ", math.sqrt(num))
    print("Redondeado: ", round(num,0))
    print("Elevar al cubo:", math.pow(num,3))
    print("Raíz cubica: ", num**(1/3))

def ejercicio5():
    num = input("Ingrese un número: ")

    entero = int(num)
    deci = float(num)

    print("Resto: ", (entero%2))
    print("División: ", (entero/3))

def ejercicio6():



    cantidadSegundos = input("Ingrese la cantidad de segundos: ")

    horas = int(cantidadSegundos)
    minutos = int(cantidadSegundos)
    segundosRestantes = int(cantidadSegundos)

    print("Su resultado es: ")
    print("Horas: ", (horas//3600))
    print("Minutos: ", (minutos % 3600)//60 )
    print("Segundos restantes: ", (segundosRestantes % 60))
    
    ejercicio5()
