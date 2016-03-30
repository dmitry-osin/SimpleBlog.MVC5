# SimpleBlog
Опыт написания блога на ASP.NET MVC5, Identity 2, EF6.1, Bootstrap, Less

# Потрогать можно тут:
- http://dmitryalexosin-001-site1.btempurl.com/ сайт, 
- http://dmitryalexosin-001-site1.btempurl.com/admin админка, 
так же тут
- http://demo-osin.azurewebsites.net/ сайт
- http://demo-osin.azurewebsites.net/admin админка

- логин demo, 
- пароль demo

# Компоненты
В проекте используется:
- ASP.NET MVC5
- Identity 2
- EF 6
- SQL Server Compact / SQL Server
- 3 Layers Structure (DAL, BLL, UI)
- UnitOfWork Patter
- CSS (Less)
- JS, TypeScript
- Bootstrap
- JQuery, JQuery-Val
- TinyMCE Editor

# Структура проекта 
- Базовые настройки приложения производятся в Settings.config в WebUI проекте
- Контекст базы данных ApplicationContext находится в SimpleBlog.DAL.Context
- Контракты находятся в SimpleBlog.DAL.DataContracts
- UnitOfWork находится в SimpleBlog.DAL.DataService
- ApplicationUserManager находится в SimpleBlog.DAL.Identity
- Объектные модели находятся в SimpleBlog.DAL.Object_Model
- ViewModel'и находятся в SimpleBlog.DAL.ViewModel и мапятся через AutoMapper
- Конфиг AutoMapperConfig Находится в SimpleBlog.WebUI.App_Start
- Репозитории находятся в SimpleBlog.DAL.Repository и регистрируются в UnitOfWork согласно шаблону проектирования
- Инициализация базы данных BlogDbInitializer находится в SimpleBlog.DAL.Utils и регистрируется в Global.asax
- Инициализация настроек из Settings.config через XMLSettingsProvider находится в SimpleBlog.DAL.Utils
- Сервис работы с настройками AppSettingsStore находится в SimpleBlog.DAL.Utils, работает через UnitOfWork (Репозиторий SettingsRepository, контракт ISettingsRepository)
- Регистрация компонентов Identity производится через файл запуска OWIN Startup.Auth, который находится в SimpleBlog.WebUI.App_Start
- Редактирование пользователя

# Реализовано
- Добавление, удаление, изменение записей
- Редактирование пользователей
- Редактирование настроек
- Добавлен TinyMCE
- Добавлен Prettify для подсветки кода


