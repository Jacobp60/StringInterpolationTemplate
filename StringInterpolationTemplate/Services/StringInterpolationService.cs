using System;
using System.Reflection.Metadata.Ecma335;
using Microsoft.Extensions.Logging;
using StringInterpolationTemplate.Utils;

namespace StringInterpolationTemplate.Services;

public class StringInterpolationService : IStringInterpolationService
{
    private readonly ISystemDate _date;
    private readonly ILogger<IStringInterpolationService> _logger;

    public StringInterpolationService(ISystemDate date, ILogger<IStringInterpolationService> logger)
    {
        _date = date;
        _logger = logger;
        _logger.Log(LogLevel.Information, "Executing the StringInterpolationService");
    }

    //1. January 22, 2019 (right aligned in a 40 character field)
    public string Number01()
    {
        var date = _date.Now.ToString("MMMM dd, yyyy");
        var answer = $"{date,40}";
        Console.WriteLine(answer);

        return answer;
    }

    public string Number02()
    {
        var date = _date.Now.ToString("yyyy.mm.dd");
        

        return date;
    }

    public string Number03()
    {
        var date = $"Day {_date.Now:dd} of {_date.Now:MMMM, yyyy}";

        return date;
    }

    public string Number04()
    {
        var date =$"Year: {_date.Now:yyyy}, Month: {_date.Now:MM}, Day: {_date.Now:dd}";

        return date;
    }

    public string Number05()
    {
        var date = _date.Now.ToString("dddd");
        var answer = $"{date,10}";

        return answer;
    }

    public string Number06()
    {

        var answer = $"{_date.Now,10:t}{_date.Now,10:dddd}";

        return answer;
    }

    public string Number07()
    {
        var date = _date.Now.ToString("'h:'hh, 'm:'mm, 's:'ss");

        return date;
    }

    public string Number08()
    {
        var date = $"{_date.Now:yyyy.MM.dd.hh.mm.ss}";

        return date;
    }

    public string Number09()
    {
        var pi1 = Math.PI;
        var output = $"{pi1:C}";

        return output;
    }

    public string Number10()
    {
        var pi1 = Math.PI;
        var output = $"{pi1,10:N3}";
        return output;
    }

    public string Number11()
    {
        throw new NotImplementedException();
    }

    //2.2019.01.22
}
