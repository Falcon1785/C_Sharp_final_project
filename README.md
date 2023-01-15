# C_Sharp_final_project
## Задача.
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. при решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Решение.
Обьявляем два массива arr_1 и arr_2 с типом данных string.Массив arr_1 вводим вручную,длина arr_2 совпадает с длиной arr_1.
Задаем метод ConvertArr с типом данных void для преобразования первого массива во второй с выполнением условия.В теле метода задаем переменную int count изначально равную нулю.

Запускаем цикл for с переменной int i,которую увеличиваем на 1 в каждом проходе цикла.Цикл служит чтобы перебрать все значения первого массива и продолжается пока i меньше его длины.

Далее с помощью if проверяем условие нашей задачи,а именно вычисляем значения массива с длиной <=3.
Если условие не выполняется то возвращаемся к циклу for.
При выполнении этого условия присваиваем значение из первого массива arr_1[i] значению arr_2[count] и увеличиваем переменную count на единицу.
Возвращаемся к циклу for.

Задаем метод для выведения массива с типом данных void.

Применяем метод ConvertArr к массиву arr_1,а затем выводим получившийся массив с помощью метода PrintArray.

Блок схема примененного метода находиться в папке "Block_scheme".