using MediatR;

using Microsoft.Extensions.Logging;

namespace GymManager.Application.Common.Behaviours;
public class LoggingBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
    private readonly ILogger _logger;

    public LoggingBehaviour(ILogger<TRequest> logger)
    {
        _logger = logger;
    }

    public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
    {
        var requestName = typeof(TRequest).Name;

        _logger.LogInformation("### 1 ### Handling {requestName} ### 1 ###", requestName);

        _logger.LogInformation("### 2 ### GymManager Request: {@Name} {@Request} ### 2 ###", requestName, request);

        var response = await next();

        _logger.LogInformation("### 3 ### Handled {typeof(TResponse).Name} ### 3 ###", typeof(TResponse).Name);

        return response;
    }
}
