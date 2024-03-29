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
//            var fields = Get2();
//            foreach (var item in fields)
//            {
//                Console.WriteLine(item.Value);
//                Stats s = item.Value.PreRequisitos;
//                Console.WriteLine(s.Eco);
//            }
        }



        public IDictionary<string,Stats> Get() 
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

        public async void PostQuestion()
        {
            Stats s = PlayerStats.stats; 
            Solution one = new Solution("Opcao1", s);
            Solution two = new Solution("opcao2", s);
            Question q = new Question("blablabla"+ s.Eco, s, one, two);
            
            var a = await Firebase.Child("Questions").PostAsync(q);
        }
        
        public IDictionary<string,Question> Get2()
        {
            var registro = Firebase
                .Child("Questions")
                .OrderByKey()
                .StartAt("")
                .OnceAsync<Question>();

            var dict  = new Dictionary<string, Question>();

            foreach (var item in registro.Result)
                dict.Add(item.Key, item.Object);

            return dict;
      
        }

    }
}
