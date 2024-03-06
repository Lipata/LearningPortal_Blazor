using System.Net.Http.Json;
using LearningPortal.Models.LearningApp;

namespace LearningPortal.LearningApp
{
    public class LearningAppService: ILearningAppService
    {
        private readonly HttpClient _http;

        public LearningAppService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<CurrentlyAttendingType>> GetCurrentlyAttendingList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/411814c4-bebf-4b2c-e661-08dab79fa5b4", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CurrentlyAttendingType>>().ConfigureAwait(false);
            }

            return new List<CurrentlyAttendingType>();
        }

        public async Task<List<CategoriesType>> GetCategoriesList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/c7c0f004-5d70-41db-e663-08dab79fa5b4", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<CategoriesType>>().ConfigureAwait(false);
            }

            return new List<CategoriesType>();
        }

        public async Task<List<PopularLecturersType>> GetPopularLecturersList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/f2c280b7-2b1b-47c5-e662-08dab79fa5b4", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<PopularLecturersType>>().ConfigureAwait(false);
            }

            return new List<PopularLecturersType>();
        }

        public async Task<List<AllCoursesType>> GetAllCoursesList()
        {
            using HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, new Uri("https://excel2json.io/api/share/28f292a3-d187-48c4-e660-08dab79fa5b4", UriKind.RelativeOrAbsolute));
            using HttpResponseMessage response = await _http.SendAsync(request).ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<List<AllCoursesType>>().ConfigureAwait(false);
            }

            return new List<AllCoursesType>();
        }
    }
}
