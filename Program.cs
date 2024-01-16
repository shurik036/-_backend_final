using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Портфолио.Models;

var builder = WebApplication.CreateBuilder(args);
/*Создание экземпляра WebApplicationBuilder 
 * с использованием статического метода CreateBuilder, 
 * который инициализирует конфигурацию веб-приложения на основе переданных аргументов.*/


builder.Services.AddControllers();
/*Регистрация службы контроллеров в контейнере внедрения зависимостей.
 */
builder.Services.AddDbContext<dbContext>();
/* : Регистрация службы Entity Framework DbContext (dbContext) 
 * в контейнере внедрения зависимостей.
 * Предполагается, что dbContext является производным от DbContext.
 */


builder.Services.AddEndpointsApiExplorer();
/*Регистрация службы, предоставляющей 
 * метаданные API для инструментов документирования.*/

builder.Services.AddSwaggerGen();
/*Регистрация службы Swagger для генерации OpenAPI-спецификации 
 * на основе метаданных API.*/


var app = builder.Build();

/*Создание экземпляра WebApplication на основе настроек, 
 * определенных в WebApplicationBuilder*/


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*
 * if (app.Environment.IsDevelopment()): Проверка, находится ли приложение 
 * в режиме разработки.

app.UseSwagger();: Включение генерации Swagger JSON.

app.UseSwaggerUI();: Включение Swagger UI для просмотра документации в браузере.*/


app.UseHttpsRedirection();

//Включение перенаправления с HTTP на HTTPS.
//Это может быть полезным для обеспечения безопасности приложения.

app.UseAuthorization();
//Включение промежуточного слоя для обработки авторизации.

app.MapControllers();
//Настройка маршрутизации для контроллеров.

app.Run();

//Запуск приложения. Этот метод запускает приложение и начинает обработку запросов.
