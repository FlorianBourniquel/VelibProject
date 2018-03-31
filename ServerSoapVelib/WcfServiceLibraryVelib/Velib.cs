using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Web.Services;
using Newtonsoft.Json;
using static WcfServiceLibraryVelib.Cache;

namespace WcfServiceLibraryVelib
{
    public class Velib : IVelib
    {
        public List<Ville> GetVille(int deltaSeconde)
        {
            try
            {
                List<Ville> villes = cache.Get("GetVille") as List<Ville>;
                if (villes == null || !IsCacheValide(villes[0].dateCache, deltaSeconde))
                {
                    cache.Remove("GetVille");
                    var request =
                        WebRequest.Create(
                            "https://api.jcdecaux.com/vls/v1/contracts?apiKey=02fd363e8648fff6c773e31cbd634ac1ae4cfbb7");
                    // Get the response.
                    var response = request.GetResponse();
                    // Get the stream containing content returned by the server.
                    var dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    var reader = new StreamReader(dataStream);
                    // Read the content.  
                    var responseFromServer = reader.ReadToEnd();
                    villes = JsonConvert.DeserializeObject<List<Ville>>(responseFromServer);
                    DateTime date = DateTime.Now;
                    foreach (var ville in villes)
                    {
                        ville.dateCache = date;
                    }

                    cache.Add("GetVille", villes, null, System.Web.Caching.Cache.NoAbsoluteExpiration,
                        System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Default, null);
                    return villes;
                }

                return villes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public async Task<List<Ville>> GetVilleAsync(int deltaSeconde)
        {
            try
            {
                List<Ville> villes = cache.Get("GetVille") as List<Ville>;
                if (villes == null || !IsCacheValide(villes[0].dateCache, deltaSeconde))
                {
                    cache.Remove("GetVille");
                    var request =
                        WebRequest.Create(
                            "https://api.jcdecaux.com/vls/v1/contracts?apiKey=02fd363e8648fff6c773e31cbd634ac1ae4cfbb7");
                    // Get the response.
                    var responseTask = request.GetResponseAsync();

                    var response = await responseTask;
                    // Get the stream containing content returned by the server.
                    var dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    var reader = new StreamReader(dataStream);
                    // Read the content.  
                    var responseFromServer = reader.ReadToEnd();
                    villes = JsonConvert.DeserializeObject<List<Ville>>(responseFromServer);
                    DateTime date = DateTime.Now;
                    foreach (var ville in villes)
                    {
                        ville.dateCache = date;
                    }

                    cache.Add("GetVille", villes, null, System.Web.Caching.Cache.NoAbsoluteExpiration,
                        System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Default, null);
                    return villes;
                }

                return villes;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        public List<string> GetNomStationParVille(string ville, int deltaSeconde)
        {
            try
            {
                KeyValuePair<List<string>, DateTime> pair =
                    cache.Get("GetNomStationParVille" + ville) is KeyValuePair<List<string>, DateTime>
                        ? (KeyValuePair<List<string>, DateTime>) cache.Get("GetNomStationParVille" + ville)
                        : new KeyValuePair<List<string>, DateTime>();
                if (pair.Key == null || !IsCacheValide(pair.Value, deltaSeconde))
                {
                    cache.Remove("GetNomStationParVille" + ville);
                    List<Station> stations;
                    List<string> nomsStations = new List<string>();
                    var request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract=" +
                                                    ville + "&apiKey=02fd363e8648fff6c773e31cbd634ac1ae4cfbb7");
                    // Get the response.
                    var response = request.GetResponse();
                    // Get the stream containing content returned by the server.
                    var dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    var reader = new StreamReader(dataStream);
                    // Read the content.  
                    var responseFromServer = reader.ReadToEnd();
                    stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
                    // Display the content. 
                    foreach (var obj in stations) nomsStations.Add(obj.name);
                    pair = new KeyValuePair<List<string>, DateTime>(nomsStations, DateTime.Now);
                    cache.Add("GetNomStationParVille" + ville, pair, null,
                        System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration,
                        CacheItemPriority.Default, null);
                    return nomsStations;
                }

                return pair.Key;
            }
            catch (WebException we)
            {
                var resp = we.Response as HttpWebResponse;
                if (resp == null)
                    throw;
                List<string> rep = new List<string>();
                rep.Add(resp.StatusDescription);
                return rep;
            }
        }

        public async Task<List<string>> GetNomStationParVilleAsync(string ville, int deltaSeconde)
        {
            try
            {
                KeyValuePair<List<string>, DateTime> pair =
                    cache.Get("GetNomStationParVille" + ville) is KeyValuePair<List<string>, DateTime>
                        ? (KeyValuePair<List<string>, DateTime>) cache.Get("GetNomStationParVille" + ville)
                        : new KeyValuePair<List<string>, DateTime>();
                if (pair.Key == null || !IsCacheValide(pair.Value, deltaSeconde))
                {
                    cache.Remove("GetNomStationParVille" + ville);
                    List<Station> stations;
                    List<string> nomsStations = new List<string>();
                    var request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract=" +
                                                    ville + "&apiKey=02fd363e8648fff6c773e31cbd634ac1ae4cfbb7");
                    var responseTask = request.GetResponseAsync();
                    // Get the response.
                    var response = await responseTask;
                    // Get the stream containing content returned by the server.
                    var dataStream = response.GetResponseStream();

                    // Open the stream using a StreamReader for easy access.
                    var reader = new StreamReader(dataStream);
                    // Read the content.  
                    var responseFromServer = reader.ReadToEnd();
                    stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
                    // Display the content. 
                    foreach (var obj in stations) nomsStations.Add(obj.name);
                    pair = new KeyValuePair<List<string>, DateTime>(nomsStations, DateTime.Now);
                    cache.Add("GetNomStationParVille" + ville, pair, null,
                        System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration,
                        CacheItemPriority.Default, null);
                    return nomsStations;
                }

                return pair.Key;
            }
            catch (WebException we)
            {
                var resp = we.Response as HttpWebResponse;
                if (resp == null)
                    throw;
                List<string> rep = new List<string>();
                rep.Add(resp.StatusDescription);
                return rep;
            }
        }


        public Station GetInformationStation(string ville, string station, int deltaSeconde)
        {
            try
            {
                Station stationCache = cache.Get("GetInformationStation" + ville + station) as Station;
                if (stationCache == null || !IsCacheValide(stationCache.dateCache, deltaSeconde))
                {
                    cache.Remove("GetInformationStation" + ville + station);
                    List<Station> stations;
                    var request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract=" +
                                                    ville + "&apiKey=02fd363e8648fff6c773e31cbd634ac1ae4cfbb7");
                    var response = request.GetResponse();
                    // Get the stream containing content returned by the server.

                    var dataStream = response.GetResponseStream();

                    // Open the stream using a StreamReader for easy access.
                    var reader = new StreamReader(dataStream);
                    // Read the content.  
                    var responseFromServer = reader.ReadToEnd();
                    stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
                    foreach (var obj in stations)
                    {
                        if (obj.name.Contains(station.ToUpper()))
                        {
                            obj.dateCache = DateTime.Now;
                            cache.Add("GetInformationStation" + ville + station, obj, null,
                                System.Web.Caching.Cache.NoAbsoluteExpiration,
                                System.Web.Caching.Cache.NoSlidingExpiration,
                                CacheItemPriority.Default, null);
                            return obj;
                        }
                    }

                    return null;
                }

                return stationCache;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public async Task<Station> GetInformationStationAsync(string ville, string station, int deltaSeconde)
        {
            try
            {
                Station stationCache = cache.Get("GetInformationStation" + ville + station) as Station;
                if (stationCache == null || !IsCacheValide(stationCache.dateCache, deltaSeconde))
                {
                    cache.Remove("GetInformationStation" + ville + station);
                    List<Station> stations;
                    var request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract=" +
                                                    ville + "&apiKey=02fd363e8648fff6c773e31cbd634ac1ae4cfbb7");
                    var responseTask = request.GetResponseAsync();
                    // Get the response.
                    var response = await responseTask;
                    // Get the stream containing content returned by the server.

                    var dataStream = response.GetResponseStream();

                    // Open the stream using a StreamReader for easy access.
                    var reader = new StreamReader(dataStream);
                    // Read the content.  
                    var responseFromServer = reader.ReadToEnd();
                    stations = JsonConvert.DeserializeObject<List<Station>>(responseFromServer);
                    foreach (var obj in stations)
                    {
                        if (!obj.name.Contains(station)) continue;
                        obj.dateCache = DateTime.Now;
                        cache.Add("GetInformationStation" + ville + station, obj, null,
                            System.Web.Caching.Cache.NoAbsoluteExpiration, System.Web.Caching.Cache.NoSlidingExpiration,
                            CacheItemPriority.Default, null);
                        return obj;
                    }

                    return null;
                }

                return stationCache;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        private bool IsCacheValide(DateTime dateCache, int deltaSeconde)
        {
            TimeSpan time = TimeSpan.FromSeconds(deltaSeconde);
            TimeSpan span = DateTime.Now.Subtract(dateCache);
            return (span.CompareTo(time) < 0);
        }
    }
}