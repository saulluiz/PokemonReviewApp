﻿using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository
{
    public class OwnerRepository : IOwnerRepository
        
    {
        private readonly DataContext _context;

        public OwnerRepository(DataContext context
            )
        {
            _context = context;
        }
        public Owner GetOwner(int ownerId)
        {
            return _context.Owners.Where(o => o.Id == ownerId).FirstOrDefault();
            
        }
      
        public ICollection<Owner> GetOwners()
        {
            return _context.Owners.ToList();
        }

        public ICollection<Owner> GetOwnersOfAPokemon(int pokeId)
        {
           return _context.PokemonOwners.Where(p=>p.Pokemon.Id == pokeId).Select(o=>o.Owner).ToList();
        }

        public ICollection<Pokemon> GetPokemonByOwner(int ownerId)
        {
            return _context.PokemonOwners.Where(p => p.OwnerId == ownerId).Select(o=>o.Pokemon).ToList();
        }

        public bool OwnerExists(int ownerId)
        {
           return _context.Owners.Any(o=>o.Id==ownerId);
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
        public bool CreateOwner(Owner owner)
        {
            _context.Add(owner);
            return Save();
        }
    }
}
