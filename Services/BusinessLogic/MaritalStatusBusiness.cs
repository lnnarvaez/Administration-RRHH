using Administration_RRHH.Domain;

namespace Administration_RRHH.Services.BusinessLogic
{
   
    public class MaritalStatusBusiness
    {
        private MaritalStatus _maritalStatus;

        #region Constructors
        public MaritalStatusBusiness()
        {
            _maritalStatus = new MaritalStatus();
        }

        #endregion

        #region Methods
        public List<MaritalStatus> ReadMaritalStatuses()
        {
            try
            {   
                return _maritalStatus.ListMaritalStatus();
            }
            catch (Exception ex)
            {
                throw new Exception("Intento fallido al leer los estados civiles.", ex);
            } //end try-catch
        }

        #endregion

    }//end class
}//end namespace
