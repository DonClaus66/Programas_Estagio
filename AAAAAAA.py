Numero = 12034
Numero2 = 0
shab = 100000
bahs = 1
count = 0
init = True

while count<=6:
    if int(Numero/shab)==0 and init:
        shab = shab/10
        count+=1
        continue
    else:
        init = False
    Numero2 = Numero2 + int(Numero/shab)*bahs
    Numero = Numero%shab
    shab = shab/10
    bahs = bahs*10
    count+=1

print(Numero2)