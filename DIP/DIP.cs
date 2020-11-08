using System;

namespace DIP
{
    public class FileLogger
    {
        public void LogMessage(string aStackTrace)
        {
            //code to log stack trace into a file.  
        }
    }

    public class ExceptionLogger
    {
        public void LogIntoFile(Exception aException)
        {
            FileLogger objFileLogger = new FileLogger();
            objFileLogger.LogMessage(GetUserReadableMessage(aException));
        }

        private string GetUserReadableMessage(Exception ex)
        {
            string strMessage = string.Empty;
            return strMessage;
        }
    }

    public class ManagerBusinessClass
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code to export data from files to database.  
            }
            catch (Exception ex)
            {
                new ExceptionLogger().LogIntoFile(ex);
            }
        }
    }
}