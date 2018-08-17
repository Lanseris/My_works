using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Models
{
    public class Job 
    {
        
        public string descr;
        public Status status;

        public int JobId { get; set; }
        [Required]
        public DateTime? Open { get; set; }
        public DateTime? Close { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
        [Required]
        public string Name { get; set; }
        public string Commit { get; set; }

        [Required]
        public string Descr
        {
            get { return descr; }
            set
            {
                if (value == descr) return;
                descr = value;
              //  OnPropertyChanged();
            }
        }

        [Required]
        public Status Status
        {
            get { return status; }
            set
            {
                if (value == status) return;
                status = value;
              //  OnPropertyChanged();
            }
        }
        /*
        public Job(int id)
        {
            JobId = id;
        }
        */
        public override string ToString()
        {
            return string.Format(
                "ID:{0} open:{1} close:{2} user:{3} name:{4} descroption:{5} status:{6} last_commit:{7}",
                JobId,this.Open, Close, this.UserId , Name, Descr, Status, Commit);
        }


        #region Обязательно посмотреть для чего это нужно
        /*
       : INotifyPropertyChanged

       public event PropertyChangedEventHandler PropertyChanged;

       [NotifyPropertyChangedInvocator]
       protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
       {
           var handler = PropertyChanged;

           if (handler != null)
               handler(this, new PropertyChangedEventArgs(propertyName));
       }
       */
        #endregion

    }
}
