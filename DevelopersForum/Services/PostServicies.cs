using DevelopersForum.Models;
using DevelopersForum.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevelopersForum.Services
{
    public class PostService : IPostService
    {
        private readonly ApplicationDbContext _context;

        public PostService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task Add(Post post)
        {
            _context.Add(post);
            await _context.SaveChangesAsync();
        }

        public async Task AddReply(PostReply reply)
        {
            _context.PostReplies.Add(reply);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var forum = GetById(id);
            _context.Remove(forum);
            await _context.SaveChangesAsync();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts
                .Include(p => p.ApplicationUsers)
                .Include(p => p.Replies).ThenInclude(r => r.ApplicationUsers)
                .Include(p => p.Forum);
        }

        public Post GetById(int id)
        {
            return _context.Posts.Where(p => p.PostId == id)
                .Include(p => p.ApplicationUsers)
                .Include(p => p.Replies).ThenInclude(r => r.ApplicationUsers)
                .Include(p => p.Forum)
                .First();
        }

        public PostReply GetReplyById(string id)
        {
            return _context.PostReplies.Where(p => p.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Post> GetFilteredPosts(Forum forum, string searchQuery)
        { 
            return string.IsNullOrEmpty(searchQuery) 
                ? forum.Posts 
                : forum.Posts.Where(post 
                => post.Title.Contains(searchQuery)
                || post.Content.Contains(searchQuery));
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            return GetAll().Where(post
                => post.Title.Contains(searchQuery)
                || post.Content.Contains(searchQuery));
        }

        public IEnumerable<Post> GetLatestPosts(int n)
        {
           return GetAll().OrderByDescending(post => post.Created).Take(n);
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return _context.Forums
                .Where(f => f.ForumId == id).First()
                .Posts;
        }

        public PostReply UpdateReply(PostReply edittedReply)
        {
            PostReply reply = _context.PostReplies.FirstOrDefault(r => r.Id == edittedReply.Id);
            if (reply != null)
            {
                reply.Content = edittedReply.Content;
            }
            return reply;
        }
    }
}
