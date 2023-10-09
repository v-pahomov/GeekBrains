from return_data_file import data_file
from print_data import print_file
from return_data_file import data_file


def copy_data_file():
    start_data, nf = data_file()
    number_string = int(input(f'Выберите номер строки от 1 до {len(start_data)},\n'
                              'которую хотите копировать: '))
    while number_string < 1 or number_string > len(start_data):
        number_string = int(input('Такой строки не существует!\n'
                                  f'выберите номер строки от 1 до {len(start_data)}'))
    tf = int(input('Выберите файл, в который хотите\n'
                   'скопировать данные: '))
    target_string = start_data[number_string - 1].split(';')
    with open(f'db/data_{tf}.txt', 'r+', encoding='utf-8') as file:
        file.write(f'\n{len(file.readlines()) + 1};{target_string[1]};{target_string[2]};{target_string[3]};'
                   f'{target_string[4]};')
    print('Данные успешно копированы!')
