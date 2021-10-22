using LibreriaComponente.Interfaces;
using LibreriaComponente.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoServer.Services
{
    public class LogDataService: ILogData
    {
        public List<LogData> GetLogs()
        {
            var logs = new List<LogData>();
            logs.Add(new LogData { Id = 1, Level = "critic", Message = "Messaggio 1" });
            logs.Add(new LogData { Id = 2, Level = "critic", Message = "Messaggio 1" });
            logs.Add(new LogData { Id = 3, Level = "critic", Message = "Messaggio 1" });
            return logs;
        }
    }
}
