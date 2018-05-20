using System;
using System.Security.Authentication;
using System.ServiceModel;

namespace Try.Dotnet.Roslyn.Source
{
    /// <summary>
    /// Property services implementation
    /// </summary>
    public class PropertyServices
    {
        #region Private Helpers

        private void ValidateAccess(Credentials credentials)
        {
            if (string.IsNullOrEmpty(credentials.Token))
                throw new InvalidCredentialException();
        }

        private Exception WrapException(Exception exception)
        {
            ServiceFault fault = new ServiceFault { Message = exception.Message };
            return new FaultException<ServiceFault>(fault);  
        }

        #endregion

        public Property GetProperty(Credentials credentials, int id)
        {
            //create logger instance
            AuditLogger logger = new AuditLogger(nameof(GetProperty));
            try
            {
                //validate credentials
                ValidateAccess(credentials);

                PropertyStorage storage = new PropertyStorage();
                Property property = storage.Get(id);
                
                logger.LogInformation("success");
                return property;
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                throw WrapException(ex);
            }
        }

        public void AddProperty(Credentials credentials, Property property)
        {
            //create logger instance
            AuditLogger logger = new AuditLogger(nameof(AddProperty));
            try
            {
                //validate credentials
                ValidateAccess(credentials);

                PropertyStorage storage = new PropertyStorage();
                storage.Add(property);
                
                logger.LogInformation("success");
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                throw WrapException(ex);
            }
        }

        public void UpdateProperty(Credentials credentials, Property property)
        {
            //create logger instance
            AuditLogger logger = new AuditLogger(nameof(UpdateProperty));
            try
            {
                //validate credentials
                ValidateAccess(credentials);

                PropertyStorage storage = new PropertyStorage();
                storage.Update(property);
                
                logger.LogInformation("success");
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                throw WrapException(ex);
            }
        }

        public void DeleteProperty(Credentials credentials, int id)
        {
            //create logger instance
            AuditLogger logger = new AuditLogger(nameof(UpdateProperty));
            try
            {
                //validate credentials
                ValidateAccess(credentials);

                PropertyStorage storage = new PropertyStorage();
                storage.Delete(id);
                
                logger.LogInformation("success");
            }
            catch (Exception ex)
            {
                logger.LogException(ex);
                throw WrapException(ex);
            }
        }
    }
}