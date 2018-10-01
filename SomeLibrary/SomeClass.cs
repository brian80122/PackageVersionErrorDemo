using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace SomeLibrary
{
    public class SomeClass
    {
        private ILogger _logger = LogManager.GetCurrentClassLogger();

        public SomeClass()
        {
            _logger.Info($"Init {nameof(SomeClass)}");   
        }

        public string Say()
        {
            return "Hello World";
        }
    }
}
