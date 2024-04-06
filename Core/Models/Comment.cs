using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Comment
    {
        public int Id { get; set; }

        private static int _id = 0;
        public string Content { get; set; }

        public Comment( string content)
        {
            _id++;
            Id = _id;
            Content = content;

        }
        public Comment()
        {
            
        }

        public override string ToString()
        {
            return $" Id:{Id}\n Content:{Content}"; 
        }

       
        
            
        
    }
}
