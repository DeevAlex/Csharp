
namespace APICatalogo.Logging;

// essa classe implementa a interface ILogger
public class CustomerLogger : ILogger
{

    readonly string loggerName;
    readonly CustomLoggerProviderConfiguration loggerConfig;

    public CustomerLogger(string name, CustomLoggerProviderConfiguration config) // recebe o nome da categoria e uma instancia de 'CustomLoggerProviderConfiguration' que vai definir a configuração especifica para esse logger
    {
        loggerName = name;
        loggerConfig = config;
    }

    public IDisposable? BeginScope<TState>(TState state) // é o metodo da interface 'ILogger' que permite criar um escopo para mensagens de logging (não estamos utilizando então devemos retornar null)
    {
        return null;
    }

    public bool IsEnabled(LogLevel logLevel) // vai verificar se o nivel de log desejado está habilitado com base na configuração, caso não esteja habilitado as mensagens desse nivel não serão registradas 
    {
        return logLevel == loggerConfig.LogLevel;
    }

    public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter) // é chamado para registrar uma mensagem de log, ele verifica se o nivel de log é permitido e se necessario formata a mensagem usando um delegate formatter e vai escrever o texto no arquivo de log 
    {

        string mensagem = $"{logLevel.ToString()}: {eventId.Id} - {formatter(state, exception)}";

        EscreverTextoNoArquivo(mensagem);

    }

    private void EscreverTextoNoArquivo(string mensagem)
    {

        string caminhoDiretorioLog = @"c:\dados\log";

        if (Directory.Exists(caminhoDiretorioLog))
        {

            string caminhoArquivoLog = Path.Combine(caminhoDiretorioLog, "api_log.txt");

            using (StreamWriter streamWriter = new StreamWriter(caminhoArquivoLog, true))
            {

                try
                {

                    streamWriter.WriteLine($"{DateTime.Now} - {mensagem}");
                    streamWriter.Close();

                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    streamWriter.Close();
                }

            }

        } else
        {
            Directory.CreateDirectory(caminhoDiretorioLog);
            EscreverTextoNoArquivo(mensagem);
            return;
        }

    }
}
