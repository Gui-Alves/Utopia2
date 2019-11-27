using System;
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
        }


        public async Task<Stats> Get() //Monta uma fila de execucao
        {
            var registro = await Firebase
                .Child("Stats")
                .OrderByKey()
                .StartAt("")
                .OnceAsync<Stats>();

            return registro as Stats;
           

        }

        public async Task Post(Stats stats)
        {
            var registro = await Firebase.Child("Stats").PostAsync(stats);
        }
    }
}
