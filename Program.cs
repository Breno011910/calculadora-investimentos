var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/calcular", (
    decimal valor,
    decimal cdi,
    decimal percentualCdi,
    int dias) =>
{
    decimal taxaAnual = (cdi / 100) * (percentualCdi / 100);

    decimal taxaDiaria = (decimal)Math.Pow(
        (double)(1 + taxaAnual),
        1.0 / 252
    ) - 1;

    decimal rendimentoBruto = valor * (
        (decimal)Math.Pow(
            (double)(1 + taxaDiaria),
            dias
        ) - 1
    );

    decimal aliquotaIr;

    if (dias <= 180)
    {
        aliquotaIr = 22.5m;
    }
    else if (dias <= 360)
    {
        aliquotaIr = 20m;
    }
    else if (dias <= 720)
    {
        aliquotaIr = 17.5m;
    }
    else
    {
        aliquotaIr = 15m;
    }

    decimal imposto = rendimentoBruto * (aliquotaIr / 100);

    decimal rendimentoLiquido = rendimentoBruto - imposto;

    decimal saldoFinal = valor + rendimentoLiquido;

    return Results.Ok(new
    {
        ValorInvestido = valor,
        CDI = cdi,
        PercentualDoCDI = percentualCdi,
        DiasUteis = dias,
        AliquotaIR = aliquotaIr,
        RendimentoBruto = Math.Round(rendimentoBruto, 2),
        IR = Math.Round(imposto, 2),
        RendimentoLiquido = Math.Round(rendimentoLiquido, 2),
        SaldoFinal = Math.Round(saldoFinal, 2)
    });
});

app.Run();