# Project: BookStore

## Description
A web application for online book sales with a comprehensive user management system, role-based access control, and book catalog management. The service provides an intuitive interface for both customers and administrators, facilitating a seamless book purchasing process and efficient inventory management.

## Functional Requirements

### Users and Roles

#### Anonymous User (Visitor)
- Can browse the book catalog without purchasing capability
- Can search books by title, author, genre, or ISBN
- Can view detailed book information including descriptions and prices

#### Administrator
- **CREATE**: Can add new books to the catalog with complete details
- **READ**: Can view all orders, customer data, and sales analytics
- **UPDATE**: Can edit book information, prices, stock quantities, and categories
- **DELETE**: Can remove books from catalog and manage user accounts
- Can manage book categories, genres, and author information
- Can manage inventory levels and receive low-stock alerts

### Book Catalog Features
- Display available books with covers, prices and descriptions
- Advanced filtering by genre, author, price range and publication date
- Search functionality across title, author, ISBN, and description fields

### Authentication & Authorization System
- User registration with email verification
- Secure login/logout functionality
- Password recovery and reset mechanisms

## Technical Specifications

## Deployment Requirements
- PostgreSQL database server
- .NET Core runtime environment
- Email service for notifications

## License
MIT License

----------------------------------------------------------------------
# Проект: Книжный Магазин (BookStore)

## Описание
Веб-приложение для онлайн-продажи книг с системой управления пользователями, ролями и каталогом книг. Сервис предоставляет удобный интерфейс для клиентов и администраторов, обеспечивая удобный процесс покупки книг и управления инвентарем.

## Функциональные требования

### Пользователи и роли

#### Анонимный пользователь (Посетитель)
- Может просматривать каталог книг без возможности покупки
- Может искать книги по названию, автору, жанру, ISBN
- Может просматривать детальную информацию о книгах

#### Администратор
- **CREATE**: Может добавлять новые книги в каталог с полной информацией
- **READ**: Может просматривать все заказы, данные клиентов и аналитику продаж
- **UPDATE**: Может редактировать информацию о книгах, цены, количество на складе
- **DELETE**: Может удалять книги из каталога и управлять учетными записями пользователей
- Может управлять категориями книг, жанрами и информацией об авторах

### Функции каталога книг
- Отображение доступных книг с обложками, ценами, описаниями и рейтингами
- Расширенная фильтрация по жанру, автору, ценовому диапазону, дате публикации и рейтингу
- Функция поиска по названию, автору, ISBN и описанию

### Система аутентификации и авторизации
- Регистрация пользователя с подтверждением email
- Безопасный вход/выход из системы
- Восстановление и сброс пароля

## Требования к развертыванию
- Сервер базы данных PostgreSQL
- Среда выполнения .NET Core
- Служба email для уведомлений
  
## Лицензия
MIT License

---
