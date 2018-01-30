using System;
using System.Collections.Generic;
using System.Text;

namespace Jr.PublicationLibrary
{
    public class publicationRepo
    {
        private static List<Publication> _publications = new List<Publication>();
        private static int nextId = 0;
        public List<Publication> ListAll()
        {
            return (_publications);
        }
        public Publication GetById(int Id) => _publications.Find(p => p.Id == Id);
        public void Add(Publication newPublication)
        {
            newPublication.Id = nextId++;
            _publications.Add(newPublication);
        }

        public void Edit(Publication editPublication)

        {
            var origPublication = GetById(editPublication.Id);
            origPublication.Year = editPublication.Year;
            origPublication.Author = editPublication.Author;
            origPublication.Title = editPublication.Title;
           


        }
        public void Delete(int Id)
        {
            var PubToDelete = GetById(Id);
            _publications.Remove(PubToDelete);
        }
    }

}
