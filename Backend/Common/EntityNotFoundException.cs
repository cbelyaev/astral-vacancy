namespace AstralVacancy.Common
{
    /// <summary>
    ///     Ошибка получения несуществующего элемента
    /// </summary>
    public class EntityNotFoundException: BusinessLogicException
    {
        public EntityNotFoundException(string userFriendlyMessage, object blErrorData)
        {
            UserFriendlyMessage = userFriendlyMessage;
            BlErrorData = blErrorData;
        }

        public override string UserFriendlyMessage { get; }
        public override object BlErrorData { get; }
    }
}