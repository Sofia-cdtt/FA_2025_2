from Triangulo import Triangulo
from Cuadrado import Cuadrado
from Rectangulo import Rectangulo
from Trapecio import Trapecio
t = Triangulo()
c = Cuadrado()
r = Rectangulo()
p = Trapecio()

def menu1()->None:
    print("Bienvedidos a cálculos de área y perímetros")
    print("********** Menú de opciones **********")
    print("*          1. Triangulo              *")
    print("*          2. Cuadrado               *")
    print("*          3. Rectangulo             *")
    print("*          4. Trapecio               *")
    print("*          0. Salir                  *")
    print("**************************************")

def menu2()->int:
    print("\n***** Seleccione cálculo *****")
    print("*          1. Área             *")
    print("*          2.Perímetro         *")
    print("********************************")

    opcion = int(input("Ingrese una opción: "))
    return opcion

while True:
    menu1()
    while True:
        opcion = int(input("Ingrese opción: "))

        if opcion in (0,1,2,3,4): break
        else: print("Error. Opción inválida.\n")

    match opcion:
        case 0: exit() #quit() -> Exit()
        case 1: 
            opc = menu2()

            match opc: 
                case 1: t.Area()
                case 2: t.Perimetro()

        case 2: 
            opc = menu2()
            l = int(input("Ingrese lado: "))

            match opc: 
                case 1: c.Area(l);
                case 2: c.Perimetro(l);

        case 3: 
            opc = menu2()

            match opc:
                case 1: r.Area();
                case 2: r.Perimetro();

        case 4: 
            opc = menu2()

            match opc:
                case 1: p.Area();
                case 2: p.Perimetro();

    while True:
        seguir = input("¿Desea continuar? (s/n): ") #seguir quiere decir continuar 
        if seguir in("s","n"): break
        else: print("Error. Solo 's' o 'n'.")

    if seguir == "n": break

