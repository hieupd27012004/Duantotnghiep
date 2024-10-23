using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Model
{
	public class HinhAnh
	{
		//[Required(ErrorMessage = "Không Được Để Trống")]
		public Guid? IdHinhAnh { get; set; }

		//[Required(ErrorMessage = "Không được để trống")]
		public byte[]? DataHinhAnh { get; set; }
		//[Required(ErrorMessage = "Không được để trống")]
		public string? LoaiFileHinhAnh { get; set; }

		//[Required(ErrorMessage = "Không Được Để Trống")]
		public int? TrangThai { get; set; }

		[Display(Name = "Upload File")]

        public Guid? IdMauSac { get; set; }

        [NotMapped]
        public List<IFormFile> Files { get; set; }

        public virtual MauSac? MauSac { get; set; }

	}
}
