using Core.Models;
using System.ComponentModel.Design;
using System.Reflection;
namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Blog blog = new Blog();
            int choice;
            string check;
            bool result;

            do
            {
                Console.WriteLine("Menu:\n1.Blog yarat\n0.Proqramdan cix");
                choice =Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    do
                    {
                        do
                        {
                            Console.WriteLine("Title elave edin:");
                            string title = Console.ReadLine();

                            result = Helper.CheckBlogTitle(title);

                        }
                        while (!result);

                        do
                        {
                            Console.WriteLine(" ");
                            Console.WriteLine("Description elave edin:");
                            string description = Console.ReadLine();

                            result = Helper.CheckBlogDescription(description);
                        }
                        while (!result);


                    }
                    while (!result);

                    Blog newBlog= new Blog();

                    Console.WriteLine("Blog yaradildi");




                    do
                    {
                        Console.WriteLine("1.1 Comment yarat\n" +
                                      "1.2 Commentlere bax\n" +
                                      "1.3 Commente bax\n" +
                                      "1.4 Commenti sil\n" +
                                      "1.5 Commenti deyis\n" +
                                      "0. Esas menyuya qayit");
                        check = Console.ReadLine();


                        if (check == "1.1")
                        {
                            Console.WriteLine("Content daxil edin:");
                            string content = Console.ReadLine();

                            Comment newComment = new Comment(content);
                            blog.AddComment(newComment);

                            Console.WriteLine("Comment yaradildi!");
                        }
                        else if (check == "1.2")
                        {
                            for (int i = 0; i < blog.GetAllComments().Length; i++)
                            {
                                Console.WriteLine(blog.GetAllComments()[i]);
                            }
                        }
                        else if (check == "1.3")
                        {
                            Console.WriteLine("commentid ni daxil edin:");
                            int commentId = Convert.ToInt32(Console.ReadLine());

                            blog.GetComment(commentId);
                        }
                        else if (check == "1.4")
                        {
                            Console.WriteLine("CommentId daxil edin:");
                            int commentId = Convert.ToInt32(Console.ReadLine());

                            blog.RemoveComment(commentId);

                            Console.WriteLine("Comment silindi!");
                        }
                        else if (check == "1.5")
                        {
                            Console.WriteLine("CommentId daxil edin:");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("");
                            Console.WriteLine("Contenti daxil edin:");
                            string content = Console.ReadLine();

                            Comment newComment = new Comment(content);
                            blog.UpdateComment(id, newComment);
                            Console.WriteLine("Content deyisdirildi!");
                        }
                    }
                    while (check != "0");
                }
            }
                while (choice != 0);
            Console.WriteLine("Proqram bitdi!");
        }
    }
}
