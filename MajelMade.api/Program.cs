using MajelMade.Data.Contexts;
using MajelMade.Data.Repositories.Implementations;
using MajelMade.Data.Repositories.Interfaces;
using MajelMade.BusinessLogic.Interfaces;
using MajelMade.BusinessLogic.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure the DbContext
builder.Services.AddDbContext<MajelMadeDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MajelMadeDb")));

// Register business logic services
builder.Services.AddScoped<IEmployeeService, EmployeeService>();
builder.Services.AddScoped<IInventoryService, InventoryService>();
builder.Services.AddScoped<ILabelService, LabelService>();
builder.Services.AddScoped<IModificationTypeService, ModificationTypeService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IPackingService, PackingService>();
builder.Services.AddScoped<IRecipeService, RecipeService>();
builder.Services.AddScoped<IRoomService, RoomService>();
builder.Services.AddScoped<IShippingService, ShippingService>();

// Register repositories
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IInventoryRepository, InventoryRepository>();
builder.Services.AddScoped<ILabelRepository, LabelRepository>();
builder.Services.AddScoped<IModificationTypeRepository, ModificationTypeRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IPackingRepository, PackingRepository>();
builder.Services.AddScoped<IRecipeRepository, RecipeRepository>();
builder.Services.AddScoped<IRoomRepository, RoomRepository>();
builder.Services.AddScoped<IShippingRepository, ShippingRepository>();

// Add controller support and Swagger/OpenAPI documentation
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
