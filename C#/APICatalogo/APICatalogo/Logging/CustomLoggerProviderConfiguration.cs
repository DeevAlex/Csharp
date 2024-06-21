namespace APICatalogo.Logging;

public class CustomLoggerProviderConfiguration
{

    public LogLevel LogLevel { get; set; } = LogLevel.Warning; // Define o nivel minimo de log a ser registrado, com o padrão LogLevel.Warning
    public int EventId { get; set; } = 0; // Define o ID do evento de log, com padrão sendo zero

}
