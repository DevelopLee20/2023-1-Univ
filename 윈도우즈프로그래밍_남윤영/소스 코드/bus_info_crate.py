import random
import math

file_name = "BusInfo.txt"

fopen = open(file_name, "w", encoding="utf-8")

write_list = []
start_list = ["서울","부산","경기","충북","충남","제주"]
go_year_list = ["2023"]
go_month_list = ["06"]
go_day_list = ["15","16","17","18","19"]
go_hour_list = ["00","01","02","03","04","05","06","07","08","09","10","11","12","13","14","15","16"]
go_minute_list = ["00","10","20","30","40","50"]
bus_type_list = ["일반","우등","프리미엄"]
bus_company_list = ["대한","민국","인규"]
in_list = [i for i in range(1,24)]
sit_row = [i for i in range(6)]
sit_col = [i for i in range(4)]
sits = []

for i in sit_row:
    for j in sit_col:
        value = f'{i}{j}'
        sits.append(value)

for i in range(0,500):
    ints1 = random.randint(0, 5)
    ints2 = random.randint(0, 5)
    
    while ints1 == ints2:
        ints2 = random.randint(0, 5)
        
    start = start_list[ints1]
    end = start_list[ints2]
    
    go_year = random.choice(go_year_list)
    go_month = random.choice(go_month_list)
    go_day = random.choice(go_day_list)
    go_hour = random.choice(go_hour_list)
    go_minute = random.choice(go_minute_list)
    bus_type = random.choice(bus_type_list)
    bus_company = random.choice(bus_company_list)
    
    if ints1 > ints2:
        charge = ints1 - ints2
    else:
        charge = ints2 - ints1
    
    distance = f'{charge * 10}km'
    
    times = f'{charge}시간소요'
    
    charge = f'{1000*charge}'
    
    ins = random.choice(in_list)
    temp = f'{ins};'
    
    for _ in range(100):
        swap1 = random.randint(0, 23)
        swap2 = random.randint(0, 23)
        sits[swap1], sits[swap2] = sits[swap2], sits[swap1]
        
    for iii in sits[:ins]:
        temp += f'{iii}'
        print(iii)

    write_list.append(start + ";" + end + ";" + go_year + ";" + go_month + ";" + go_day + ";" + go_hour + ";" + go_minute + ";" + bus_type + ";" + bus_company + ";" + distance + ";" + times + ";" + charge + ";" + temp)

for i in write_list:
    fopen.write(i + "\n")

fopen.close()
