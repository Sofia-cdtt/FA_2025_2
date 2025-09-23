#Profe Yordan
fila = int(input("Ingrese número de filas: "))
columna = int(input("Ingrese número de columnas: "))
print()

i = 0 
while i < fila:
    j = 0
    while j < columna:
        print("*", end = " ")
        j += 1
    print("")
    i += 1