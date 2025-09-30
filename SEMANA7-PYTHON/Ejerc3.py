#Ejercicio3 (Profesor Yordan)
Suma = 0
while True:
    num = int(input("Buen día. Ingrese un número positivo: "))

    for i in range (1,num+1): #En el for se suma +1
        print(i, end=" ")
        Suma += i
        print()

    print("\nSuma: ",Suma)
    opc = input("¿Desea continuar? (S/N) : ")

    if(opc.upper() == "N"): break #.upper() para mayúsculas y minúsculas
