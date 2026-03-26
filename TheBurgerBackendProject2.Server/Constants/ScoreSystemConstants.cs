namespace TheBurgerBackendProject2.Server.Constants
{
    public class ScoreSystemConstants
    {
        /// <summary>
        /// The highest score a user can give to a Burgerplace.
        /// </summary>
        public const double SCORE_MAX = 5.0;

        /// <summary>
        /// The lowest value a user can give to a Burgerplace.
        /// </summary>
        public const double SCORE_MIN = 0.0;

        /// <summary>
        /// Number of significant digets after the decimalpoint, pertaining to what a user can give as a score.
        /// </summary>
        public const int SCORE_SIGNIFICANT_DIGETS_USER_GIVEN = 1;

        /// <summary>
        /// Number of significant digets after the decimalpoint, the resulting score of a Burgerplace is to be roundet off at.
        /// </summary>
        public const int SCORE_SIGNIFICANT_DIGETS_CALCULATED = 2;
    }
}
