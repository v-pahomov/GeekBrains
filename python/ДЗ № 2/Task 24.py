# Собирающий модуль за один заход, находясь непосредственно перед некоторым кустом, собирает ягоды с этого куста и с
# двух соседних с ним. Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход
# собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.

list_1 = []
n = int(input('Введите количество кустов: '))
for i in range(1, n + 1, 1):
    list_1.append(int(input(f'Введите количество ягод на {i}: ')))

maximum = list_1[n-1] + list_1[0] + list_1[1]
for i in range(1, len(list_1)):
    if i < (len(list_1) - 1):
        if (list_1[i - 1] + list_1[i] + list_1[i + 1]) > maximum:
            maximum = list_1[i - 1] + list_1[i] + list_1[i + 1]
    if i == (len(list_1) - 1):
        if (list_1[0] + list_1[i] + list_1[i - 1]) > maximum:
            maximum = list_1[0] + list_1[i] + list_1[i - 1]
print(f'Максимальное количество ягод: {maximum}')


