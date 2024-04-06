using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
   public class Blog
    {
        public int Id { get; set; } 

        private static int _id;
        
        private string _title { get; set; }

        private string _description { get; set; }

        public Blog(string title, string description)
        {
            _id++;
            Id = _id;
            _title = title;
            _description = description;
        }
        public Blog()
        {
            
        }

        public string Title 
        { 
            get 
            { 
                return _title; 
            } 
            set
            {
                if (_title.Length > 5)
                {
                    _title=value;
                }
            }
        
        }
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (_description.Length > 8)
                {
                    _description = value;
                }
            }
        }

        Comment[] Comments=new Comment[] { };

        public override string ToString()
        {
            return $" Title:{Title}\n Descripyion:{Description}"; 
        }


        public void  GetComment(int commentId)
        {
            for (int i = 0; i < Comments.Length; i++)
            {
                if (Comments[i].Id == commentId)
                {
                    Console.WriteLine(Comments[i]); 
                }
                
            }
           
        }

        public Comment[] GetAllComments()
        {
            Comment[] AllComments = new Comment[0];

            for (int i = 0;i < Comments.Length;i++)
            {
                Array.Resize(ref AllComments, AllComments.Length+1);
                AllComments[AllComments.Length-1] = Comments[i];
                
            }
            Console.WriteLine("-------------------------------------");
            return AllComments;
        }

        

        public void AddComment(Comment comment)
        {
            Array.Resize(ref Comments, Comments.Length+1);
            Comments[Comments.Length-1]= comment;
        }

        public Comment[] RemoveComment(int commentId)
        {
            Comment[] RemoveComment = new Comment[0];

            for(int i = 0; i<Comments.Length ; i++)
            {
                if (Comments[i].Id != commentId)
                {
                    Array.Resize(ref  RemoveComment, RemoveComment.Length+1);
                    RemoveComment[RemoveComment.Length - 1] = Comments[i];
                }

            }

            Comments = RemoveComment;
            return RemoveComment;
        }

        public void UpdateComment(int commentId,Comment comment) 
        {

            for( int i = 0; i<Comments.Length; i++)
            {
                if (Comments[i].Id == commentId) 
                {
                    Comments[i]=comment;
                    Comments[i].Id = commentId;
                    
                }
            }
        }



    }
}
