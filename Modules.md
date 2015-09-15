### Информация устарела. Свежая информация на [сайте проекта OpenWealth](http://openwealth.ru) ###

### Функции Cap'а ###
Фактически, каждая из функций, является независимым приложением. Но написанный робот может быть запущен из под любого из них, без изменения в коде робота.
  * Тестирование на исторических данных робота в WealthLab
  * Боевой запуск робота из под WealthLab
  * Боевой запуск робота без WL (перспектива)

## Модули Cap'а ##
### Описание взаимодействия ###

Модуль - объединение функций системы. Может быть выполнен в одной DLL или в нескольких. Несколько модулей может быть объедено в одной DLL. На ум пришла аналогия namespace в c#.

Сборка с ядром - не зависит больше не от одной сборки с модулями.
Сборки с другими модулями зависят только от сборки с ядром.

Возможны ситуации когда:
  1. Вся система откомпилирована в одну DLL или в один EXE
  1. Система состоит из большого числа DLL

Алгоритм запуска:
  1. при запуске, ядро загружает все DLL найденные в папке Plugins
  1. ищет классы, реализующие интерфейс IPlugin
  1. Инициирует их
  1. При инициации, классы, реализующие IPlugin создают классы, реализующие интерфейсы модулей и регистрируют их в ядре.
  1. Далее модули получают ссылки из ядра, на классы реализующие интерфейсы других модулей и начинают с ними взаимодействовать.

### Список ###
  * Ядро
```
    предоставляет общий API
    загружает другие модули
    другие модули узнают друг о друге только через ядро, для взаимодействия между модулями используются интерфейсы, описанные в ядре.
```
  * Интеграция с Quik
    * Получение данных (DDE)
```
      получение данных из Quik и передача их в модуль Данные
      обновление информации о заявках в модуле Ордера
```
    * Отправка транзакция (API)
```
      отправка ордеров появляющихся в модуле Ордера в quik, обновление их статусов
```
  * Интеграция с WL
    * Данные
      * [Исторические (статические)](WLStaticAdapter.md)
```
        загружает данные из модуля "Хранение данных" в WL
```
      * Реалтайм
```
        загружает данные из модуля "Хранение данных" в WL (учитывая специфику Реалтайм)
```
    * Ордера
```
      получает ордер из WL
      передает ордер в модуль Ордера
      при обновлении стутуса ордера, передает данное обновление в WL
```
  * Получение исторических данных с Финам
```
    получает данные с Финам
    сохраняет полученные данные в модуль Данные
```
  * Данные
```
    хранит торговые данные
    преобразует таймфрейм
```
  * Ордера
```
    Хранит информацию об ордерах (заявках). Рассчитывает и хранит позиции.
    Данная прослойка нужна, т.к. Quik'ов и других терминалов может быть много, и другие модули не должны заморачиваться на знание, куда в итоге попадет ордер
```
  * Интерфейс
```
    предоставляет другим модулям место, где выводить свои окна
    думаю, это просто parent окно для дочерних, которые выводятся модулями
```
  * Тестирование робота
```
    на перспективу
    раз есть запуск робота без WL, то думаю однажды захочется реализовать и простенькое тестирование робота без WL
```
  * Тестирование программы
```
    Хотя это и не совсем модуль, но тестированию того, что всё работает как надо, надо уделять много внимания, поэтому отметил это как отдельный модуль.
```
  * Отчетность
```
    Выступаю за то, что это много модулей, часть/или все могут быть удалены, без влияния на систему.
    Статистика делится на:
      статистика по роботу
             (роботов может быть сколько угодно)
             (отчет должен уметь добавлять себя в виде дополнительной закладки в окно робота)
        прибыль/убыток
        к-во сделок
        текущая позиция/заявки/сделки  (в том числе на графике цены)
        отношение кво транзакций к кву сделок
      общесистемная статистика
        агрегированные отчеты по роботам
        задержки агрегированные + в разрезе биржи/брокера/типа транзакции
    
    Кого интересует ещё какая статистика, присылаете, т.к. это может повлиять на архитектуру!
```

### Связь функций и модулей ###

[Таблица с описанием какой модуль, для каких функций нужен.](https://spreadsheets.google.com/ccc?key=0Aqp1hwxgUHAgdFRuaHhNRVhiZ3lPWk5lMVRzbjE2R2c&hl=ru)