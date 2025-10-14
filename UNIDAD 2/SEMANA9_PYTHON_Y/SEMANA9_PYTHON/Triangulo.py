# La clase Triangulo debe de tener el método vacío sin parámetros.
class Triangulo:
    def Area(self)->None: #self signfica instancia
        b = int(input("\nIngrese la base: "))
        h = int(input("Ingrese la altura: "))
        print("\nÁrea: ", (b*h)/2)

    def Perimetro(self)->None:
        l1 = int(input("\nIngrese lado 1: "))
        l2 = int(input("\nIngrese lado 2: "))
        l3 = int(input("\nIngrese lado 3: "))
        print("Périmetro: ", l1+l2+l3)