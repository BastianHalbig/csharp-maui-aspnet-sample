﻿using CustomLib.Interfaces;
using CustomLib.Models.Comments;

namespace CustomLib.Clients
{
    /// <summary>
    /// A singleton for calling comment CRUD operations via HTTP.
    /// </summary>
    public class CommentsClient : AbstractClient<CommentGet, CommentPost, CommentPut>, CommentsInterface
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        public static readonly CommentsClient Instance = new CommentsClient();

        /// <summary>
        /// The private constructor preventing other singleton instances.
        /// </summary>
        private CommentsClient() : base("comments") { }
    }
}
