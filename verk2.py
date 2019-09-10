#exec("__=str\n____=int\n___=input\n_____=print\n_____(\"meðaltal er: \" + __((____(___(\"tala1: \")) + ____(___(\"tala2: \"))) / 2)) \nt1 = ____(___(\"tala1: \"))\nt2 = ____(___(\"tala2: \"))\nt3 = ____(___(\"tala3: \"))\nl = sorted(list([t1,t2,t3]))\nif l[1] == t1: \n _____(\"tala1 er í miðjuni\") \nelif l[1] == t2: \n _____(\"tala2 er í miðjuni\") \nelif l[1] == t3: \n _____(\"tala3 er í miðjuni\")\nflag = ___(\"frá tommu [t] eða sentimetra [s]?: \")\nnum = ____(___(\"Tala: \"))\nif flag == \"s\":\n    _____(num / 2.54,\"tommur\")\nelif flag == \"t\":\n    _____(num * 2.54,\"cm\")")






#t1 = int(input("tala1: "))
#t2 = int(input("tala2: "))
#t3 = int(input("tala3: "))

#l = sorted(list([t1,t2,t3]))

#if l[1] == t1:
#    print("tala1 er í miðjuni")
    
#elif l[1] == t2:
#    print("tala2 er í miðjuni")
    
#elif l[1] == t3:
#    print("tala3 er í miðjuni")

#flag = input("frá tommu [t] eða sentimetra [s]?: ")
#num = int(input("Tala: "))
#if flag == "s":
#    print(num / 2.54,"tommur")
#elif flag == "t":
#    print(num * 2.54,"cm")

manud = int(input("Hvaða númer mánað?: "))

if manud > 0 and manud < 4:
    print("Nú er daginn tekið að lengja.")
elif manud > 3 and manud <= 5:
    print("Vorið er komið og grundirnar gróa.")
elif manud > 5 and manud <= 8:
    print("Núna er sumarið komið með blóm í haga.")
elif manud > 8 and manud <= 10:
    print("Núna er haustið gengið í garð.")
elif manud > 10 and manud <= 12:
    print("Núna styttist í jólin")
else:
    print("Rangur innsláttur.")
    
print(tala "texi")
