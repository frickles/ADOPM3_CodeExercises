using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class AppLogItem
    {
        public string Type { get; set; }
        public string[] Info { get; set; }
        public override string ToString()
        {
            var sReturn = $"{Type}:\n";
            foreach (var item in Info)
            {
                sReturn += $"{item}\n";
            }
            return sReturn;
        }
    }

    //Example of a logger using Singleton design pattern
    public sealed class AppLog
    {
        private static AppLog _instance = null;

        private static Stack<AppLogItem> _logStack = null;

        //This is key for Singleton
        private AppLog()
        {
            _logStack = new Stack<AppLogItem>();
        }

        //This is the key for Singelton
        public static AppLog Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppLog();
                }
                return _instance;
            }
        }

        public void LogInformation(params string[] info)
        {
            _logStack.Push(new AppLogItem { Type = "Information", Info = info });
        }

        public void LogException(Exception ex)
        {
            var item = new AppLogItem();
            item.Type = "Exception";
            item.Info = new string[3];
            item.Info[0] = ex?.GetType().Name;
            item.Info[1] = ex?.Message;
            item.Info[2] = ex?.InnerException?.Message;
            _logStack.Push(item);
        }

        public List<AppLogItem> ToList()
        {
            return _logStack.ToList<AppLogItem>();
        }
    }
}

