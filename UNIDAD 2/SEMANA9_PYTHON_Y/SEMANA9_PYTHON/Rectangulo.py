class Rectangulo:
    @staticmethod
    def Area()->None:
        b = int(input("\nIngrese base: "))
        h = int(input("\nIngrese la altura: "))
        print("\nÁrea: ", b*h)

    @staticmethod
    def Perimetro()->None:
        b = int(input("\nIngrese base: "))
        h = int(input("\nIngrese la altura: "))
        print("\nPerímetro: ", 2*(b+h))