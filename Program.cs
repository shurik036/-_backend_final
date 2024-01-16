using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ���������.Models;

var builder = WebApplication.CreateBuilder(args);
/*�������� ���������� WebApplicationBuilder 
 * � �������������� ������������ ������ CreateBuilder, 
 * ������� �������������� ������������ ���-���������� �� ������ ���������� ����������.*/


builder.Services.AddControllers();
/*����������� ������ ������������ � ���������� ��������� ������������.
 */
builder.Services.AddDbContext<dbContext>();
/* : ����������� ������ Entity Framework DbContext (dbContext) 
 * � ���������� ��������� ������������.
 * ��������������, ��� dbContext �������� ����������� �� DbContext.
 */


builder.Services.AddEndpointsApiExplorer();
/*����������� ������, ��������������� 
 * ���������� API ��� ������������ ����������������.*/

builder.Services.AddSwaggerGen();
/*����������� ������ Swagger ��� ��������� OpenAPI-������������ 
 * �� ������ ���������� API.*/


var app = builder.Build();

/*�������� ���������� WebApplication �� ������ ��������, 
 * ������������ � WebApplicationBuilder*/


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/*
 * if (app.Environment.IsDevelopment()): ��������, ��������� �� ���������� 
 * � ������ ����������.

app.UseSwagger();: ��������� ��������� Swagger JSON.

app.UseSwaggerUI();: ��������� Swagger UI ��� ��������� ������������ � ��������.*/


app.UseHttpsRedirection();

//��������� ��������������� � HTTP �� HTTPS.
//��� ����� ���� �������� ��� ����������� ������������ ����������.

app.UseAuthorization();
//��������� �������������� ���� ��� ��������� �����������.

app.MapControllers();
//��������� ������������� ��� ������������.

app.Run();

//������ ����������. ���� ����� ��������� ���������� � �������� ��������� ��������.
