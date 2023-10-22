using LogForU.Core.Enums;
using LogForU.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogForU.Core.Appenders.Interfaces;

public interface IAppender
{
    ReportLevel ReportLevel { get; set; }
    int MessagesAppended { get;}
    void AppendMessage(Message message);

}
