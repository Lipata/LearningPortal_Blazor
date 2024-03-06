using LearningPortal.Models.LearningApp;

namespace LearningPortal.LearningApp
{
    public class MockLearningAppService : ILearningAppService
    {
        public Task<List<CurrentlyAttendingType>> GetCurrentlyAttendingList()
        {
            return Task.FromResult<List<CurrentlyAttendingType>>(new());
        }

        public Task<List<CategoriesType>> GetCategoriesList()
        {
            return Task.FromResult<List<CategoriesType>>(new());
        }

        public Task<List<PopularLecturersType>> GetPopularLecturersList()
        {
            return Task.FromResult<List<PopularLecturersType>>(new());
        }

        public Task<List<AllCoursesType>> GetAllCoursesList()
        {
            return Task.FromResult<List<AllCoursesType>>(new());
        }
    }
}
