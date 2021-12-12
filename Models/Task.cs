
namespace Task_Manager.Models
{
    public class Task
    {
        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public bool Important
        {
            get;
            set;
        }
        public string DueDate
        {
            get;
            set;
        }

        public int Status
        {
            get;
            set;
        }

        public string Location
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string User
        {
            get;
            set;
        }
    }
}