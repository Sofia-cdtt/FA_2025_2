#Profesor Yordan :)
def Ejercicio1():
    edad = int(input("Buen día. Ingrese su edad: "))
    
    if (edad >= 18):
        print("Usted puede votar.")

        if edad >= 25:
            print("Usted es candidato para un cargo político")
        else: 
            print("Usted NO es candidato para un cargo político")
    else:
        print("Usted no puede votar.")
        print("Usted no puede ejercer un cargo político.")

def Ejercicio2():
    num1 = float(input("Buen día. Ingrese el primer número: ")) # el profesor lo puso como lado
    num2 = float(input("Buen día. Ingrese el segundo número: "))
    num3 = float(input("Buen día. Ingrese el tercero número: "))

    if (num1 == num2 == num3):
        print("El triángulo es Equilátero")
    
    elif (num1 == num2 or num1 == num3):
        print("El triángulo Isósceles")
    else:
        print("El triángulo Escaleno")
        
Ejercicio2()