# Контрольная работа по основному блоку

## Создание функций и методов

1. Создаю функцию CountArray(string[] array, int N), которая на вход принимает строковый массив и целое число, а возвращает количество элементов массива у которых длина строки меньше или равна полученному на входе числу.
2. Создаю метод, который на вход принимает строковый массив и красиво выводит в консоль все элементы этого массива.

## Тело решения

1. Создаю строковый массив A с элементами "213", "mass", "1000", "yeah", "yes", "ooooops", "no", "1007".
2. Создаю пустой строковый массив B длиной в полученное число в результате выполнения функции CountArray(A).
3. В цикле пробегаюсь по массиву и ищу элементы с длиной меньше или равной 3, если нахожу, то записываю их подряд в массив B, в этом мне помогает счетчик, который увеличивается при нахождении нужного элемента.

## Вывод в консоль
1. Очищаю консоль
2. Вывожу массив А
3. Вывожу массив B