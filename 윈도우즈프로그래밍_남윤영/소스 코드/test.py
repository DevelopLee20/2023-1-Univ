file = open('test.txt', "r", encoding='utf8')
output = open('output.txt', 'w', encoding='utf8')

a = file.readlines()

for i in a:
    i = i[:-2]
    
    for j in i.split(';'):
        output.write(j + "\n")

file.close()
output.close()
