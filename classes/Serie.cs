using System;
namespace Series
{
    public class Serie : BaseClass
    {
        private string Title { get; set;}
        public string title {get => Title; set => Title = value;}
        private string Description { get; set;}        
        private Genre Genre { get; set;}
        private int Year { get; set;} 
        private bool Deleted { get; set;}            

        public Serie(int id, string title, string description, Genre genre, int year){
            this.Id = id;
            this.Title =  title;
            this.Description = description;
            this.Genre = genre;
            this.Year = year;
            this.Deleted = false; 
        }

        public override string ToString(){
            string message = "";
            message += "Title: "+this.Title + Environment.NewLine;
            message += "Description: "+this.Description + Environment.NewLine;
            message += "Genre: "+this.Genre + Environment.NewLine;
            message += "Year: "+this.Year + Environment.NewLine;
            message += "Is Deleted: "+this.Deleted + Environment.NewLine;
            return message;
        }  

        public void Delete(){
            this.Deleted = true;
        }

        
    }
}