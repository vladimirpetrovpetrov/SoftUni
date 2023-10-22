using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Loggers.Interfaces;
using LogForU.Core.Models;
using System;
using System.Collections.Generic;

namespace LogForU.Core.Loggers;

public class Logger : ILogger
{
    private readonly ICollection<IAppender> appenders;
    public Logger(params IAppender[] appenders) // we can add multiple appenders
    {
        this.appenders = appenders;
    }
    public void Info(string dateTime, string message)
        => AppendAll(dateTime, message, ReportLevel.Info);
    
    public void Warning(string dateTime, string message) 
        => AppendAll(dateTime, message, ReportLevel.Warning);
    public void Error(string dateTime, string message) 
        => AppendAll(dateTime, message, ReportLevel.Error);

    public void Critical(string dateTime, string message)
        => AppendAll(dateTime, message, ReportLevel.Critical);

    public void Fatal(string dateTime, string message)
        => AppendAll(dateTime, message, ReportLevel.Fatal);

    private void AppendAll(string dateTime, string message, ReportLevel reportLevel)
    {
        Message msg = new Message(dateTime, message, reportLevel);
        foreach (IAppender appender in this.appenders)
        {
            if(msg.ReportLevel >= appender.ReportLevel)
            {
            appender.AppendMessage(msg);
            }
        }
    }

    
}
