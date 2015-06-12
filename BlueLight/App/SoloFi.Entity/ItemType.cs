﻿using System;
using XamlingCore.Portable.Model.Contract;

namespace SoloFi.Entity
{
    public class ItemType : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string GroupId { get; set; }
        public string GroupName { get; set; }

        public DateTime DateCreated { set; get; } // date item was created
        public string CreatedByUserId { set; get; } // id of the user who created it
        public DateTime DateLastModified { set; get; }  // datetime fo creation
        public string LastModifiedByUserId { set; get; }    // id of last user who modified it

        public bool? IsDeleted { get; set; }    // if item is deleted
        public bool? IsActive { get; set; }     // if item is active

        public override string ToString()
        {
            return this.Name;
        }
    }
}