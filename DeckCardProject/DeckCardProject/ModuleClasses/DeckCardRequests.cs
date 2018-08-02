using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using DeckCardProject.Config;
using Newtonsoft.Json;
using DeckCardProject.JsonObjects;

namespace DeckCardProject.ModuleClasses
{
    class DeckCardRequests
    {
        RestClient client;
        RestRequest request;
        public static int no_cards_remaining { get; set; }
        public static string deck_id { get; set; }

        public DeckCardRequests()
        {
            client = new RestClient(Configuration.BaseURL + Configuration.RelativeURL);
        }

        public IRestResponse createNewDeck()
        {
            request = new RestRequest();
            request.Resource = "new/";
            request.Method = Method.GET;
            var response = client.Execute(request);
            var response_json = JsonConvert.DeserializeObject<CreateNewDeckJson>(response.Content);
            deck_id = response_json.deck_id;
            return response;
        }

        public void drawCardsForGivenTimes(Method method, int no_of_times)
        {
            int cards_counter = 52;
            int count = 1;
            request = new RestRequest("{deck_id}/draw/");
            request.Method = method;

            while (count <= no_of_times)
            {
                request.AddParameter("deck_id", deck_id, ParameterType.UrlSegment);
                request.AddParameter("count", count, ParameterType.QueryString);

                var response = client.Execute(request);
                cards_counter -= count;
                count += 1;
            }

            no_cards_remaining = cards_counter;

        }

        public IRestResponse getRemainingCardsResponse(Method method)
        {
            request = new RestRequest("{deck_id}/draw/?count=0");
            request.Method = method;
            request.AddParameter("deck_id", deck_id, ParameterType.UrlSegment);
            return client.Execute(request);
        }

        public bool isRemainingCardsCorrect()
        {
            var response = getRemainingCardsResponse(Method.GET);
            var response_json = JsonConvert.DeserializeObject<DrawCardsJson>(response.Content);
            return response_json.remaining == no_cards_remaining;
        }
    }
}
