class Trapecio:
    @staticmethod
    def Area()->None:
        B = int(input("\nIngrese la base mayor: "))
        b = int(input("\nIngrese la base menor: "))
        h = int(input("Ingrese la altura: "))
        print("\nÁrea: ", (B+b)/2 * h)

    @staticmethod
    def Perimetro()->None:
        B = float(input("\nIngrese la base mayor: "))
        b = float(input("\nIngrese la base menor: "))
        l1 = float(input("\nIngrese el lado 1: "))
        l2 = float(input("\nIngrese el lado 2: "))
        print("\nPerímetro: ", B+b+l1+l2)