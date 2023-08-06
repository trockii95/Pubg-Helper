# Pubg Helper
[СКАЧАТЬ](https://github.com/trockii95/Pubg-Helper/releases/tag/Pubg)

Программа для быстрого изменения языка системы windows, системного времени, раскладки клавиатуры.
![image](https://github.com/trockii95/Pubg-Helper/assets/3604918/d67604aa-8847-4445-b1ee-c7171538b82b)


Для чего это нужно: чтобы лутать китайские евенты в pubg, необходимо установить системный язык Китайский, время (UTC +8) Гонг-Конг, добавить китайскую раскладку клавиатуры. После выполнения этих условий, у вас появится возможность участвовать в евентах для китайского региона, у вас появляется возможность забирать ежедневные/еженедельные награзы за выполнение простых заданий. Среди наград бывают различные уникальные скины, кейсы и Г-Коины.

Программа никак не пытается взаимодействовать с процессом игры Pubg, не пытается менять файлы игры. Программа вообще никак не пересекается с игрой. 

Принцип работы программы прост: она исполняет команды cmd и powershell по нажатию на любую из кнопок. Какие команды и как исполняются будет в описании ниже в разделе "Команды cmd и powershell".

# Как пользоваться программой
Программу необходимо запускать от имени администратора.

Если вы запустили эту программу в первый раз, то вам необходимо установить китайский языковой пакет. Для этого находите кнопку "Установить" в разделе "Китайский языковой пакет". ![image](https://github.com/trockii95/Pubg-Helper/assets/3604918/2aa5e5d7-9aa0-4514-96ab-916ec0a6a4e7)

После нажатия появится всплывающее окно powershell синего цвета, оно означает что запущена установка. Загрузка и установка языков проходит в полностью автоматическом режима, к сожалению мы не видим никакого прогресса и уведомлений, пока установка не завершится. Необходимо подождать в среднем минут 10-20, пока окно установки не закроется само. После успешной установки языкового пакета необходимо перезагрузить компьютер.


Применение нужных настроек для евента делается нажатием единственной кнопки в разделе "Китайский шаблон системы". ![image](https://github.com/trockii95/Pubg-Helper/assets/3604918/5fe01058-e93e-466f-b085-59c6679a3302)

Чтобы изменения вступили в силу необходимо сделать выход из системы или перезагрузку.

Программа не сохраняет первоначальные настройки системы, поэтому чтобы вернуть первоначальное состояние вам необходимо выставить нужные настройки в разделе "Персональные настройки". ![image](https://github.com/trockii95/Pubg-Helper/assets/3604918/99e4e828-1c8d-4238-8e3e-2100019bde16)

При первом запуске создаётся файл settings.ini с дефолтными настройками языка системы и часового пояса. Изменить эти настройки можно в разделе "персональные настройки". Данные сохраняются в файл автоматически при каждом изменении любого из параметров.

# На программу может ругаться антивирусник
Мы обнаружили это недоразумение сразу после того, как добавили в программу возможность устанавливать и удалять языковой пакет. Эта операция требует права администратора. Никаких вирусов в программе нет. Если есть сомнения, вы в любой момент можете ознакомиться с исходниками, либо же скачать исходники и скомпилировать эту программу у себя на компьютере. 
![image](https://github.com/trockii95/Pubg-Helper/assets/3604918/d5cbe69f-5992-475c-af73-38d938b3e93c)

[https://www.virustotal.com/gui/file/1374383fad56f70487f8c6f2b14f2512b6fbd0191cf06d9b5be4c3f6373cd5f7?nocache=1
](url)

Также защитник win11 всегда ругается на неподписанные приложения. Мы не крупные издатели софта, никаких цифровых подписей наших программ мы делать не планируем.

# Команды cmd и powershell, которые использует программа
## 1. Изменение языка системы
   
Это действие производится при помощи одной из этих команд powershell

`Set-WinUILanguageOverride zh-CN - китайский язык`

`Set-WinUILanguageOverride ru-RU - русский язык`

`Set-WinUILanguageOverride en-US - английский язык`

## 2. Изменение системного времени
   
Производится при помощи системной утилиты tzutil в командрой строке по формату tzutil /s timezoneID. Где timezoneID это непосредственно словесное обозначение той или иной временной зоны конкретного региодна. Список всех timezoneID программа достаёт из самой системы.
Пример готовой команды cmd для этой утилиты:

`tzutil /s 'Russian Standard Time' - установить часовой пояс (UTC+3) Москва`

## 3. Добавление и удаление раскладки клавиатуры
   
Эта операция не может быть выполнена в одну строку (или я не в курсе как это сделать), поэтому исполняется скрипт powershell.
Для добавления раскладки:
```Shell
$list = Get-WinUserLanguageList
$list.Add('zh-Hans-CN')
Set-WinUserLanguageList $list -Force
```

Для удаления:
```Shell
$LanguageList = Get-WinUserLanguageList
$DeleteLang = $LanguageList | where LanguageTag -eq 'zh-Hans-CN'
$LanguageList.Remove($DeleteLang)
Set-WinUserLanguageList $LanguageList -Force
```
## 4. Установка и удаление языковых пакетов
   
Операция выполняется командой powershell в одну строку. Однако, это единственная команда, которая требует административных прав пользователя в системе. Именно из-за этой команды требуется запускать программу от имени администратора. Также, после добавления этой команды, на программу начал ругаться системный антивирусник win11.
Команда для установки китайского языка:

`Install-Language -Language zh-cn -ExcludeFeatures`

Для удаления:

`Uninstall-Language -Language zh-cn`


## 5. Выход из системы / Перезагрузка
   
Команда cmd для выхода из системы:

`shutdown /l`

Для перезагрузки команда powershell:

`Restart-Computer`

