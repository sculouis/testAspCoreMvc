
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using testMvc.Models;

namespace testMvc.ViewModels{

 public class ProductListView{

     public IEnumerable<Product> prdState{get;set;}
 }
}