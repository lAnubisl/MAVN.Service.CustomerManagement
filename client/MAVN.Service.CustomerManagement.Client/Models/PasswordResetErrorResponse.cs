using MAVN.Service.CustomerManagement.Client.Enums;

namespace MAVN.Service.CustomerManagement.Client.Models
{
    /// <summary>
    /// Response returning possible errors that might have happened
    /// </summary>
    public class PasswordResetErrorResponse
    {
        /// <summary>
        /// Holds any Errors that happened
        /// </summary>
        public PasswordResetError Error { get; set; }
    }
}
