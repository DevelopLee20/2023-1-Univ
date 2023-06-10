import random

file_name = "bus_info.txt"

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
sit_row = [i for i in range(4)]
sit_col = [i for i in range(6)]

for i in range(0,500):
    start = random.choice(start_list)
    end = random.choice(start_list)
    go_year = random.choice(go_year_list)
    go_month = random.choice(go_month_list)
    go_day = random.choice(go_day_list)
    go_hour = random.choice(go_hour_list)
    go_minute = random.choice(go_minute_list)
    bus_type = random.choice(bus_type_list)
    bus_company = random.choice(bus_company_list)

    while start == end:
        end = random.choice(start_list)
    
    ins = random.choice(in_list)
    temp = f'{ins};'

    for i in range(ins):
        sit_r = random.choice(sit_row)
        sit_c = random.choice(sit_col)
        temp += f'{sit_r}{sit_c}'

    write_list.append(start + ";" + end + ";" + go_year + ";" + go_month + ";" + go_day + ";" + go_hour + ";" + go_minute + ";" + bus_type + ";" + bus_company + ";" + temp)

for i in write_list:
    fopen.write(i + "\n")

fopen.close()
