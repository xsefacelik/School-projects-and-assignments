import random

#INSERT INTO employee (employee_id, username, ssn, profession, flight_count) VALUES (NULL, NULL, '34', 'pilot', '345')



def create(ssn):
    flight_count = random.randint(1, 1000)
    profession = random.randint(1, 8)
    
    with open("employee.txt", "a", encoding='utf-8') as dosya:
        if profession < 4:
            line = "INSERT INTO employee (employee_id, ssn, profession, flight_count) VALUES (NULL, '" + str(ssn) + "', 'pilot', '" + str(flight_count) + "')"
        else:
            line = "INSERT INTO employee (employee_id, ssn, profession, flight_count) VALUES (NULL, '" + str(ssn) + "', 'cabin attendant', '" + str(flight_count) + "')"
        dosya.write(line + '\n')


ssn=[]

try:
    # Dosyayı satır satır okuma işlemi
    with open('ssn.txt', 'r', encoding='utf-8') as file:
      for line in file:
        ssn.append(line.strip())
except Exception as hata:
    print('Dosya okuma hatası:', hata)


for i in range(10000):
    ssn_number = random.choice(ssn)
    create(ssn_number)
    ssn.remove(ssn_number)
