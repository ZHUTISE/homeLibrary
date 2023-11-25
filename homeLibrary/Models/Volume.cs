using System;
namespace homeLibrary.Models
{
	public class Volume
	{
		public int Id { get; set; }
		public VolumeSet VolumeSet { get; set; }
		public int VolumeNumber { get; set; }
		public string? Note { get; set; }
        public DateTime Created { get; set; }
    }
}

