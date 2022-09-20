﻿using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks_in_C_Sharp
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await MakeBreakfastAsnyc();
            
            async Task<string> MakeCoffeeAsync()
            {
                //Thread.CurrentThread.ManagedThreadId.Dump();
                var coffeeMaking = UseCoffeeMachineAsync();
                "Kaffee Tassen aus dem Schrank holen.".Dump();
                "Zucker und Milch bereit stellen.".Dump();
                var coffee = await coffeeMaking;
                var result = $"Fuelle {coffee} in die Tassen".Dump();
                return result;
            }

            async Task<string> UseCoffeeMachineAsync()
            {
                //Thread.CurrentThread.ManagedThreadId.Dump();
                "Schalte die Kaffeemaschine ein.".Dump();
                "Fuelle Kaffeepulver und Wasser in die Kaffeemaschine.".Dump();
                "Starte die Kaffeemaschine.".Dump();
                await Task.Delay(2000);
                "Kaffeemaschine wurde gekocht.".Dump();
                return "Kaffee";
            }

            async Task SetTableAsync()
            {
                "Hole Teller und Besteck aus dem Schrank".Dump();
                "Bringe Teller und Besteck ins Esszimmer".Dump();
                "Verteile Teller und Besteck auf dem Esstisch".Dump();
                await Task.Delay(4000);
                "Tisch ist gedeckt.".Dump();
            }

            async Task MakeBreakfastAsnyc()
            {
                await MakeCoffeeAsync();
                await SetTableAsync();
            }
        }
        
        
        
    }
}