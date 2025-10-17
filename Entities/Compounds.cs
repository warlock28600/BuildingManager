﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BuldingManager.Entities
{
    public class Compounds:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get; set; }
        [JsonIgnore]
        public ICollection<BuildingEntity> Buildings { get; set; }
        public int CompoundSize => Buildings?.Count ?? 0;
    }
}
