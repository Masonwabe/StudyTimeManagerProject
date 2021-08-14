namespace StudyTimeManagerLibrary.Models
{
    /// <summary>
    /// Represents a semester module
    /// </summary>
    class Module
    {
        /// <summary>
        /// Module code
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Name of module
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Number of credits for module
        /// </summary>
        public int Credits { get; set; }

        /// <summary>
        /// Weekly class hours for module
        /// </summary>
        public decimal ClassHoursPerWeek { get; set; }

        /// <summary>
        /// Required weekly study hours
        /// </summary>
        public decimal StudyHoursPerWeek { get; set; }

        /// <summary>
        /// Weekly study hours left
        /// </summary>
        public int WeeklyStudyHoursLeft { get; set; }

        /// <summary>
        /// Calculate self study hours per-week
        /// </summary>
        /// <param name="numberOfWeeks">Number of weeks in semester</param>
        /// <returns>Weeekly self study hours</returns>
        public decimal CalculateWeeklyStudyHours(int numberOfWeeks) => ((Credits * 10) / numberOfWeeks) - ClassHoursPerWeek;
    }
}
