namespace Webproject.Application.Module.Game.GameModel
{
    public class GameEditRequest
    {
        public string GameName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int CateId { get; set; }
        public DateTime Created { get; set; }
    }
}