using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webproject.Data.EF;
using Webproject.Data.EntityModel;
using Webproject.Data.Enum;

namespace Webproject.Layer.Module.PostModule
{
    public class PublicPost : IPublicPost
    {
        private WebprojectDbContext _db;

        public PublicPost(WebprojectDbContext db)
        {
            _db = db;
        }

        public async Task<int> Create(PostCreateModel model)
        {
            var post = new Post()
            {
                PostId = model.PostId,
                Title = model.Title,
                Created = DateTime.Now,
                Status = model.Status,
                IsDeleted = false,
                ShareCount = 0,
                Url = model.Url,
                UserId = model.UserId,
            };
            await _db.Posts.AddAsync(post);
            return await _db.SaveChangesAsync();
        }

        // Need UserID
        public async Task<int> Delete(int postId)
        {
            var post = await _db.Posts.FindAsync(postId);
            _db.Posts.Remove(post);
            return await _db.SaveChangesAsync();
        }


        public async Task<int> Update(int postid, PostUpdateModel model)
        {
            var post = _db.Posts.Find(postid);

            post.Title = model.Title;
            post.Created = DateTime.Now;
            post.Status = model.PostStatus;
            post.IsDeleted = model.IsDeleted;

            return await _db.SaveChangesAsync();
        }

        public async Task<List<PostViewModel>> ViewPost()
        {
            List<PostViewModel> postViewModels = new List<PostViewModel>();
            var posts = from post in _db.Posts select post;
            foreach (var post in posts)
            {
                PostViewModel model = new PostViewModel()
                {
                    Title = post.Title,
                    Url = post.Url,
                    Created = post.Created,
                    IsDeleted = post.IsDeleted,
                    ShareCount = post.ShareCount,
                    UserId = post.UserId,
                };
                postViewModels.Add(model);
            }
            return postViewModels;
        }

        public async Task<List<Comment>> ViewComment(int postId)
        {
            var comments = from comment in _db.Comments 
                           where comment.PostId == postId 
                           select comment;
            
            return comments.ToList();
        }

        public async Task<List<Reaction>> ViewReaction(int postId)
        {
            var reactions = from reaction in _db.Reactions
                            where reaction.PostId == postId
                            select reaction;

            return reactions.ToList();
        }

        public async Task<int> ChangeStatus(int postId, PostStatus newStatus)
        {
            var post = _db.Posts.Find(postId);

            post.Status = newStatus;

            return await _db.SaveChangesAsync();
        }

    }
}
