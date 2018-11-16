# Задача

Вариант № 3. Реализовать приложение, забирающее 50 актуальных вакансии с сайта hh.ru  либо
любого другого сайта с вакансиями (job.ru и т. д.) с поиском по загруженным вакансиям.
Приложение должно сохранять вакансии в базе данных (одной, на выбор соискателя: MS Access,
MS SQL Server, Postgres). Приложение должно поддерживать работу как в присоединенном к сайту
режиме, так и только с сохраненными в БД вакансиями (с отключенным Интернет-соединением).

Использовать стек технологий ASP.NET (более конкретней - на ваш выбор)

# Решение

## Окружение:
* .NET Core 2.1 (https://www.microsoft.com/net/download)
* PostgreSQL 10
* git

## Получение исходного кода
```sh
> git clone https://github.com/cbelyaev/astral-vacancy.git
```

## Создание БД
```sh
> cd astral-vacancy/Backend/Dal.Impl
> dotnet ef database update
```

Строка подключения к БД для design-time находится в файле `DesignTimeDbContextFactory.cs`.

## Запуск сервера
```sh
> cd ../WebApi
> dotnet run
```

Строка подключения к БД для run-time находится в файле `appsettings.json`.

## Запуск тестового клиента (в отдельном окне терминала)
```sh
> cd astral-vacancy/Frontend/Client
> dotnet run
```
