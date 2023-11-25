using System;
namespace homeLibrary.Models
{
	public class Volume
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public int VolumeSet { get; set; }
		public string? Note { get; set; }
        public DateTime Created { get; set; }
    }
}

