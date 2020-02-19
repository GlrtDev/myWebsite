﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using MyWebsite.Models;
using Microsoft.AspNetCore.Hosting;


namespace MyWebsite.Services
{
    public class JsonFileGithubProfileService
    {
        public JsonFileGithubProfileService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "GithubProfiles.json"); }
        }

        public IEnumerable<GithubProfile> GetProducts()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<GithubProfile[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        //public void AddRating(string productId, int rating)
        //{
        //    var products = GetProducts();

        //    if (products.First(x => x.Id == productId).Ratings == null)
        //    {
        //        products.First(x => x.Id == productId).Ratings = new int[] { rating };
        //    }
        //    else
        //    {
        //        var ratings = products.First(x => x.Id == productId).Ratings.ToList();
        //        ratings.Add(rating);
        //        products.First(x => x.Id == productId).Ratings = ratings.ToArray();
        //    }

        //    using (var outputStream = File.OpenWrite(JsonFileName))
        //    {
        //        JsonSerializer.Serialize<IEnumerable<Product>>(
        //            new Utf8JsonWriter(outputStream, new JsonWriterOptions
        //            {
        //                SkipValidation = true,
        //                Indented = true
        //            }),
        //            products
        //        );
        //    }
        //}
    }
}
