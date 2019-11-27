﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using Utopia2.Models;

namespace Utopia2.Services
{
    class RealDatabaseService
    {
        FirebaseClient Firebase;

        public RealDatabaseService()
        {
            Firebase = new FirebaseClient("https://utopia-dd9ef.firebaseio.com/");
            var fields = Get();


            foreach (var item in fields)
            {
                Console.WriteLine(item.Value);
            }
        }



        public IDictionary<string,Stats> Get() //Monta uma fila de execucao
        {
            var registro = Firebase
                .Child("Stats")
                .OrderByKey()
                .StartAt("")
                .OnceAsync<Stats>();

            var dict  = new Dictionary<string, Stats>();

            foreach (var item in registro.Result)
                dict.Add(item.Key, item.Object);

            return dict;
      
        }

        public async void Post(Stats stats)
        {
            var registro = await Firebase.Child("Stats").PostAsync(stats);
        }
    }
}
