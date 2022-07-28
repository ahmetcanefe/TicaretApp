using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TicaretApp.Entity.Concrete;

namespace TicaretApp.Mvc.Areas.Admin.Models
{
    public class ProductAddViewModel
    {
        [DisplayName("Başlık")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage = "{0} alanı {1} karakterden büyük olmamalıdır.")]
        [MinLength(5, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Name { get; set; }

        [DisplayName("İçerik")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MinLength(20, ErrorMessage = "{0} alanı {1} karakterden küçük olmamalıdır.")]
        public string Description { get; set; }

        [DisplayName("Küçük Resim")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public IFormFile ThumbnailFile { get; set; }

        [DisplayName("Detay Resimler")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public List<IFormFile> ThumbnailFiles { get; set; }

        [DisplayName("Fiyat")]
        [Required]
        public double Price { get; set; }

        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsActive { get; set; }

        [DisplayName("Categories")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public List<int> CategoryIds { get; set; }

        [DisplayName("Brands")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int BrandId { get; set; }
        public List<string> SelectedColors { get; set; }
        public List<string> SelectedSizes { get; set; }
        public List<ProductDetailViewModel> ProductDetailViewModel { get; set; }
        public List<string> Colors { get; set; }
        public List<string> Sizes { get; set; }      
        public IList<Category> Categories { get; set; }
        public IList<Brand> Brands { get; set; }
    }
}
