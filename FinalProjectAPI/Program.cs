using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//builder.Services.AddScoped<>(Iservice, service);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
<<<<<<< HEAD
builder.Services.AddScoped<ICustomerService, CustomerServices>();
builder.Services.AddScoped<IRecipe, RecipeService>();
=======
builder.Services.AddScoped<IInventoryService,InventoryService>();
>>>>>>> 1bfe73a3bbf55c91f76af0863c681fada2af02d0
// lines 3-19 (or when 'var app' appears) is our ioc container, which looksat how things are set up, change the ability of when and how things are set up.
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