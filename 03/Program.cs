namespace OnlineRadioStation
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<Song> list = new List<Song>();
                int N = int.Parse(Console.ReadLine());

                int count = 0;
                int totalMinute = 0;
                int totalSecond = 0;
                int totalHours = 0;
                for (int i = 0; i < N; i++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    string name = input[0];
                    string artist = input[1];
                    int minute = int.Parse(input[2]);
                    int second = int.Parse(input[3]);

                    Song song = new Song(name, artist, minute, second);
                    list.Add(song);
                    count++;
                    Console.WriteLine("Song added.");

                    totalMinute += minute;
                    totalSecond += second;

                    totalMinute += totalSecond / 60;
                    totalSecond = totalSecond % 60;

                    totalHours = totalMinute / 60;
                    totalMinute = totalMinute % 60;
                }
                Console.WriteLine($"Songs added: {count}");
                Console.WriteLine($"Playlist length: {totalHours}h {totalMinute}m {totalSecond}s");



                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}