using System.Collections.Concurrent;

namespace APICatalogo.Logging;

// essa classe implementa a interface ILogger
public class CustomLoggerProvider : ILoggerProvider
{

    readonly CustomLoggerProviderConfiguration? loggerConfig;
    readonly ConcurrentDictionary<string, CustomerLogger> loggers = new ConcurrentDictionary<string, CustomerLogger>(); // um dicionario que a chave é o nome da categoria(essa categoria é normalmente um nome de uma classe ou um componente ) que é uma string e o valor uma instancia de CustomerLogger


    public CustomLoggerProvider(CustomLoggerProviderConfiguration configuration) // define a configuração para todos os loggers para este provedor
    {
        loggerConfig = configuration;
    }

    public ILogger CreateLogger(string categoryName) // vai ser usado para criar um logger para uma categoria especifica (categoryName), ele vai retorar um logger existente do dicionario loggers ou se não existir ele vai criar um novo se necessario
    {
        return loggers.GetOrAdd(categoryName, name => new CustomerLogger(name, loggerConfig));
    }

    public void Dispose() // libera os recursos quando o provedor for descartado
    {
        loggers.Clear(); 
    }

}
