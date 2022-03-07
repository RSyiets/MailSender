using System;
using System.IO;

namespace MailSender {
    class Logger : IDisposable
    {
        private static readonly string logdir = @"log\";
        private static Logger logger;
        private StreamWriter writer;

        private Logger(string logfile) 
        {
            if (!Directory.Exists(logdir))
            {
                Directory.CreateDirectory(logdir);
            }
            writer = new StreamWriter(logdir + logfile, /*append=*/true );
        }

        public static void Init(string logfile)
        {
            logger = new Logger(logfile);
        }

        public static void Info(string message)
        {
            logger.writer.WriteLine(string.Format(Message.V0InfoV1, DateTime.Now, message));
        }

        public static void Error(string message)
        {
            logger.writer.WriteLine(string.Format(Message.V0ErrorV1, DateTime.Now, message));
        }

        public static void Close()
        {
            logger.Dispose();
        }

        public void Dispose()
        {
            writer.Close();
            writer.Dispose();
        }
    }
}
