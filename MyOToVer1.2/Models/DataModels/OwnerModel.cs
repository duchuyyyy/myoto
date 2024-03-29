﻿using MyOToVer1._2.Data;

namespace MyOToVer1._2.Models.DataModels
{
    public class OwnerModel
    {
        private ApplicationDBContext db;

        public OwnerModel(ApplicationDBContext db)
        {
            this.db = db;
        }

        public void AddOwner(Owner cus)
        {
            db.Owners.Add(cus);
            db.SaveChanges();
        }

        public Owner FindOwnerById(int id)
        {
            return db.Owners.Find(id);
        }

        public void UpdateOwner(Owner owner)
        {
            db.Owners.Update(owner);
            db.SaveChanges();
        }

        public Owner FindOwnerByCarId(int carId)
        {
            return db.Owners.Find(carId);
        }

        public bool isOwner(int id)
        {
            return db.Owners.Where(p => p.Id == id).Any(p => p.owner_name_banking != "Chua co" && p.owner_number_account != "Chua co");
        }
    }
}
