# Итоговый проект

## Задача
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Описание алгоритма решения
Прошу пользователя ввести произвольное количество символов через пробел. Формирую массив из введеных значений методом. Создаю второй массив такой же длины. Далее методом проверяю условия ( <=3 ), если да элемент первого массива заносится в count элемент второго массива. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И так проверяется до конца.

Блок-схемы в файлах 1.png и 1.drawio

Реализация алгоритма по пути ControlHomework/Program.cs