#Yordan
sumap = sumai = 0
while True:
    num = int(input("Ingrse un número positivo [0 - salir]: "))


    if num < 0:
        print("Número inválido. Ingrese nuevamente. ")
        continue #regresa a pedir aunque no cumpla

    if num == 0:
        break # finaliza y muestra los resultados

    if num % 2 == 0:
        sumap += num

    else:
        sumai += num

print("\nSuma pares:",sumap)
print("Suma impares:",sumai)