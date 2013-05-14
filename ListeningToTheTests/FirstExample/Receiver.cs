using System;

namespace ListeningToTheTests.FirstExample
{
    public class Receiver
    {
        private DateTime? dateOfFirstRequest;

        public virtual bool AcceptRequest(Request request)
        {
            var now = new DateTime();
            
            if (dateOfFirstRequest == null)
            {
                dateOfFirstRequest = now;
            }
            else if (FirstDateIsDifferentFrom(now))
            {
                return false;
            }

            // Process request here...
            
            return true;
        }

        private bool FirstDateIsDifferentFrom(DateTime now)
        {
            return dateOfFirstRequest != now;
        }
    }
}