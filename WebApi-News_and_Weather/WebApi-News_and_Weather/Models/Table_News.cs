//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi_News_and_Weather.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_News
    {
        public int id { get; set; }
        public byte[] author { get; set; }
        public string title { get; set; }
        public byte[] description { get; set; }
        public byte[] url { get; set; }
        public string urlToImage { get; set; }
        public byte[] publishedAt { get; set; }
        public byte[] content { get; set; }
    }
}
