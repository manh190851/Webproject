using Webproject.Data.EntityModel;

namespace Webproject.Application.Module.GameAccount.GameAccountModel
{
    public class GameAccountCreateRequest
    {
        public long AccId { get; set; }
        public string _Account { get; set; }
        public string _Password { get; set; }
        public List<AccountImage> Images { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public int GameId { get; set; }
        public Guid SalerId { get; set; }
    }
}