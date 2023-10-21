using GymManager.Application.Common.Exceptions;
using GymManager.UI.Models;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace GymManager.UI.Controllers;
public abstract class BaseController : Controller
{
    private ISender _mediator;
    protected ISender Mediator => _mediator ??=
        HttpContext.RequestServices.GetService<ISender>();

    protected async Task<MediatorValideteResponse<T>> MediatorSendValidate<T>(IRequest<T> request)
    {
        var response = new MediatorValideteResponse<T> { IsValid = false };

        try
        {
            if(ModelState.IsValid)
            {
                response.Model = await Mediator.Send(request);
                response.IsValid = true;
                return response;
            }
        }
        catch(ValidationException exception)
        {
            foreach(var item in exception.Errors)
            {
                ModelState.AddModelError(item.Key, string.Join(".", item.Value));
            }
        }
        return response;
    }
}
