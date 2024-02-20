import random

def create_mail(name, last_name):
    random_number = random.randint(1, 10000)

    choose_mail = random.randint(1, 3)
    if choose_mail == 1:
        mail = f"{name.lower()}.{last_name.lower()}{random_number}@hotmail.com"
    elif choose_mail == 2:
        mail = f"{name.lower()}.{last_name.lower()}{random_number}@gmail.com"
    else:
        mail = f"{name.lower()}.{last_name.lower()}{random_number}@outlook.com"

    return mail



def create_birth_date():
    year = random.randint(1930, 2022)
    month = random.randint(1, 12)

    if month in [1, 3, 5, 7, 8, 10, 12]:
        day = random.randint(1, 31)
    elif month == 2:
        day = random.randint(1, 28)
    else:
        day = random.randint(1, 30)

    return f"{year}-{month}-{day}"


def generate_random_number():
    random_number = ''
    length = 13

    for i in range(length):
        digit = random.randint(0, 9)
        random_number += str(digit)
        if i == 3 or i == 7:
            random_number += " "

    return random_number


def insert(name, lastname, phone_number, mail, birth_date, gender):
    # Dosyaya yazma işlemi
    with open("insertPeople.txt", "a", encoding='utf-8') as dosya:
        line = f"INSERT INTO person (name, lastname, phone_number, mail, birth_date, gender, flight_status) VALUES ('{name}', '{lastname}', '{phone_number}', '{mail}', '{birth_date}', '{gender}', '0')"
        dosya.write(line + '\n')


def get_random_element_from_array(arr):
    random_index = random.randint(0, len(arr) - 1)
    return arr[random_index]



lastNamesForeign = []
lastNamesTurkish = []
namesForeignMan = []
namesForeignWoman= []
namesTurkishMan = []
namesTurkishWoman = []
countries = []
professions = []

karakter_seti = 'utf-8'




try:
    with open('last_names_of_foreign.txt', 'r', encoding='utf-8') as file:
      for line in file:
        lastNamesForeign.append(line.strip())

except Exception as hata:
    print('Dosya okuma hatası:', hata)

try:
    
    with open('last_names_of_turkish.txt', 'r', encoding='utf-8') as file:
      for line in file:
        lastNamesTurkish.append(line.strip())

except Exception as hata:
    print('Dosya okuma hatası:', hata)


try: 
    with open('names_of_foreign_man.txt', 'r', encoding='utf-8') as file:
      for line in file:
        namesForeignMan.append(line.strip())
except Exception as hata:
    print('Dosya okuma hatası:', hata)


try:
    with open('names_of_foreign_woman.txt', 'r', encoding='utf-8') as file:
      for line in file:
        namesForeignWoman.append(line.strip())
          
except Exception as hata:
    print('Dosya okuma hatası:', hata)

try:
    with open('names_of_turkish_man.txt', 'r', encoding='utf-8') as file:
      for line in file:
        namesTurkishMan.append(line.strip())

except Exception as hata:
    print('Dosya okuma hatası:', hata)

try:
    # Dosyayı satır satır okuma işlemi
    with open('names_of_turkish_woman.txt', 'r', encoding='utf-8') as file:
      for line in file:
        namesTurkishWoman.append(line.strip())
except Exception as hata:
    print('Dosya okuma hatası:', hata)


try:
    # Dosyayı satır satır okuma işlemi
    with open('names_of_country.txt', 'r', encoding='utf-8') as file:
      for line in file:
        countries.append(line.strip())

except Exception as hata:
    print('Dosya okuma hatası:', hata)


try:
    # Dosyayı satır satır okuma işlemi
    with open('professions.txt', 'r', encoding='utf-8') as file:
      for line in file:
        professions.append(line.strip())

except Exception as hata:
    print('Dosya okuma hatası:', hata)

erkek = 0
kadın = 1



for i in range(1000000):
    random_number = random.randint(1, 12)
    if random_number == 1:
      name = get_random_element_from_array(namesTurkishMan)
      surname = get_random_element_from_array(lastNamesTurkish)
      phone_number = generate_random_number()
      mail = create_mail(name, surname)
      birth_date = create_birth_date()
      insert(name, surname, phone_number, mail, birth_date, erkek)
    elif random_number == 2:
       name = get_random_element_from_array(namesTurkishWoman)
       surname = get_random_element_from_array(lastNamesTurkish)
       phone_number = generate_random_number()
       mail = create_mail(name, surname)
       birth_date = create_birth_date()
       insert(name, surname, phone_number, mail, birth_date, kadın)
    elif random_number < 8:
       name = get_random_element_from_array(namesForeignMan)
       surname = get_random_element_from_array(lastNamesForeign)
       phone_number = generate_random_number()
       mail = create_mail(name, surname)
       birth_date = create_birth_date()
       insert(name, surname, phone_number, mail, birth_date, erkek)
    else:
       name = get_random_element_from_array(namesForeignWoman)
       surname = get_random_element_from_array(lastNamesForeign)
       phone_number = generate_random_number()
       mail = create_mail(name, surname)
       birth_date = create_birth_date()
       insert(name, surname, phone_number, mail, birth_date, kadın)
    

  

