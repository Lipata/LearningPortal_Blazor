using LearningPortal.Models.LearningApp;

namespace LearningPortal.LearningApp
{
    public interface ILearningAppService
    {
        Task<List<CurrentlyAttendingType>> GetCurrentlyAttendingList();
        Task<List<CategoriesType>> GetCategoriesList();
        Task<List<PopularLecturersType>> GetPopularLecturersList();
        Task<List<AllCoursesType>> GetAllCoursesList();
    }
}
