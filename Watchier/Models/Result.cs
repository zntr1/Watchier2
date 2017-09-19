using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Movies;
using TMDbLib.Objects.Search;
using TMDbLib.Objects.TvShows;

namespace Watchier
{
    class Result
    {
        public int id { get; set; }
        public string name { get; set; }

        public int votes { get; set; }
        public double rating { get; set; }

        public string posterPath { get; set; }
        public string overview { get; set; }

        public int numberOfSeasons { get; set; }
        public int numberOfEpisodes { get; set; }


        public List<int> episodeTime { get; set; }
        public DateTime? firstAirDate { get; set; }
        public DateTime? lastAirDate { get; set; }
        public bool inProduction { get; set; }

        public string homepage { get; set; }

        public double popularity { get; set; }
        public List<SearchTvSeason> seasons { get; set; }
        public List<Genre> genres { get; set; }

        public List<TvShow> similarShows { get; set; }



        // Leeres Result, standard Constructor
        public Result()
        {
            this.id = -1;
            this.name = "Empty";
            this.votes = -1;
            this.rating = -1;
            this.posterPath = "Empty";
            this.overview = "Empty";
            this.numberOfSeasons = -1;
            this.numberOfEpisodes = -1;
            this.episodeTime = new List<int> { -1 };
            this.inProduction = false;
            this.firstAirDate = new DateTime(1899, 12, 30);
            this.lastAirDate = new DateTime(1899, 12, 30);
            this.homepage = "Empty";
            this.popularity = -1;
            this.seasons = new List<SearchTvSeason> { }; ;
            this.genres = new List<Genre> { }; ;
            //this.similarShows = new List<TvShow> { }; 
        }

        public static Result getResultById(int showId)
        {
            Result res = new Result();
            TMDbClient client = Form1.mdbClient;

            // Hier Language ändern für Beschreibungen etc!
            TvShow show = client.GetTvShowAsync(showId, TvShowMethods.Similar, language: "en").Result;
            if (show == null) { return res; }

            res.id = show.Id;
            res.name = show.Name != null ? show.Name : res.name;
            res.posterPath = show.PosterPath != null ? show.PosterPath : res.posterPath;
            res.inProduction = show.InProduction;
            res.rating = show.VoteAverage;
            res.votes = show.VoteCount;
            res.overview = show.Overview != null ? show.Overview : res.overview;
            res.numberOfEpisodes = show.NumberOfEpisodes;
            res.numberOfSeasons = show.NumberOfSeasons;
            res.firstAirDate = show.FirstAirDate != null ? show.FirstAirDate : res.firstAirDate; // Fehler prüfen, Datetime
            res.lastAirDate = show.LastAirDate != null ? show.FirstAirDate : res.lastAirDate;   // Fehler prüfen, Datetime
            res.episodeTime = show.EpisodeRunTime != null ? show.EpisodeRunTime : res.episodeTime; // Fehler prüfen
            res.homepage = show.Homepage != null ? show.Homepage : res.homepage;
            res.popularity = show.Popularity;
            res.seasons = show.Seasons != null ? show.Seasons : res.seasons;
            res.genres = show.Genres != null ? show.Genres : res.genres;
            //res.similarShows = show.Similar.Results != null ? show.Similar.Results : res.similarShows;

            return res;
        }

        // Weiß net, unnötig.. First Result
        /// <summary>
        /// Get first Result!
        /// </summary>
        /// <param name="title"></param>
        /// <returns></returns>
        public static Result getResultByName(string title)
        {
            Result res = new Result();
            TMDbClient client = Form1.mdbClient;

            var resultList = client.SearchTvShowAsync(title).Result;
            if (resultList == null) { return null; }

            var showId = resultList.Results.First().Id;
            return getResultById(showId);
        }

        public static List<Result> getAllResultsByName(string title)
        {

            TMDbClient client = Form1.mdbClient;

            var yieldList = client.SearchTvShowAsync(title).Result.Results;
            List<Result> resultList = new List<Result>();
            if (yieldList == null) { return null; }

            foreach (var yieldFound in yieldList)
            {
                if (yieldFound.Name.ToLower().Contains(title.ToLower()))
                {
                    Result res = getResultById(yieldFound.Id);
                    resultList.Add(res);
                }
            }
            return resultList;
        }





    }
}
