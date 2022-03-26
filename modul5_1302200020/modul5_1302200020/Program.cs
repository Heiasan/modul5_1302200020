using System;

namespace modul5_1302200020
{
    class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Jujutsu Kaisen 0 oleh Abdillah Hasan");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Violet Evergarden oleh Abdillah Hasan");
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Kimetsu No Yaiba oleh Abdillah Hasan");
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Grand Blue oleh Abdillah Hasan");
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Kimi No Nawa oleh Abdillah Hasan");
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Kotonoha No Niwa oleh Abdillah Hasan");
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Sword Art Online oleh Abdillah Hasan");
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film Kimi No Suizou Wo Tabetai oleh Abdillah Hasan");
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film No Game No Life oleh Abdillah Hasan");
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Boku No Hero Academia oleh Abdillah Hasan");

            SayaTubeUser namaripiu = new SayaTubeUser("Abdillah Hasan");

            video1.IncreasePlayCount(1);
            video2.IncreasePlayCount(3);
            
            namaripiu.AddVideo(video1);
            namaripiu.AddVideo(video2);
            namaripiu.AddVideo(video3);
            namaripiu.AddVideo(video4);
            namaripiu.AddVideo(video5);
            namaripiu.AddVideo(video6);
            namaripiu.AddVideo(video7);
            namaripiu.AddVideo(video8);
            namaripiu.AddVideo(video9);
            namaripiu.AddVideo(video10);

            video1.PrintVideoDetails();

            namaripiu.PrintAllVideoPlaycount();
        }
    }
}