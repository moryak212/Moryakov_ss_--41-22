namespace Moryakov_КТ_41_22.Filters
{
    public class TeacherFilter
    {
        public string? FullName { get; set; }              // Поиск по ФИО
        public string? PositionName { get; set; }          // Должность
        public string? AcademicDegreeName { get; set; }    // Учёная степень
        public string? DepartmentName { get; set; }        // Кафедра
    }
}
