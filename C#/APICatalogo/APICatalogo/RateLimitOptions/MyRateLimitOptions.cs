namespace APICatalogo.RateLimitOptions;

// Aqui estamos implementando a classe que tera as propriedades que estao no appsettings caso receba os valores irão ser colocados os valores padrões que estão contidos aqui
public class MyRateLimitOptions
{

    // para obter valores padrões aqui devemos fazer uma analise do nosso cenario e das necessidades que precisamos aplicar quando for definir a limitação de taxa
    // E precisamos colocar os nomes das propriedades do mesmo jeito que esta no arquivo de configuração

    public const string MyRateLimit = "MyRateLimit";
    public int PermitLimit { get; set; } = 5;
    public int Window { get; set; } = 10;
    public int ReplenishmentPeriod { get; set; } = 2;
    public int QueueLimit { get; set; } = 2;
    public int SegmentsPerWindow { get; set; } = 8;
    public int TokenLimit { get; set; } = 10;
    public int TokenLimit2 { get; set; } = 20;
    public int TokensPerPeriod { get; set; } = 4;
    public bool AutoReplenishment { get; set; } = true;

}
