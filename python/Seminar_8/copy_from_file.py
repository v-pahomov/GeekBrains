from return_data_file import data_file
from print_data import print_file


def copy_data_file():
    print_file()
    nf = int(input('Выберите файл, из которого хотите\n'
                   'скопировать данные: '))
    while nf < 1 or nf > 2:
        nf = int(input("Ошибка!!!\n"
                       "Введите цифру 1 или 2: "))
    with open(f'db/data_{nf}.txt', 'r', encoding='utf-8') as file:
        start_data = file.readlines()
    if len(start_data) > 0:
        tf = int(input('Выберите файл, в который хотите\n'
                       'скопировать данные: '))
        number_string = int(input(f'Выберите номер строки от 1 до {len(start_data)},\n'
                                  'которую хотите копировать: '))
        while number_string < 1 or number_string > len(start_data):
            number_string = int(input('Такой строки не существует!\n'
                                      f'выберите номер строки от 1 до {len(start_data)}'))
        target_string = start_data[number_string - 1].split(';')
    else:
        print('Файл пустой!')
    with open(f'db/data_{tf}.txt', 'r', encoding='utf-8') as file:
        target_data = file.readlines()
    with open(f'db/data_{tf}.txt', 'a', encoding='utf-8') as file:
        file.write(f'\n{len(target_data) + 1};{target_string[1]};{target_string[2]};{target_string[3]};'
                   f'{target_string[4]}')
    print('Данные успешно копированы!')

