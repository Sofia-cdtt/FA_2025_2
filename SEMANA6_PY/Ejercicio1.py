#Agregar clase, agregar elemento ejercicio7.py
num = int(input("Ingrese un número positivo: "))
print()

while num <= 0:
    num = int(input("Error. Ingrese un número positivo."))

i = 1

while i <= 12:
    print(f"{i} x {num} = {i*num}")
    i+=1