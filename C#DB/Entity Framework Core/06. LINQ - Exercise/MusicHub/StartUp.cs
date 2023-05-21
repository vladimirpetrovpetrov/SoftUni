namespace MusicHub
{
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using MusicHub.Data.Models;
    using System;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            MusicHubDbContext context =
                new MusicHubDbContext();

            DbInitializer.ResetDatabase(context);


            //Test your solutions here

            //Problem 2 (AlbumInfo)
            //var result = ExportAlbumsInfo(context, 9);
            //Console.WriteLine(result);

            //Problem 3 (SongsAboveDuration)
            var result2 = ExportSongsAboveDuration(context, 480);
            Console.WriteLine(result2);



        }

        public static string ExportAlbumsInfo(MusicHubDbContext context, int producerId)
        {
            StringBuilder st = new StringBuilder();
            var albums = context.Albums
                .Where(x => x.ProducerId == producerId)
                .Include(x => x.Producer)
                .Include(x => x.Songs)
                .Select(x => new AlbumResultModel
                {
                    AlbumName = x.Name,
                    ReleaseDate = x.ReleaseDate,
                    ProducerName = x.Producer.Name,
                    AlbumSongs = (HashSet<Song>)x.Songs,
                    Price = x.Price
                })
                .ToList();
            var count = 1;
            foreach (var album in albums.OrderByDescending(x => x.Price))
            {
                st.AppendLine($"-AlbumName: {album.AlbumName}");
                st.AppendLine($"-ReleaseDate: {album.ReleaseDate.ToString("MM/dd/yyyy")}");
                st.AppendLine($"-ProducerName: {album.ProducerName}");
                st.AppendLine($"-Songs:");
                foreach (var song in album.AlbumSongs.OrderByDescending(x => x.Name).ThenBy(x => x.Writer.Name))
                {
                    st.AppendLine($"---#{count++}");
                    st.AppendLine($"---SongName: {song.Name}");
                    st.AppendLine($"---Price: {song.Price:f2}");
                    st.AppendLine($"---Writer: {song.Writer.Name}");
                }
                st.AppendLine($"-AlbumPrice: {album.Price:f2}");
                count = 1;
            }
            return st.ToString().TrimEnd();
        }

        public static string ExportSongsAboveDuration(MusicHubDbContext context, int duration)
        {
            StringBuilder st = new StringBuilder();

            var songs = context.Songs
                .AsEnumerable()
                .Where(x=>x.Duration.TotalSeconds>duration)
                .Select(s=>new
                {
                    s.Name,
                    Performers = s.SongPerformers
                        .Select(p=>$"{p.Performer.FirstName} {p.Performer.LastName}")
                        .OrderBy(p=>p)
                        .ToArray(),
                    WriterName = s.Writer.Name,
                    AlbumProducer = s.Album!.Producer!.Name,
                    Duration = s.Duration.ToString("c")
                })
                .OrderBy(s=>s.Name)
                .ThenBy(s=> s.WriterName)
                .ToArray();
            var count = 1;

            foreach (var song in songs)
            {
                st.AppendLine($"-Song #{count++}");
                st.AppendLine($"---SongName: {song.Name}");
                st.AppendLine($"---Writer: {song.WriterName}");
                if (song.Performers.Length > 0)
                {
                    foreach (var performer in song.Performers)
                    {
                        st.AppendLine($"---Performer: {performer}");
                    }
                }
                st.AppendLine($"---AlbumProducer: {song.AlbumProducer}");
                st.AppendLine($"---Duration: {song.Duration}");
            }
            return st.ToString().TrimEnd();
        }
    }
}
