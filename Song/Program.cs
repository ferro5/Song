using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Song
{
    class Program
    {
        static void Main(string[] args)
        {
             PlayList?[]allLists = new PlayList?[20];
            Console.WriteLine("Wellcome to our Song List");
            Console.ReadLine();
            Console.WriteLine("Please enter the number Reading information");
            while (true)
            {
                var number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                            PrintInformation(allLists);
                        break;
                    case 2:
                        EditName();
                        break;
                    case 3:
                        SearchByGenre();
                        break;
                    case 4:
                        LoggestSong();
                        break;
                    case 5:
                        DeleteSong( allLists,number);
                        break;
                }
            }


            
        }

        private static void PrintInformation(PlayList?[] lists)
        {
            lists = new PlayList?[]
            {
                new PlayList {ID = 9,Author = "Author", Title = "Title1", Genre = "Rock", Length = 540},
                new PlayList {ID =8,Author = "Author1", Title = "Title2", Genre = "Jazz", Length = 240},
                new PlayList{ID = 3,Author = "Author3",Title = "Title3" ,Genre = "Pop",Length = 340},
                new PlayList{ ID = 4, Author = "Author4",Title = "Title4" ,Genre = "Rap",Length = 940},
            };
            for (int i = 0; i < lists.Length; i++)
            {
                Console.WriteLine($"Title={lists[i].Value.Title} || Author= {lists[i].Value.Author}|| Genre={lists[i].Value.Genre}|| Length={lists[i].Value.Length}");
            }
        }

        private static void DeleteSong( PlayList?[] list,int number)
        {
            Console.WriteLine($"Enter a number of song");
            var i = 0;
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                var playList = list[i];
                if (playList != null && playList.Value.ID == number)
                {
                    list[i] = null;
                }
                Console.WriteLine($"The song number {number} was deleted");
            }
        }

        private static void LogestSong()
        {
            throw new NotImplementedException();
        }

        private static void SearchByGenre()
        {
            throw new NotImplementedException();
        }

        private static void EditName()
        {
            throw new NotImplementedException();
        }
        
    }


    struct PlayList
    {
        public int ID { get; set; }
       public string Author { get; set; }
       public string Title { get; set; }
       public string Genre { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            return string.Format($"Author {Author} Title{Title} Genre{Genre} Length{Length}");
        }
    }
}
