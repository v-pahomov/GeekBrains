# Задача 22: Даны два неупорядоченных набора целых чисел (может быть, с повторениями).
# Выдать без повторений в порядке возрастания все те числа, которые встречаются в обоих наборах.
# Пользователь вводит 2 числа. n — кол-во элементов первого множества, m — кол-во элементов второго множества.
# Затем пользователь вводит сами элементы множеств.
n = int(input('Введите кол-во элементов 1-го множества: '))
m = int(input('Введите кол-во элементов 2-го множества: '))
list_1 = []
list_2 = []

for i in range(1, n + 1):
    list_1.append(int(input(f'Введите {i}-й элемент 1-го набора: ')))
for j in range(1, m + 1):
    list_2.append(int(input(f'Введите {j}-й элемент 2-го набора: ')))

list_1 = set(list_1)
list_2 = set(list_2)
print(*sorted(list_1.union(list_2)))
