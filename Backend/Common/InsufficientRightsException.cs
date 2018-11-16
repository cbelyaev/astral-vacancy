namespace AstralVacancy.Common
{
    /// <summary>
    ///     Ошибка недостаточности прав
    /// </summary>
    public class InsufficientRightsException: BusinessLogicException
    {
        public InsufficientRightsException()
        {
            UserFriendlyMessage = ErrorText.InsufficientRights;
            BlErrorData = null;
        }

        public override string UserFriendlyMessage { get; }
        public override object BlErrorData { get; }
    }
}