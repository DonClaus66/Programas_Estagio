import math

def FixFunction(function):
    function = function.replace("ln","math.log")
    function = function.replace("Ln","math.log")
    function = function.replace("e","math.e")
    function = function.replace("π","math.pi")
    function = function.replace("cos","math.cos")
    function = function.replace("sen","math.sin")
    function = function.replace("tg","math.tan")
    function = function.replace("Cos","math.cos")
    function = function.replace("Sen","math.sen")
    function = function.replace("Tg","math.tan")
    function = function.replace("tan","math.tan")
    function = function.replace("Tan","math.tan")
    function = function.replace("^","**")
    function = function.replace(" ","")
    function = function.replace(",",".")
    return function

def VerifyInterval(first,second,function):
    x1 = eval(function.replace("x","first"))
    x2 = eval(function.replace("x","second"))
    if (x1<=0 and x2<=0) or (x1>=0 and x>=0):
        break
    else:
        pass

    
function = input('Digite a função que deseja calcular as raízes: ')
a = int(input('Determine o primeiro intervalo: '))
b = int(input('Determine o segundo intervalo: '))

VerifyInterval(a,b,function)

dprint(eval(FixFunction(function)))
    