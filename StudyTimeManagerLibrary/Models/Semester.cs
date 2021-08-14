namespace StudyTimeManagerLibrary.Models
{
    /// <summary>
    /// Represents a students semester
    /// </summary>
    class Semester
    {
        /// <summary>
        /// Weeks in a semester
        /// </summary>
        public int Weeks { get; set; }

        /// <summary>
        /// Start date of semester first week
        /// </summary>
        public DateOnly FirstWeekStartDate { get; set; }
    }
}
