# SimpleBlog
Опыт написания блога на ASP.NET MVC5, Identity 2, EF6.1, Bootstrap, Less

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
- Контекст базы данных ApplicationContext находится в SimpleBlog.DAL.Context
- Контракты находятся в SimpleBlog.DAL.DataContracts
- UnitOfWork находится в SimpleBlog.DAL.DataService
- ApplicationUserManager находится в SimpleBlog.DAL.Identity
- Объектные модели находятся в SimpleBlog.DAL.Object_Model
- ViewModel'и находятся в SimpleBlog.DAL.Object_Model и мапятся через AutoMapper
- Конфиг AutoMapperConfig Находится в SimpleBlog.WebUI.App_Start
- Репозитории находятся в SimpleBlog.DAL.Repository и регистрируются в UnitOfWork согласно шаблону проектирования
- Инициализация базы данных BlogDbInitializer находится в SimpleBlog.DAL.Utils и регистрируется в Global.asax
- Регистрация компонентов Identity производится через файл запуска OWIN Startup.Auth, который находится в SimpleBlog.WebUI.App_Start

# Реализовано
- Добавление, удаление, изменение записей
- Добавление, удаление пользователей (без UI)
- Добавление , удаление, изменение тегов (без UI)
- Добавлен TinyMCE
- Добавлен Pretty для подсветки кода


