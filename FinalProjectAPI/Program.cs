using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
//This only exists ONCE so as to not new up or use up anymore THAN THAT ONE TIME
// 'New is Glue'
//As this ^ is the only thing that really makes it run/links it together

//builder.Services.AddScoped<>(Iservice, service);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
<<<<<<< HEAD
builder.Services.AddScoped<ICustomerService, CustomerServices>();
builder.Services.AddScoped<IRecipe, RecipeService>();
builder.Services.AddScoped<IInventoryService,InventoryService>();
// lines 3-19 (or when 'var app' appears) is our ioc container, which looksat how things are set up, change the ability of when and how things are set up.
=======
// builder.Services.AddScoped<ICustomerService,CustomerService>();
builder.Services.AddScoped<IInventoryService,InventoryService>();
// builder.Services.AddTransient(new CustomerService());
// ^The way this is written isn't wrong, just another way of writing it out
// lines 3-when 'var app' appears is our ioc container, which looksat how things are set up, change the ability of when and how things are set up.
>>>>>>> c87e0be6093190fd3fc9200baf51efbf98320eae
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();