
using System;

class BetterMusicProducer
{
    static void Main()
    {
        int numberAlbumsSoldEurope = int.Parse(Console.ReadLine());
        decimal priceAlbumEuro = decimal.Parse(Console.ReadLine());
        int numberAlbumsSoldNorthAmerica = int.Parse(Console.ReadLine());
        decimal priceAlbumUSD = decimal.Parse(Console.ReadLine());
        int numberAlbumsSoldSouthAmerica = int.Parse(Console.ReadLine());
        decimal priceAlbumPesos = decimal.Parse(Console.ReadLine());
        int numberOfConcertsPerTour = int.Parse(Console.ReadLine());
        decimal profitPerConcertInEuro = decimal.Parse(Console.ReadLine());

        decimal euro = 1.94M;
        decimal usd = 1.72M;
        decimal pesos = 332.74M;

        // profit from albums
        decimal profitEurope = (numberAlbumsSoldEurope * priceAlbumEuro * euro);
        decimal profitNA = (numberAlbumsSoldNorthAmerica * priceAlbumUSD * usd);
        decimal profitSA = (numberAlbumsSoldSouthAmerica * priceAlbumPesos / pesos);

        decimal albumsNetProfit = profitEurope + profitNA + profitSA;

        decimal producersCut = 0.35M;
        decimal albumTaxes = 0.20M;

        decimal albumsProfitAfterProducersCut = albumsNetProfit - (albumsNetProfit * producersCut);
        decimal albumsProfitAfterTaxes = albumsProfitAfterProducersCut - (albumsProfitAfterProducersCut * albumTaxes);

        // profit from tour

        decimal profitTourTotalBeforeProducersCut = (numberOfConcertsPerTour * profitPerConcertInEuro * euro);
        decimal producersCutTour = 0.15M;
        decimal profitTour;

        if (profitTourTotalBeforeProducersCut > 100000)
        {
            profitTour = profitTourTotalBeforeProducersCut - (profitTourTotalBeforeProducersCut * producersCutTour);
        }
        else
        {
            profitTour = profitTourTotalBeforeProducersCut;
        }

        if (albumsProfitAfterTaxes > profitTour)
        {
            Console.WriteLine("Let's record some songs! They'll bring us {0:F2}lv.", albumsProfitAfterTaxes);
        }
        else
        {
            Console.WriteLine("On the road again! We'll see the world and earn {0:F2}lv.", profitTour);
        }

    }
}



