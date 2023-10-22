using LogForU.Core.Appenders.Interfaces;
using LogForU.Core.Appenders;
using LogForU.Core.Loggers;
using LogForU.Core.Loggers.Interfaces;
using LogForU.Core.Enums;
using LogForU.Core.Utils;

var consoleAppender = new ConsoleAppender();

DateTimeValidator.AddFormat("M/dd/yyyy h:mm:ss tt");

ILogger logger = new Logger(consoleAppender);

logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
logger.Warning("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");
