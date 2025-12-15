# 🎫 SupportSystem

**Полнофункциональная веб-система управления заявками для служб технической поддержки**

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![.NET Version](https://img.shields.io/badge/.NET-6.0+-blue)](https://dotnet.microsoft.com/)
[![C# Version](https://img.shields.io/badge/C%23-10+-green)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Status](https://img.shields.io/badge/Status-Active-brightgreen)](https://github.com/Naviuki/SupportSystem)
[![Last Update](https://img.shields.io/badge/Last%20Update-Dec%202025-blueviolet)](https://github.com/Naviuki/SupportSystem)

---

## 📖 Оглавление

- [Описание](#описание)
- [Возможности](#возможности)
- [Технологический стек](#технологический-стек)
- [Структура проекта](#структура-проекта)
- [Установка и запуск](#установка-и-запуск)
- [Использование](#использование)
- [Архитектура](#архитектура)
- [База данных](#база-данных)
- [API документация](#api-документация)
- [Безопасность](#безопасность)
- [Тестирование](#тестирование)
- [Развёртывание](#развёртывание)
- [Дорожная карта](#дорожная-карта)
- [Вклад в проект](#вклад-в-проект)
- [Решение проблем](#решение-проблем)
- [FAQ](#faq)
- [Лицензия](#лицензия)
- [Контакты](#контакты)

---

## 📋 Описание

**SupportSystem** — это современное веб-приложение для управления обращениями и заявками в службах технической поддержки. Система разработана на актуальном стеке технологий ASP.NET Core и позволяет:

- **Пользователям** быстро создавать заявки и отслеживать их статус
- **Операторам поддержки** эффективно распределять работу и решать проблемы
- **Администраторам** управлять системой и анализировать метрики

Проект демонстрирует профессиональный подход к разработке enterprise-приложений с использованием современных архитектурных паттернов, лучших практик и принципов SOLID.

---

## ✨ Основные возможности

### 👤 Для пользователей

| Функция | Описание |
|---------|---------|
| 📝 Создание заявок | Быстрое создание обращения с описанием проблемы |
| 🔍 Просмотр истории | Полная история всех своих заявок с фильтрацией |
| 📊 Отслеживание статуса | Получение уведомлений об изменении статуса в реальном времени |
| 💬 Коммуникация | Диалог с оператором через встроенную систему комментариев |
| 📎 Загрузка файлов | Возможность прикрепить файлы, скриншоты и вложения |
| ⭐ Оценка решения | Возможность оценить работу оператора и оставить отзыв |

### 👨‍💼 Для операторов поддержки

| Функция | Описание |
|---------|---------|
| 📊 Панель управления | Дашборд со статистикой по заявкам (новые, в работе, закрытые) |
| 🔄 Распределение задач | Назначение заявок себе или коллегам вручную или автоматически |
| 💬 Система чата | Встроенный мессенджер для коммуникации с пользователем |
| 🏷️ Категоризация | Теги и категории для быстрой классификации заявок |
| ⏱️ Управление временем | Отслеживание времени работы над заявкой |
| 📈 Аналитика | Отчёты по времени решения, статистике переоценок и т.д. |
| 🔍 Поиск и фильтрация | Быстрый поиск по номеру заявки, тексту, автору |
| 📌 Примечания | Внутренние примечания для командной работы |

### 🔧 Для администраторов

| Функция | Описание |
|---------|---------|
| 👥 Управление пользователями | Создание, удаление, редактирование учётных записей |
| 🔐 Управление ролями | Настройка ролей и прав доступа (RBAC) |
| ⚙️ Конфигурация | Управление приоритетами, категориями, статусами заявок |
| 📋 Аудит | Логирование и просмотр всех действий пользователей |
| 🎨 Кастомизация | Настройка параметров системы и интерфейса |
| 📊 Системная аналитика | Общая статистика, метрики производительности |
| 🔔 Уведомления | Управление шаблонами уведомлений |

---

## 🛠️ Технологический стек

### Backend
```
Платформа:      ASP.NET Core 6.0 / 7.0 / 8.0
Язык:           C# 10+
Веб-фреймворк:  ASP.NET MVC / Razor Pages
ORM:            Entity Framework Core 6.0+
Аутентификация: ASP.NET Identity
Логирование:    Serilog
Валидация:      FluentValidation
API Docs:       Swagger / OpenAPI 3.0
```

### Frontend
```
HTML:           HTML5
Стили:          CSS3 / Bootstrap 5 / Tailwind CSS
Скриптинг:      Vanilla JavaScript / jQuery
Шаблонизация:   Razor Templates
```

### База данных
```
СУБД:           SQL Server 2016+
Миграции:       Entity Framework Core Migrations
Кеширование:    Redis (опционально)
```

### Инфраструктура
```
Version Control: Git / GitHub
CI/CD:          GitHub Actions
Docker:         Dockerfile для контейнеризации
Среда разработки: Visual Studio 2022 / Rider / VS Code
```

### Тестирование
```
Unit-тесты:     xUnit
Mocking:        Moq
Интеграционные: WebApplicationFactory
```

---

## 📁 Структура проекта

```
SupportSystem/
│
├── 📂 src/                                  # Исходный код приложения
│   │
│   ├── 📂 SupportSystem.Web/               # Основной web-проект
│   │   ├── 📂 Controllers/                 # MVC контроллеры
│   │   │   ├── HomeController.cs
│   │   │   ├── TicketController.cs
│   │   │   ├── AccountController.cs
│   │   │   └── AdminController.cs
│   │   │
│   │   ├── 📂 Pages/                       # Razor Pages
│   │   │   ├── Dashboard.cshtml
│   │   │   ├── CreateTicket.cshtml
│   │   │   └── TicketDetails.cshtml
│   │   │
│   │   ├── 📂 Views/                       # MVC Views
│   │   │   ├── 📂 Shared/
│   │   │   │   ├── _Layout.cshtml
│   │   │   │   └── _ValidationScriptsPartial.cshtml
│   │   │   └── 📂 Home/
│   │   │       └── Index.cshtml
│   │   │
│   │   ├── 📂 wwwroot/                     # Статические файлы
│   │   │   ├── 📂 css/
│   │   │   │   ├── site.css
│   │   │   │   └── bootstrap.min.css
│   │   │   ├── 📂 js/
│   │   │   │   ├── site.js
│   │   │   │   └── jquery.min.js
│   │   │   └── 📂 images/
│   │   │
│   │   ├── 📂 Middleware/                  # Пользовательское middleware
│   │   │   ├── ExceptionHandlingMiddleware.cs
│   │   │   └── LoggingMiddleware.cs
│   │   │
│   │   ├── appsettings.json               # Конфигурация приложения
│   │   ├── appsettings.Development.json   # Конфигурация разработки
│   │   ├── Program.cs                     # Точка входа
│   │   └── SupportSystem.Web.csproj       # Файл проекта
│   │
│   ├── 📂 SupportSystem.Core/              # Доменные модели и интерфейсы
│   │   ├── 📂 Models/                      # Доменные сущности
│   │   │   ├── Ticket.cs                  # Модель заявки
│   │   │   ├── User.cs                    # Модель пользователя
│   │   │   ├── Comment.cs                 # Модель комментария
│   │   │   ├── Category.cs                # Модель категории
│   │   │   └── TicketStatus.cs            # Перечисление статусов
│   │   │
│   │   ├── 📂 Enums/                      # Перечисления
│   │   │   ├── Priority.cs                # Приоритет
│   │   │   ├── StatusType.cs              # Тип статуса
│   │   │   └── UserRole.cs                # Роли пользователей
│   │   │
│   │   ├── 📂 Interfaces/                 # Контракты сервисов
│   │   │   ├── ITicketService.cs
│   │   │   ├── IUserService.cs
│   │   │   ├── ICommentService.cs
│   │   │   ├── IRepository.cs
│   │   │   └── IUnitOfWork.cs
│   │   │
│   │   └── SupportSystem.Core.csproj
│   │
│   ├── 📂 SupportSystem.Infrastructure/    # Реализация доступа к данным
│   │   ├── 📂 Data/                        # Слой доступа к БД
│   │   │   ├── AppDbContext.cs            # Entity Framework DbContext
│   │   │   ├── 📂 Configurations/          # EF конфигурации моделей
│   │   │   │   ├── TicketConfiguration.cs
│   │   │   │   └── UserConfiguration.cs
│   │   │   └── DbInitializer.cs           # Инициализация БД
│   │   │
│   │   ├── 📂 Repositories/                # Реализация репозиториев
│   │   │   ├── GenericRepository.cs
│   │   │   ├── TicketRepository.cs
│   │   │   ├── UserRepository.cs
│   │   │   └── UnitOfWork.cs
│   │   │
│   │   ├── 📂 Migrations/                  # EF Core миграции
│   │   │   ├── 20250101_InitialCreate.cs
│   │   │   ├── 20250102_AddUserRoles.cs
│   │   │   └── 20250103_AddComments.cs
│   │   │
│   │   └── SupportSystem.Infrastructure.csproj
│   │
│   ├── 📂 SupportSystem.Services/          # Бизнес-логика
│   │   ├── 📂 Services/
│   │   │   ├── TicketService.cs           # Сервис работы с заявками
│   │   │   ├── UserService.cs             # Сервис работы с пользователями
│   │   │   ├── CommentService.cs          # Сервис комментариев
│   │   │   ├── NotificationService.cs     # Сервис уведомлений
│   │   │   └── ReportService.cs           # Сервис отчётов
│   │   │
│   │   ├── 📂 Validators/                 # Валидаторы FluentValidation
│   │   │   ├── CreateTicketValidator.cs
│   │   │   └── CreateUserValidator.cs
│   │   │
│   │   ├── 📂 DTOs/                       # Data Transfer Objects
│   │   │   ├── TicketDto.cs
│   │   │   ├── UserDto.cs
│   │   │   ├── CommentDto.cs
│   │   │   └── ReportDto.cs
│   │   │
│   │   ├── AutoMapperProfile.cs           # Конфигурация AutoMapper
│   │   └── SupportSystem.Services.csproj
│   │
│   └── SupportSystem.sln                  # Solution файл
│
├── 📂 tests/                               # Тесты
│   ├── 📂 SupportSystem.Tests/             # Unit тесты
│   │   ├── Services/
│   │   │   ├── TicketServiceTests.cs
│   │   │   └── UserServiceTests.cs
│   │   ├── Controllers/
│   │   │   └── TicketControllerTests.cs
│   │   └── SupportSystem.Tests.csproj
│   │
│   └── 📂 SupportSystem.Integration.Tests/ # Интеграционные тесты
│       ├── TicketIntegrationTests.cs
│       └── SupportSystem.Integration.Tests.csproj
│
├── 📂 docs/                                # Документация
│   ├── ARCHITECTURE.md                    # Описание архитектуры
│   ├── API.md                             # API документация
│   ├── DATABASE.md                        # Схема БД
│   └── DEPLOYMENT.md                      # Развёртывание
│
├── 📄 .gitignore                          # Gitignore файл
├── 📄 .github/                            # GitHub конфигурация
│   └── workflows/                         # GitHub Actions
│       ├── ci.yml                         # CI pipeline
│       └── cd.yml                         # CD pipeline
├── 📄 Dockerfile                          # Docker конфигурация
├── 📄 docker-compose.yml                  # Docker Compose
├── 📄 README.md                           # Этот файл
└── 📄 LICENSE                             # Лицензия MIT

```

---

## 🚀 Установка и запуск

### Предварительные требования

**Системные требования:**
- Windows 10/11, macOS 10.15+, Linux (Ubuntu 18.04+)
- RAM: минимум 4 GB (рекомендуется 8 GB)
- Место на диске: минимум 2 GB

**Необходимое ПО:**
- **.NET SDK 6.0+** — [Скачать](https://dotnet.microsoft.com/download)
  ```bash
  # Проверка установки
  dotnet --version
  ```

- **SQL Server 2016+** (локально или удалённо)
  - Для Windows: [SQL Server Express](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
  - Для Linux/Mac: [SQL Server on Docker](https://hub.docker.com/r/mcr.microsoft.com/mssql/server)
  
- **IDE** (на выбор):
  - [Visual Studio 2022 Community](https://visualstudio.microsoft.com/vs/) (рекомендуется для Windows)
  - [JetBrains Rider](https://www.jetbrains.com/rider/) (кроссплатформенно)
  - [Visual Studio Code](https://code.visualstudio.com/) + C# расширение

- **Git** — [Скачать](https://git-scm.com/)

### Пошаговая установка

#### Шаг 1: Клонирование репозитория

```bash
# Клонируй репозиторий
git clone https://github.com/Naviuki/SupportSystem.git

# Перейди в директорию проекта
cd SupportSystem
```

#### Шаг 2: Восстановление зависимостей

```bash
# Восстанови все NuGet пакеты
dotnet restore
```

#### Шаг 3: Настройка базы данных

**Вариант 3.1: Локальный SQL Server Express**

Отредактируй файл `src/SupportSystem.Web/appsettings.Development.json`:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SupportSystemDb;Trusted_Connection=true;"
  },
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning"
    }
  }
}
```

**Вариант 3.2: Удалённый SQL Server**

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=SupportSystemDb;User Id=sa;Password=YourPassword;"
  }
}
```

**Вариант 3.3: Docker (SQL Server)**

```bash
# Запусти SQL Server в контейнере
docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=YourPassword123!" \
  -p 1433:1433 \
  -d mcr.microsoft.com/mssql/server:2019-latest
```

Затем используй строку подключения:
```json
"DefaultConnection": "Server=localhost,1433;Database=SupportSystemDb;User Id=sa;Password=YourPassword123;"
```

#### Шаг 4: Применение миграций БД

```bash
# Перейди в папку с проектом Infrastructure
cd src/SupportSystem.Infrastructure

# Примени миграции (создаст таблицы в БД)
dotnet ef database update

# Вернись в корневую папку
cd ../..
```

Если возникают ошибки с Tools:
```bash
# Установи глобальные EF Tools
dotnet tool install --global dotnet-ef

# Обнови их до последней версии
dotnet tool update --global dotnet-ef
```

#### Шаг 5: Запуск приложения

**Вариант А: Из командной строки**

```bash
# Переди в папку Web проекта
cd src/SupportSystem.Web

# Запусти приложение
dotnet run

# Приложение будет доступно по адресу:
# http://localhost:5000
# https://localhost:5001
```

**Вариант Б: Из Visual Studio**

1. Открой `SupportSystem.sln`
2. В Solution Explorer выбери `SupportSystem.Web` как Startup Project
3. Нажми `F5` или `Debug > Start Debugging`
4. Приложение откроется в браузере автоматически

**Вариант В: С использованием Docker**

```bash
# Собери Docker образ
docker build -t supportsystem:latest .

# Запусти контейнер с приложением и БД
docker-compose up -d

# Приложение будет доступно по адресу:
# http://localhost:5000
```

---

## 📖 Использование

### Первый запуск

1. **Открыть приложение** по адресу `https://localhost:5001`
2. **Создать администраторский аккаунт** (если требуется)
3. **Авторизоваться** с учётными данными по умолчанию

### Создание заявки (для пользователя)

```
1. Авторизуйся в приложении
2. Нажми кнопку "Новая заявка" на главной странице
3. Заполни форму:
   ✓ Тема/Название заявки (обязательно)
   ✓ Описание проблемы (обязательно)
   ✓ Приоритет (Низкий / Средний / Высокий / Критичный)
   ✓ Категория (Техническая поддержка / Биллинг / Другое)
   ✓ Вложение файлов (опционально)
4. Нажми кнопку "Создать заявку"
5. Ты получишь номер заявки (например, #12345)
6. Отслеживай статус в личном кабинете
```

### Работа с заявкой (для оператора)

```
1. Открой "Панель управления"
2. Посмотри список новых заявок
3. Выбери заявку для работы
4. Нажми "Назначить на себя" (или выбери коллегу)
5. Измени статус на "В работе"
6. Добавляй комментарии при изменении статуса
7. При решении установи статус "Закрыта"
8. Система отправит уведомление пользователю
```

### Администрирование

```
1. Перейди в "Параметры" → "Администрирование"
2. Управляй пользователями:
   - Создание/удаление учётных записей
   - Назначение ролей
   - Просмотр активности
3. Настраивай категории и приоритеты
4. Просматривай логи и аудит
5. Экспортируй отчёты
```

---

## 🏗️ Архитектура

### Многоуровневая архитектура (Layered Architecture)

```
┌─────────────────────────────────────────────┐
│         Presentation Layer (Web UI)         │  Controllers, Razor Pages, ViewModels
├─────────────────────────────────────────────┤
│          Business Logic Layer                │  Services, Validators, DTOs
├─────────────────────────────────────────────┤
│          Data Access Layer (DAL)             │  Repositories, Entity Framework
├─────────────────────────────────────────────┤
│              Database Layer                  │  SQL Server, Migrations
└─────────────────────────────────────────────┘
```

### Используемые паттерны проектирования

- **Repository Pattern** — абстракция доступа к данным
- **Unit of Work Pattern** — управление транзакциями
- **Dependency Injection** — внедрение зависимостей
- **Service Locator Pattern** — регистрация сервисов
- **DTO (Data Transfer Objects)** — передача данных между слоями
- **Decorator Pattern** — логирование и аудит
- **Strategy Pattern** — различные стратегии фильтрации и поиска

### Принципы SOLID

- **S**ingle Responsibility — каждый класс отвечает за одно
- **O**pen/Closed — классы открыты для расширения, закрыты для модификации
- **L**iskov Substitution — подтипы должны быть заменяемы на базовые типы
- **I**nterface Segregation — много специфичных интерфейсов лучше, чем один общий
- **D**ependency Inversion — зависимости от абстракций, а не от конкретных реализаций

---

## 🗄️ База данных

### Главные таблицы

#### Users (Пользователи)
```sql
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(256) UNIQUE NOT NULL,
    Email NVARCHAR(256) UNIQUE NOT NULL,
    PasswordHash NVARCHAR(MAX) NOT NULL,
    FullName NVARCHAR(256),
    Role NVARCHAR(50) NOT NULL,           -- Admin, Support, User
    IsActive BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE()
);
```

#### Tickets (Заявки)
```sql
CREATE TABLE Tickets (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TicketNumber NVARCHAR(10) UNIQUE NOT NULL,  -- Например: #12345
    Title NVARCHAR(256) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    Status NVARCHAR(50) DEFAULT 'New',          -- New, InProgress, Resolved, Closed
    Priority INT DEFAULT 2,                      -- 1=Low, 2=Medium, 3=High, 4=Critical
    Category NVARCHAR(100),
    CreatedById INT NOT NULL,
    AssignedToId INT,
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    ClosedAt DATETIME NULL,
    FOREIGN KEY (CreatedById) REFERENCES Users(Id),
    FOREIGN KEY (AssignedToId) REFERENCES Users(Id)
);
```

#### Comments (Комментарии)
```sql
CREATE TABLE Comments (
    Id INT PRIMARY KEY IDENTITY(1,1),
    TicketId INT NOT NULL,
    AuthorId INT NOT NULL,
    Content NVARCHAR(MAX) NOT NULL,
    IsInternalNote BIT DEFAULT 0,          -- Скрыто от пользователя
    CreatedAt DATETIME DEFAULT GETDATE(),
    UpdatedAt DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (TicketId) REFERENCES Tickets(Id) ON DELETE CASCADE,
    FOREIGN KEY (AuthorId) REFERENCES Users(Id)
);
```

#### Categories (Категории)
```sql
CREATE TABLE Categories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL UNIQUE,
    Description NVARCHAR(MAX),
    IsActive BIT DEFAULT 1,
    CreatedAt DATETIME DEFAULT GETDATE()
);
```

### Диаграмма ER (Entity-Relationship)

```
┌──────────────┐          ┌──────────────┐
│    Users     │          │   Tickets    │
├──────────────┤          ├──────────────┤
│ Id (PK)      │◄─────────│ CreatedById  │
│ Username     │     1:M  │ AssignedToId │
│ Email        │◄─────────│ Id (PK)      │
│ PasswordHash │          │ Title        │
│ Role         │          │ Status       │
│ FullName     │          │ Priority     │
│ CreatedAt    │          │ Category     │
└──────────────┘          └──────────────┘
                                 │
                                 │ 1:M
                                 │
                           ┌──────────────┐
                           │  Comments    │
                           ├──────────────┤
                           │ Id (PK)      │
                           │ TicketId(FK) │
                           │ AuthorId(FK) │
                           │ Content      │
                           │ CreatedAt    │
                           └──────────────┘
```

---

## 📚 API документация

### Swagger UI

После запуска приложения откройте в браузере:

```
https://localhost:5001/swagger/index.html
```

Здесь доступна полная интерактивная документация всех API endpoints.

### Примеры основных endpoints

#### Получить все заявки пользователя
```
GET /api/tickets/my-tickets
Authorization: Bearer {token}

Response: 200 OK
[
  {
    "id": 1,
    "ticketNumber": "TICK-00001",
    "title": "Не работает вход",
    "status": "InProgress",
    "priority": 3,
    "createdAt": "2025-12-13T10:30:00Z"
  }
]
```

#### Создать новую заявку
```
POST /api/tickets
Content-Type: application/json
Authorization: Bearer {token}

Body:
{
  "title": "Ошибка при оплате",
  "description": "При попытке оплатить подписку выбивает ошибку 500",
  "categoryId": 2,
  "priority": 3
}

Response: 201 Created
{
  "id": 2,
  "ticketNumber": "TICK-00002",
  "title": "Ошибка при оплате",
  "status": "New",
  "createdAt": "2025-12-13T11:00:00Z"
}
```

#### Получить детали заявки
```
GET /api/tickets/{id}
Authorization: Bearer {token}

Response: 200 OK
{
  "id": 1,
  "ticketNumber": "TICK-00001",
  "title": "Не работает вход",
  "description": "...",
  "status": "InProgress",
  "priority": 3,
  "assignedTo": {
    "id": 5,
    "username": "support_operator"
  },
  "comments": [
    {
      "id": 1,
      "author": "support_operator",
      "content": "Понял проблему, работаю над решением",
      "createdAt": "2025-12-13T10:45:00Z"
    }
  ]
}
```

#### Добавить комментарий к заявке
```
POST /api/tickets/{id}/comments
Content-Type: application/json
Authorization: Bearer {token}

Body:
{
  "content": "Проблема решена, пересоздайте сессию",
  "isInternalNote": false
}

Response: 201 Created
{
  "id": 2,
  "content": "Проблема решена, пересоздайте сессию",
  "author": "support_operator",
  "createdAt": "2025-12-13T11:15:00Z"
}
```

#### Изменить статус заявки
```
PATCH /api/tickets/{id}/status
Content-Type: application/json
Authorization: Bearer {token}

Body:
{
  "status": "Resolved"
}

Response: 200 OK
{
  "id": 1,
  "status": "Resolved",
  "updatedAt": "2025-12-13T11:20:00Z"
}
```

---

## 🔐 Безопасность

### Реализованные меры безопасности

#### Аутентификация и авторизация

- ✅ **ASP.NET Identity** для управления пользователями
- ✅ **Хеширование паролей** (PBKDF2 по умолчанию)
- ✅ **JWT токены** для API (опционально)
- ✅ **Role-Based Access Control (RBAC)** — контроль доступа на основе ролей
- ✅ **Двухфакторная аутентификация (2FA)** — поддержка TOTP

```csharp
// Пример использования ролей
[Authorize(Roles = "Admin,SupportOperator")]
public IActionResult Dashboard()
{
    return View();
}
```

#### Защита от атак

- ✅ **CSRF Protection** — Anti-Forgery tokens на всех формах
  ```html
  <form method="POST" action="/tickets/create">
      @Html.AntiForgeryToken()
      <!-- формы -->
  </form>
  ```

- ✅ **XSS Prevention** — HTML encoding для всех пользовательских данных
  ```csharp
  // Razor автоматически экранирует HTML
  <p>@Model.UserInput</p>
  ```

- ✅ **SQL Injection Prevention** — параметризованные запросы через EF Core
  ```csharp
  // Безопасно: параметр автоматически экранируется
  var tickets = _context.Tickets
      .Where(t => t.Title.Contains(searchTerm))
      .ToList();
  ```

- ✅ **Rate Limiting** — ограничение количества запросов
- ✅ **Input Validation** — валидация на клиенте и сервере
- ✅ **HTTPS Only** — все соединения зашифрованы

#### Защита конфиденциальных данных

- ✅ **Пароли в конфигурации** хранятся в User Secrets (локально) или Environment Variables (production)
  ```bash
  # Локально (development)
  dotnet user-secrets set "ConnectionStrings:DefaultConnection" "..."
  
  # Production (через переменные окружения)
  export ASPNETCORE_ConnectionStrings__DefaultConnection="..."
  ```

- ✅ **Логирование** никогда не содержит чувствительные данные (пароли, токены)
- ✅ **GDPR Compliance** — удаление личных данных пользователя

```csharp
// Пример: удаление всех данных пользователя
public async Task DeleteUserDataAsync(int userId)
{
    var user = await _userRepository.GetByIdAsync(userId);
    var tickets = await _ticketRepository.GetByCreatorAsync(userId);
    
    // Удалить все заявки пользователя
    foreach (var ticket in tickets)
    {
        await _ticketRepository.DeleteAsync(ticket);
    }
    
    // Удалить учётную запись
    await _userRepository.DeleteAsync(user);
}
```

#### Логирование безопасности

- ✅ Логирование попыток входа (успешные и неудачные)
- ✅ Логирование изменения ролей
- ✅ Логирование доступа к критическим операциям
- ✅ Хранение логов с временными метками и IP адресами

```csharp
public async Task<bool> LoginAsync(string username, string password)
{
    var user = await _userManager.FindByNameAsync(username);
    
    if (user == null || !await _userManager.CheckPasswordAsync(user, password))
    {
        _logger.LogWarning($"Failed login attempt for user: {username} from IP: {GetClientIp()}");
        return false;
    }
    
    _logger.LogInformation($"User {username} successfully logged in from IP: {GetClientIp()}");
    return true;
}
```

---

## 🧪 Тестирование

### Запуск тестов

#### Все тесты
```bash
dotnet test
```

#### Только unit-тесты
```bash
dotnet test tests/SupportSystem.Tests/
```

#### Только интеграционные тесты
```bash
dotnet test tests/SupportSystem.Integration.Tests/
```

#### Тесты с фильтром
```bash
# Тесты содержащие "Ticket" в названии
dotnet test --filter "FullyQualifiedName~Ticket"

# Только тесты из конкретного класса
dotnet test --filter "ClassName=TicketServiceTests"
```

### Покрытие кода

```bash
# Установить инструмент для покрытия
dotnet tool install --global OpenCover

# Запустить тесты с анализом покрытия
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura

# Просмотреть отчет
# Файл будет создан в coverage/coverage.cobertura.xml
```

### Примеры тестов

#### Unit-тест сервиса
```csharp
[Fact]
public async Task CreateTicket_WithValidData_ReturnsNewTicket()
{
    // Arrange
    var ticketService = new TicketService(_mockRepository.Object);
    var createDto = new CreateTicketDto
    {
        Title = "Test Ticket",
        Description = "Test Description",
        Priority = 2
    };

    // Act
    var result = await ticketService.CreateAsync(createDto);

    // Assert
    Assert.NotNull(result);
    Assert.Equal("Test Ticket", result.Title);
    _mockRepository.Verify(r => r.AddAsync(It.IsAny<Ticket>()), Times.Once);
}
```

#### Интеграционный тест контроллера
```csharp
[Fact]
public async Task CreateTicket_WithValidData_Returns201Created()
{
    // Arrange
    var client = _factory.CreateClient();
    var createRequest = new { title = "Test", description = "Desc" };

    // Act
    var response = await client.PostAsJsonAsync("/api/tickets", createRequest);

    // Assert
    Assert.Equal(System.Net.HttpStatusCode.Created, response.StatusCode);
    var content = await response.Content.ReadAsAsync<TicketDto>();
    Assert.NotNull(content.TicketNumber);
}
```

---

## 🐳 Развёртывание

### Docker

#### Сборка и запуск локально

```bash
# Построить Docker образ
docker build -t supportsystem:latest .

# Запустить контейнер
docker run -d \
  -p 5001:5001 \
  -e "ConnectionStrings:DefaultConnection=Server=sql-server;Database=SupportSystemDb;..." \
  --name supportsystem \
  supportsystem:latest

# Просмотреть логи
docker logs -f supportsystem

# Остановить контейнер
docker stop supportsystem
```

#### Docker Compose (приложение + БД)

```bash
# Запустить оба контейнера (приложение и SQL Server)
docker-compose up -d

# Остановить
docker-compose down

# Просмотреть логи
docker-compose logs -f
```

### Публикация

#### IIS (Windows Server)

```bash
# 1. Опубликуй приложение
dotnet publish -c Release -o "./publish"

# 2. Создай App Pool в IIS
# 3. Создай сайт в IIS, указав папку publish
# 4. Установи .NET Hosting Bundle на сервере
# 5. Добавь строку подключения в web.config
# 6. Перезагрузи сайт
```

#### Azure App Service

```bash
# 1. Создай Resource Group
az group create --name RG-SupportSystem --location eastus

# 2. Создай App Service Plan
az appservice plan create --name SupportSystemPlan --resource-group RG-SupportSystem --sku B1

# 3. Создай Web App
az webapp create --resource-group RG-SupportSystem --plan SupportSystemPlan --name supportsystem-app

# 4. Развертни код
az webapp up --resource-group RG-SupportSystem --name supportsystem-app --runtime dotnet:6.0
```

#### GitHub Actions (CI/CD)

Автоматическая сборка и развёртывание при push:

```yaml
name: CI/CD Pipeline

on:
  push:
    branches: [ main, develop ]
  pull_request:
    branches: [ main ]

jobs:
  build:
    runs-on: ubuntu-latest
    steps:
    - uses: actions/checkout@v2
    
    - name: Setup .NET
      uses: actions/setup-dotnet@v1
      with:
        dotnet-version: '6.0.x'
    
    - name: Restore
      run: dotnet restore
    
    - name: Build
      run: dotnet build --configuration Release
    
    - name: Test
      run: dotnet test --verbosity normal
    
    - name: Publish
      run: dotnet publish -c Release -o ./publish
```

---

## 🗺️ Дорожная карта

### v1.0 ✅ (Текущая версия)
- [x] Базовая функциональность создания и управления заявками
- [x] Система ролей и доступа
- [x] Комментарии и история изменений
- [x] API с документацией Swagger

### v1.1 (Q1 2026)
- [ ] 📧 Email уведомления
- [ ] 📱 Push-уведомления в браузер (Web Push)
- [ ] 📊 Расширенная аналитика
- [ ] 🔍 Полнотекстовый поиск (Elasticsearch)

### v1.2 (Q2 2026)
- [ ] 🤖 Интеграция с Telegram ботом
- [ ] 📱 Мобильное приложение (MAUI)
- [ ] 🌍 Локализация (EN, RU, DE)
- [ ] ⏰ Календарь и планирование

### v2.0 (H2 2026)
- [ ] 🏗️ Миграция на микросервисную архитектуру
- [ ] ☁️ Kubernetes развёртывание
- [ ] 🔗 WebSocket для real-time обновлений
- [ ] 🎛️ Высокое нагруженное масштабирование

---

## 🤝 Вклад в проект

Спасибо за интерес к SupportSystem! Мы приветствуем вклады от сообщества.

### Как начать

1. **Fork** репозиторий на GitHub
2. **Clone** свой fork локально:
   ```bash
   git clone https://github.com/YOUR_USERNAME/SupportSystem.git
   cd SupportSystem
   ```
3. **Create** новую ветку для функции:
   ```bash
   git checkout -b feature/incredible-feature
   ```

### Процесс разработки

1. **Code** — напиши код новой функции
2. **Test** — убедись, что все тесты проходят:
   ```bash
   dotnet test
   ```
3. **Format** — отформатируй код:
   ```bash
   dotnet format
   ```
4. **Commit** — создай коммит с понятным сообщением:
   ```bash
   git commit -m "Add: incredible new feature"
   git commit -m "Fix: bug in ticket creation"
   git commit -m "Docs: update README"
   ```
5. **Push** — отправь в свой fork:
   ```bash
   git push origin feature/incredible-feature
   ```
6. **Pull Request** — создай PR в основной репозиторий

### Стиль кода

- Используй **C# naming conventions** (PascalCase для классов, camelCase для переменных)
- Пиши **понятные имена** для переменных и методов
- Добавляй **комментарии** для сложной логики
- Следуй **SOLID принципам**
- Максимум 100 символов в строке

```csharp
// ✅ Хорошо
public async Task<TicketDto> CreateTicketAsync(CreateTicketDto createDto)
{
    // Валидация входных данных
    if (string.IsNullOrWhiteSpace(createDto.Title))
        throw new ArgumentException("Title is required");
    
    var ticket = new Ticket { Title = createDto.Title };
    await _repository.AddAsync(ticket);
    return _mapper.Map<TicketDto>(ticket);
}

// ❌ Плохо
public TicketDto CT(CreateTicketDto d)
{
    var t = new Ticket { Title = d.Title }; // Непонятные названия
    _repository.AddAsync(t); // Нет await
    return t;
}
```

### Правила для PR

- [ ] Код следует стилю проекта
- [ ] Добавлены/обновлены тесты
- [ ] Все тесты проходят (`dotnet test`)
- [ ] Обновлена документация (если требуется)
- [ ] Коммиты имеют понятные сообщения
- [ ] Нет конфликтов с main веткой

###报告об ошибках

Нашёл баг? Создай issue с:
- Описанием проблемы
- Шагами воспроизведения
- Ожидаемое поведение vs реальное
- Версию .NET, ОС, браузер

---

## 🐛 Решение проблем

### Проблема: "Unable to connect to database"

**Решение:**
```bash
# 1. Проверь, запущен ли SQL Server
# 2. Проверь строку подключения в appsettings.json
# 3. Убедись, что база данных существует
# 4. Попробуй переиграть миграции:
dotnet ef database drop
dotnet ef database update
```

### Проблема: "Port 5001 is already in use"

**Решение:**
```bash
# Найди процесс, использующий порт
lsof -i :5001  # macOS/Linux
netstat -ano | findstr :5001  # Windows

# Убей процесс
kill -9 <PID>  # macOS/Linux
taskkill /PID <PID> /F  # Windows

# Или используй другой порт
dotnet run --urls "https://localhost:5002"
```

### Проблема: "EF Core Migration errors"

**Решение:**
```bash
# Удали последнюю миграцию
dotnet ef migrations remove

# Пересоздай её
dotnet ef migrations add FixedMigrationName

# Обнови БД
dotnet ef database update
```

### Проблема: "Authentication fails"

**Решение:**
```bash
# Переинициализируй Identity
dotnet ef database drop -f
dotnet ef database update

# Создай нового админа через seed script
# (смотри DbInitializer.cs)
```

### Проблема: "Swagger UI not loading"

**Решение:**
- Проверь, что Swagger enabled в Program.cs:
  ```csharp
  app.UseSwagger();
  app.UseSwaggerUI();
  ```
- Убедись, что используешь URL:
  - `https://localhost:5001/swagger` (не `/swagger/ui`)
  - `https://localhost:5001/swagger/index.html`

---

## ❓ FAQ

### Q: На каких версиях .NET запускается?
**A:** .NET 6.0+ требуется для всех компонентов. Проект также совместим с .NET 7.0 и 8.0.

### Q: Можно ли использовать MySQL вместо SQL Server?
**A:** Да, можно изменить провайдер EF Core:
```xml
<!-- Замени в .csproj -->
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" />
<!-- На -->
<PackageReference Include="Pomelo.EntityFrameworkCore.MySql" />
```

### Q: Как добавить свою роль?
**A:** 
```csharp
// В AppDbContext.OnModelCreating():
modelBuilder.Entity<IdentityRole>().HasData(
    new IdentityRole { Id = "custom-role", Name = "CustomRole" }
);
```

### Q: Как отключить регистрацию пользователей?
**A:** Отредактируй контроллер `AccountController.cs` и удали/закрой endpoint регистрации.

### Q: Где хранятся файлы, загруженные пользователями?
**A:** По умолчанию в папке `wwwroot/uploads/`. Можно изменить на облачное хранилище (Azure Blob, AWS S3).

### Q: Как изменить стиль интерфейса?
**A:** Отредактируй CSS файлы в `wwwroot/css/` или замени Bootstrap на другой фреймворк.

### Q: Можно ли развернуть на Linux?
**A:** Да, ASP.NET Core полностью поддерживает Linux. Используй Docker или развертни напрямую.

### Q: Как интегрировать OAuth2 (Google, GitHub)?
**A:** Добавь NuGet пакеты и настрой в Program.cs:
```csharp
services.AddAuthentication()
    .AddGoogle(options =>
    {
        options.ClientId = config["Authentication:Google:ClientId"];
        options.ClientSecret = config["Authentication:Google:ClientSecret"];
    });
```

---

## 📝 Лицензия

Этот проект лицензирован под лицензией **MIT** — свободна для личного и коммерческого использования.

Полный текст лицензии смотри в файле [LICENSE](LICENSE).

---

## 👨‍💻 Автор

**Naviuki** — Full-Stack Developer

- 🔗 GitHub: [@Naviuki](https://github.com/Naviuki)
- 🔗 LinkedIn: [LinkedIn Profile](https://linkedin.com/in/naviuki) (если есть)
- 📧 Email: naviuki@example.com (измени на реальный)

---

## 🙏 Благодарности

Спасибо за использование SupportSystem! Если проект был полезен:

- ⭐ **Star** на GitHub помогает узнать о проекте новым разработчикам
- 🔗 **Share** с друзьями и коллегами
- 📝 **Feedback** помогает улучшить проект
- 🤝 **Contribute** — присоединяйся к разработке!

---

## 📞 Поддержка и контакты

- 💬 **GitHub Issues** — для багов и предложений
- 💭 **GitHub Discussions** — для обсуждения идей
- 📧 **Email** — контакт в профиле GitHub

---

## 🔄 История обновлений

### v1.0.0 (13 Dec 2025)
- ✨ Первый публичный релиз
- ✅ Полная функциональность управления заявками
- ✅ API с документацией
- ✅ Система ролей и доступа

---

**Последнее обновление:** 13 Декабря 2025  
**Версия документации:** 1.0.0  
**Статус проекта:** 🟢 Активная разработка

---


---

*Made with ❤️ by Naviuki*
