using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Abstraction_LoggerExample
{
    public abstract class Logger : ILogger
    {

        protected Logger()
        {
            logs = new List<Log>();
        }


        protected List<Log> logs;
        public abstract void Log(Log log);
        public abstract Log Search(Guid id);
        public abstract void Delete(Guid id);
        public abstract void MarkAsReviewed(Guid id);
       
    }
}
