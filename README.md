# GB-Control-First-Quarter

### Репозиторий для контрольной работы в GeekBrains

Первая четверть

Name: Mishchenko Nikita

email: NikMishchenko@yandex.ru

## Задача

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Блок-схемы алгоритма и методов
Блок схемы работают на GitHub.
### Main algorithm

```mermaid
  graph TD;
      A[Начало]-->B{Вводим массив строк вручную?};
      B -- Да --> C[Введите количество слов в массиве input number];
      B -- Нет --> D{Есть слова в массиве длиной слов три и меньше?};
      D -- Да --> E[Передать массив строк в функцию NumberWordsThreeChar и создать новый массив строк нужного размера];
      D -- Нет --> F[Вывести на консоль сообщение: *В массиве строк нет слов с длинной до трёх символов*];
      E --> G[Передать оригинальный и новый массивы строк в метод FillArrayWordsThreeChar]
      G --> J[Вывод в консоль нового массива строк]
      C --> H[Создать новый массив размера number]
      H --> K[Передать в метод ManualInputArray новый массив]
      K --> D
      F --> L[Конец]
      J --> L
```