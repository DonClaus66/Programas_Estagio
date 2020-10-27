Numero = 12034
NumeroInv = 0

NumeroAux = Numero
for i in range(6):
    NumeroInv += NumeroAux % 10
    NumeroAux = int(NumeroAux/10)
    if (NumeroAux == 0):
        break
    NumeroInv *= 10

print(NumeroInv)