using NextFilm.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NextFilm.Services.OmdbService
{
    public class OmdbService:IOmdbService
    {
        private readonly string APIKEY = "f1f00800";

        public async Task<Film> Load(string Title, string Year)
        {
            string url = $"http://www.omdbapi.com/?apikey={APIKEY}&t={Title}&y={Year}";
            ApiHelper.InitializeClient();


            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    Film film = await response.Content.ReadAsAsync<Film>();
                    return film;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }

    }
}
