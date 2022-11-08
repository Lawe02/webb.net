namespace HockeySajt.Services
{
    public class Class1
    {
        public List<HockeyPlayer> HockeyPlayers()
        {
            return new List<HockeyPlayer>
            {
                new HockeyPlayer{Id = 1, Name= "Foppa", Team = "Sverige"},
                new HockeyPlayer{Id=2, Name = "Malkim", Team= "Ryssland"},
                new HockeyPlayer{Id=3, Name = "Salming", Team="Sverige"}
            };
        }
    }
}
