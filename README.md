Задание
=======
Найти самую длинную возрастающую цепочку простых чисел

В заданном бинарном файле необходимо найти самую длинную возрастающую цепочку простых чисел. Бинарный файл трактуется как последовательность 6-ти байтовых беззнаковых целых. Размер файла может быть любым, если размер файла не кратен 6, то лишние байты с конца файла игнорируются. Элементы цепочки не обязаны идти друг за другом в файле, между элементами цепочки могут встречаться не простые числа в любом количестве. Из двух цепочек одинаковой длины предпочтение отдается той, у которой первый элемент больше. Если длины и первые элементы цепочек совпадают, предпочтение отдается той, у которой смещение первого элемента меньше.

Задача должна быть реализована в виде консольного приложения для Windows 32bit и должна быть выполнена на языке C#. Файл с данными указывается как параметр командной строке. Реализация должна быть многопоточной, хочется иметь бонус от запуска приложения на многопроцессорных (Core2Quad) системах. Во время работы должен отображаться прогресс обработки файла. Должна быть возможность прервать обработку файла. Результатом работы должен быть вывод первого элемента цепочки и его смещения, последнего элемента цепочки и его смещенья и длины цепочки, или, если цепочка не была найдена – сообщение об этом прискорбном факте. Если работа приложения была прервана, то необходимо вывести текущее состояние (информацию по найденной цепочке или сообщение о том, что ничего пока не нашлось).


PrimeChainStalker
=================

Use the first command-line argument to specify the path to the target file.

If the first argument is not specified or the file couldn't be found, the proram will suggest creating a random one in the current working directory.
