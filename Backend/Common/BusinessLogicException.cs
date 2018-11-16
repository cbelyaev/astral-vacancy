using System;
using System.Runtime.Serialization;

namespace AstralVacancy.Common
{
    /// <summary>
    ///     Маркерный "интерфейс" для всех видов ошибок в бизнес-логике приложения
    /// </summary>
    public abstract class BusinessLogicException: Exception
    {
        protected BusinessLogicException()
        {
        }

        protected BusinessLogicException(SerializationInfo info, StreamingContext context): base(info, context)
        {
        }

        protected BusinessLogicException(string message): base(message)
        {
        }

        protected BusinessLogicException(string message, Exception innerException): base(message, innerException)
        {
        }

        public abstract string UserFriendlyMessage { get; }

        public abstract object BlErrorData { get; }
    }
}