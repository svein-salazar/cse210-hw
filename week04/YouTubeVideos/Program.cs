using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("UNBOXING GALAXY S25 !!!!!!! Enfermo por Samsung...", "Tecnonauta", 1690);
        video1.AddComment(new Comment("Jose", "la estrategia de Samsung es que la gente se compre el teléfono del año anterior?"));
        video1.AddComment(new Comment("Morales", "Yo nunca he usado las funciones bluetooth tanto del s-pen del teléfono"));
        video1.AddComment(new Comment("Javier", "ya puedo tirar mi galaxy s24 a la basura"));
        
        Video video2 = new Video("Galaxy S25 Ultra vs iPhone 16 Pro Max | La Batalla", "Isa Marcial", 1074);
        video2.AddComment(new Comment("Angelitos", "Viendo cuál es mejor para que no me alcance para ninguno "));
        video2.AddComment(new Comment("UnRandom", "TEAM SAMSUNG💪"));
        video2.AddComment(new Comment("Axel", "el S25 Ultra muy basado JAJAJAJA"));

        Video video3 = new Video("Natalia Doco - RESPIRA (Album Version)", "Natalia Doco", 251);
        video3.AddComment(new Comment("Lydia", "Escuchar esta preciosa canción todas la mañanas a los ochenta años?  Porque no, me llena de energía!"));
        video3.AddComment(new Comment("Bolivar", "No es casualidad que estés aquí, cada cosa en la vida llega cuando estás preparando a recibirla, así que disfrútala, vívela, sientela y respira"));
        video3.AddComment(new Comment("Valentin", "Para todos los que sufrimos de ataques de pánico. Fuerza y respira!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
