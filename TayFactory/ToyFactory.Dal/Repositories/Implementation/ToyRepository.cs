using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using ToyFactory.Dal.Models;
using ToyFactory.Dal.Repositories.Interfaces;

namespace ToyFactory.Dal.Repositories.Implementation
{
    public class ToyRepository : IToyRepository
    {
        private readonly ToyFactoryContext _context;

        public ToyRepository(ToyFactoryContext context)
        {
            _context = context;
        }

        public IEnumerable<Toy> GetAll()
        {
            try
            {
                return _context.Toys.ToList();
            }
            catch (SqlException exception)
            {
                throw new CantConnectToDbException("Can't connect to DB");
            }
            
        }

        public Toy GetById(int toyId)
        {
            return _context.Toys.Find(toyId);
        }

        public void Insert(Toy toy)
        {
            _context.Toys.Add(toy);
        }

        public void Delete(int toyId)
        {
            var toy = _context.Toys.Find(toyId);
            _context.Toys.Remove(toy);
        }

        public void Update(Toy toy)
        {
            _context.Entry(toy).State = EntityState.Modified;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}