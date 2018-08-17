namespace ServiceDesk
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using Models;

    public class Model1 : DbContext
    {
        public Model1()
            : base("name=DbServiceDeskModel")
        {
        }
    }

}