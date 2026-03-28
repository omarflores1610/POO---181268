namespace Lab_Ejercicios_2;

public class Album
{
    private string name;
    private string[] songNames;
    public Album(string name, string[] songs)
    {
        this.name = name;
        this.songNames = songs;
    }
    public void PlaySong(int index)
    {
        if (index >= songNames.Length)
        {
            throw new IndexOutOfRangeException();
        }
        Console.WriteLine("Escuchando lo siguiente: " + songNames[index]);
    }
    public void PlaySong(string song)
    {
        for (int i = 0; i < songNames.Length; i++)
        {
            if (songNames[i] == song)
            {
                Console.WriteLine("Reproduciendo: " + song);
                return;
            }
        }
        throw new ArgumentOutOfRangeException();
    }
}
