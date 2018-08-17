using System;
namespace Models
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Заполнение таблиц данными
            /*
            using (DbServiceDeskModel context = new DbServiceDeskModel())
            {
                User a = new User()
                {
                    Name = "NeVasya2",
                    Password = "333",
                    UserRole = Role.Manager
                };

                context.Users.Add(a);
                context.SaveChanges();
                Console.WriteLine("Запись прошла успешно");
            }
            */
            /*
            using (DbServiceDeskModel context = new DbServiceDeskModel())
            {
                Job j = new Job()
                {
                    Name = "FirstJob4",
                    Descr = "Nothing4",
                    Status = Status.Sent_back,
                    Open = DateTime.Now
                };

                context.Jobs.Add(j);
                context.SaveChanges();
                Console.WriteLine("Запись прошла успешно");
            }
            */
            #endregion
           
            #region Вывод списков пользователей и заданий
            /*
            UserStore Users = new UserStore();

            foreach (var item in Users.Users)
            {
                Console.WriteLine(item.Name);
            }
            */
            /*
            JobsModel Jobs = new JobsModel();

            foreach (var item in Jobs.jobs)
            {
                Console.WriteLine(item.Name);
            }
            */
            #endregion

            Console.ReadLine();
        }
    }
}
