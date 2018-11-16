namespace AstralVacancy.Dal.Hh.Json
{
    /// <summary>
    /// Оклад
    /// </summary>
    public class SalaryJson
    {
        /// <summary>
        /// Нижняя граница вилки оклада
        /// </summary>
        public double? From { get; set; }

        /// <summary>
        /// Верняя граница вилки оклада
        /// </summary>
        public double? To { get; set; }

        /// <summary>
        /// Признак того что оклад указан до вычета налогов. В случае если не указано - null.
        /// </summary>
        public bool? Gross { get; set; }

        /// <summary>
        /// Валюта оклада
        /// </summary>
        public string Currency { get; set; }
    }
}