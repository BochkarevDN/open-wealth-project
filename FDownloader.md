### Информация устарела. Свежая информация на [сайте проекта OpenWealth](http://openwealth.ru) ###


# Важно #
Отныне, скачать данную утилиту можно только после присоединения к [группе](http://groups.google.ru/group/open-wealth-project)

[owp.FDownloader.zip (версия 2010.06.02)](http://groups.google.ru/group/open-wealth-project/files)

Исходники более в zip файле не выкладываю. Кому надо используйте [svn](https://open-wealth-project.googlecode.com/svn/trunk/owp.FDownloader/) или лучше [svn](http://code.google.com/p/open-wealth-project/source/browse/#svn/trunk/owp.FDownloader).

**Для тех, кто пользовался версией до 2010.06.02 обязательно прочитать [исправленный дефект](http://code.google.com/p/open-wealth-project/issues/detail?id=13). У вас в тиковых wl возможны ошибки!**

# Подробнее #

Утилита предназначена для загрузки данных c [www.finam.ru/analysis/export/default.asp Финама].
Программа понимает два ключа
  * /S – прочитать настройки из файла, указанного после данного ключа
  * /R – запуск загрузки, без вопросов
Всё, что вы настраиваете в программе, сохраняется в файл owp.FDownloader.config.xml , при желании его можно скопировать/переименовать и скармливать с ключами /R /S в [планировщике задач](http://www.windowsfaq.ru/content/view/338/46/1/1/).

[Планировщике задач](http://www.windowsfaq.ru/content/view/338/46/1/1/) позволяет запускать задачи загрузки данных по выбранному Вами расписанию.

Тиковые данные загружаются по дням (т.е. при загрузке данных за год, к Финаму будет 365 запросов на инструмент), остальные таймфреймы загружаются полностью за один запрос.

Выбор сразу всех инструментов рынка не сделал сознательно, пожалейте Финам :)

Надеюсь, что настройки интуитивно понятны (если нет, [спрашивайте](http://groups.google.ru/group/open-wealth-project))

# Связь #
Вопросы задавать [здесь](http://groups.google.ru/group/open-wealth-project)

Обсуждать проект [здесь](http://groups.google.ru/group/open-wealth-project)

Дефекты заводить [здесь](http://code.google.com/p/open-wealth-project/issues/list)

# Скриншоты #

![![](http://open-wealth-project.googlecode.com/files/FDownloader.screenshot1.png)](http://open-wealth-project.googlecode.com/files/FDownloader.screenshot1.png) ![![](http://open-wealth-project.googlecode.com/files/FDownloader.screenshot2.png)](http://open-wealth-project.googlecode.com/files/FDownloader.screenshot2.png) ![![](http://open-wealth-project.googlecode.com/files/FDownloader.screenshot3.png)](http://open-wealth-project.googlecode.com/files/FDownloader.screenshot3.png)