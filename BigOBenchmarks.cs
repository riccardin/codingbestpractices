
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

class Maze
{
  public int MazeNumber { get; set; }
  public Difficulty Difficulty { get; set; }
  public int LabRat1 { get; set; }
  public int LabRat2 { get; set; }
  public int LabRat3 { get; set; }
}
 
enum Difficulty
{
  Easy,
  Medium,
  Hard
}


class LabRat 
{ 
   public int TrackingId { get; set; } 
   public Color Color { get; set; } 
} 
enum Color 
{ 
    Black, 
    White, 
    Gray 
}

 	
class Race
{
  public int MazeNumber { get; set; }
  public int Participant { get; set; }
  public FinishTime FinishTime { get; set; }
}
 
enum FinishTime
{
  Fast,
  Average,
  Slow
}



public class BigOBenchmarks
{
  private const int N = 999;
 
  private readonly IList<LabRat> labRats;
  private readonly IList<Maze> mazes;
  private readonly IList<Race> races;

//Big-O O(n) Linear Time
    // public  BigOBenchmarks()
    // {

    //     labRats = new List<LabRat>(N);
    //       for (var i = 0; i < N; i++)
    //     {
    //         labRats.Add(new LabRat
    //         {
    //             TrackingId = i,
    //             Color = (Color)(i % 3)
    //         });
    //     }

    // }
 

public BigOBenchmarks ()
{
    mazes = new List<Maze>(N / 3);
    for (var i = 0; i < N / 3; i++)
    {
        mazes.Add(new Maze
        {
            MazeNumber = i,
            Difficulty = (Difficulty)(i % 3),
            LabRat1 = i,
            LabRat2 = i + N / 3,
            LabRat3 = i + N / 3 * 2
        });
    }
}

  // [Benchmark]
  // public int DummyBenchmark()
  // {
  //     var result = labRats.First(d => d.TrackingId == N - 1);
  //     return (int)result.Color;
  // }

[Benchmark]
public int DummyBenchmark(){

var result = 0;
 
foreach (var maze in mazes)
{
  var rat = labRats.First(r => r.TrackingId == N - 1);
 
  result = maze.LabRat3 == rat.TrackingId ? 
                   (int)maze.Difficulty : result;
}
 
return result;

}


}

//Big-O O(n2) Quadratic Time

