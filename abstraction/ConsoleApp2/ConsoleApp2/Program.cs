using System;

namespace ConsoleApp2
{
    public interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable , IRecodable
    {
     void IPlayable.Play()
        {
            Console.WriteLine("Play");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop");
        }
        void IRecodable.Record()
        {
            Console.WriteLine("Record");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Pause");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Stop");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            playable.Play();
            playable.Pause();
            playable.Stop();
            Console.WriteLine("\n");
            IRecodable recordable = new Player();
            recordable.Record();
            recordable.Pause();
            recordable.Stop();
        }
    }
}
