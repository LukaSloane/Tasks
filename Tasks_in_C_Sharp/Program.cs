using System;
using System.Security.Policy;
using System.Threading;
using System.Threading.Tasks;

namespace Tasks_in_C_Sharp
{
    internal class Program
    {
        public static async Task Main(string[] args)
        {
            await MittagsessenAsync();
            
            async Task MittagsessenAsync()
            {
                var nudeln = NudelnKochenAsync();
                var sauce = SauceKochenAsync();
                "Teller und Besteck aus dem Schrank nehmen".Dump();
                "Tisch decken.".Dump();
                await Task.WhenAll(nudeln, sauce);
                "Nudeln und Sauce auf den Teller geben.".Dump();
                "Enjoy! :)".Dump();
            }
            
            
            async Task<string> NudelnKochenAsync()
            {
                //Thread.CurrentThread.ManagedThreadId.Dump();
                var boilingWasser = WasserAufsetzenAsync();
                "Topf aus dem Schrank holen und auf den Herd stellen".Dump();
                var coffee = await boilingWasser;
                "Herdplatte anschalten".Dump();
                "Nudeln in den Topf geben.".Dump();
                "Kochendes Wasser zu den Nudeln in den Topf schütten.".Dump();
                await Task.Delay(8000);
                var nudeln = "Nudeln sind fertig.".Dump();
                return nudeln;
            }

            async Task<string> WasserAufsetzenAsync()
            {
                "Fuelle den Wasserkocher mit Wasser.".Dump();
                "Stelle den Wasserkocher an.".Dump();
                await Task.Delay(4000);
                var wasser = "Wasserkocher ist fertig.".Dump();
                return wasser;
            }

            async Task<string> SauceKochenAsync()
            {
                "Hole einen kleinen Topf aus dem Schrank und stelle ihn auf den Herd".Dump();
                "Herdplatte anschalten".Dump();
                "Barilla Sauce aus dem Glas in den Topf geben.".Dump();
                await Task.Delay(10000);
                var sauce = "Sauce ist fertig.".Dump();
                return sauce;
            }
            
            
            
        }
        
        
        
    }
}