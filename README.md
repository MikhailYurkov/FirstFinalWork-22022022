Final work after 3 months of study at the GB under the "Developer" program
# Итоговая работа первого блока
Данная работа предназначена для проверки моих знаний и навыков по итогу прохождения первого блока обучения на программе разработчик.

Для выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символов. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

---
Выполнение задания
===
* 1 Ссылка на [  репозиторий](https://github.com/MikhailYurkov/FirstFinalWork-22022022)
* 2 ![Файл блок схемы проекта](main-pic.jpg)

1. Задаем исходный массив строк, который необходимо подвергнуть анализу ```(stringArray) = "Hi", "   ", "world", "2", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan"```
2. Создаем метод вывода массива в консоль.
    * Указываем тип метода ``` void ```
    * Указываем тип аргумента ``` ( )```
    * Выводим массив при помощи цикла ```for``` на консоль
3. Создаем метод для подсчета количества элементов для нового массива.
    * Указываем тип метода ``` string[]```
    * Указываем тип аргумента ```( )```
    * Перебираем массив при помощи цикла ```for``` и подсчитываем элементы содержащий менее 4 символов.
    * Возвращаем количество элементов соответствующих условия
4. Создаем метод для создание сортированного массива в соответствии с условием (элементы массива содержат менее 4 символов)
    * Указываем тип метода ```(string[])```
    * Указываем тип аргументов ```( string[], int arrayLenght)```
    * Создаем новый массив длинной ```arrayLenght```
    * перебираем массив при помощи цикла ```for``` и записываем в новый массив элемент, которые соответствуют условию (длина элемента < 4)
    * Возвращаем новый массив.
5. Используя ранее созданный метод (пункт2) выводим на консоль новый массив

## Результаты работы программы



