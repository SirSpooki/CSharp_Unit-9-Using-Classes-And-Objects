using static System.Console;
class TestSoccerPlayer
{
  static void Main()
  {
      SoccerPlayer mySoccerPlayer = new SoccerPlayer();
      mySoccerPlayer.Name = "Lionel";
      mySoccerPlayer.JerseyNum = 9;
      mySoccerPlayer.Goals = 8;
      mySoccerPlayer.Assists = 35;

  }
}
class SoccerPlayer
  {
      private string name;
      private int jerseyNum;
      private int goals;
      private int assists;

      public string Name
      {
          get
          {
              return name;
          }
          set
          {
            name = value;
          }
      }

      public int JerseyNum
      {
          get
          {
              return jerseyNum;
          }
          set
          {
            jerseyNum = value;
          }
      }
      
      public int Goals
      {
          get
          {
              return goals;
          }
          set
          {
            goals = value;
          }
      }

      public int Assists
      {
          get
          {
              return assists;
          }
          set
          {
            assists = value;
          }
      }

  }
